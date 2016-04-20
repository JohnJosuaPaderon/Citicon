using Citicon.Data;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables
{
    public partial class MainForm : Form
    {
        StockManager stockManager;
        Stock[] unpaidStocks;
        bool loadingUnpaidStocks;
        Supplier activeSupplier;
        const string DATE_FORMAT = "MMM dd, yyyy";
        bool updatedSuccessfully;
        List<Stock> exportableStocks;
        public MainForm()
        {
            InitializeComponent();
            stockManager = new StockManager();
            stockManager.ExceptionCatched += ExceptionCatched;
            stockManager.NewItemGenerated += StockManager_NewItemGenerated;
            stockManager.NewUnpaidStockGenerated += StockManager_NewUnpaidStockGenerated;
            stockManager.Updated += StockManager_Updated;
            stockManager.UpdatedUnsuccessful += StockManager_UpdatedUnsuccessful;
        }

        private void StockManager_UpdatedUnsuccessful(Stock e)
        {
            updatedSuccessfully &= false;
        }

        private void StockManager_Updated(Stock e)
        {
            updatedSuccessfully &= true;
            exportableStocks.Add(e);
        }

        private void addStockToUnpaidStock(Stock e)
        {
            foreach (DataGridViewRow x in dgvUnpaidStocks.Rows)
            {
                if (e == (Stock)x.Cells[colStock.Name].Value) return;
            }
            DataGridViewRow row = new DataGridViewRow();
            var dateNow = DateTime.Now;
            var dueDate = new DateTime(e.DueDate.Year, e.DueDate.Month, e.DueDate.Day);
            var remaingDays = (e.DueDate - new DateTime(dateNow.Year, dateNow.Month, dateNow.Day)).Days;
            var today = remaingDays <= 0;
            row.Cells.Add(new DataGridViewTextBoxCell { Value = e });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = e.Supplier });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = (e.UnitPrice * e.AddedStockValue).ToString("#,##0.00") });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = $"{(today ? "TODAY" : $"{remaingDays} Day{(remaingDays > 1 ? "s" : string.Empty)}")}" });
            if (today)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 150, 50, 50);
                row.DefaultCellStyle.ForeColor = Color.White;
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 100, 0, 0);
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else if (remaingDays <= 7)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 50, 50);
                row.DefaultCellStyle.ForeColor = Color.White;
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 100, 50, 50);
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            row.Height = 40;
            Invoke(new Action(() => dgvUnpaidStocks.Rows.Add(row)));
        }

        private void StockManager_NewUnpaidStockGenerated(Stock e)
        {
            addStockToUnpaidStock(e);
        }

        private void StockManager_NewItemGenerated(Stock e)
        {
            
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            lblUserDisplayName.Text = User.CurrentUser.DisplayName;
            generateMrisNumber();
            await loadUnPaidStocks();
        }

        private async Task loadUnPaidStocks()
        {
            if (!loadingUnpaidStocks)
            {
                dgvUnpaidStocks.Rows.Clear();
                loadingUnpaidStocks = true;
                unpaidStocks = await stockManager.GetUnpaidListAsync();
                loadingUnpaidStocks = false;
            }
            else MessageBox.Show("Unpaid stocks already loading, please wait!");
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await loadUnPaidStocks();
        }

        private void displaySelectedUnpaidStock()
        {
            if (UnpaidStockHasSelectedRows)
            {
                var stock = (Stock)dgvUnpaidStocks.SelectedRows[0].Cells[colStock.Name].Value;
            }
        }

        private void dgvUnpaidStocks_SelectionChanged(object sender, EventArgs e)
        {
            displaySelectedUnpaidStock();
        }

        private void ViewUnpaidStockDetails_Click(object sender, EventArgs e)
        {
            UnpaidStockViewerForm form = new UnpaidStockViewerForm((Stock)dgvUnpaidStocks.SelectedRows[0].Cells[colStock.Name].Value);
            form.ShowDialog();
        }

        private void UnpaidStocksMenu_Opening(object sender, CancelEventArgs e)
        {
            UnpaidStocksMenu.Enabled = dgvUnpaidStocks.SelectedRows.Count == 1;
        }

        private bool UnpaidStockHasSelectedRows
        {
            get { return dgvUnpaidStocks.SelectedRows.Count > 0; }
        }
        private bool MrisIssuanceQueueHasSelectedRows
        {
            get { return dgvMrisNumberIssuanceQueue.SelectedRows.Count > 0; }
        }

        private void btnInsertToQueue_Click(object sender, EventArgs e)
        {
            if (UnpaidStockHasSelectedRows)
            {
                var row = dgvUnpaidStocks.SelectedRows[0];
                var stock = (Stock)row.Cells[colStock.Name].Value;
                if (activeSupplier == null)
                {
                    activeSupplier = stock.Supplier;
                    tbxActiveSupplier.Text = activeSupplier.Description;
                }
                if (activeSupplier == stock.Supplier)
                {
                    dgvMrisNumberIssuanceQueue.Rows.Add(stock, (stock.UnitPrice * stock.AddedStockValue).ToString("#,##0.00"));
                    dgvUnpaidStocks.Rows.Remove(row);
                }
                else MessageBox.Show("Supplier must be the same with Active Supplier");
            }
        }

        private void btnRemoveFromQueue_Click(object sender, EventArgs e)
        {
            if (MrisIssuanceQueueHasSelectedRows)
            {
                var row = dgvMrisNumberIssuanceQueue.SelectedRows[0];
                var stock = (Stock)row.Cells[colMrisNumberIssuanceQueue.Name].Value;
                addStockToUnpaidStock(stock);
                if (dgvMrisNumberIssuanceQueue.Rows.Count == 1)
                {
                    activeSupplier = null;
                    tbxActiveSupplier.Text = string.Empty;
                }
                dgvMrisNumberIssuanceQueue.Rows.Remove(row);
            }
        }

        private void lblGenerateMrisNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            generateMrisNumber();
        }

        private void generateMrisNumber()
        {
            tbxActiveMrisNumber.Text = stockManager.GenerateMrisNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            exportableStocks = new List<Stock>();
            updatedSuccessfully = true;
            foreach (DataGridViewRow row in dgvMrisNumberIssuanceQueue.Rows)
            {
                var stock = (Stock)row.Cells[colMrisNumberIssuanceQueue.Name].Value;
                stock.MrisNumber = tbxActiveMrisNumber.Text.Trim();
                stockManager.Update(stock);
            }
            generateMrisNumber();
            dgvMrisNumberIssuanceQueue.Rows.Clear();
            activeSupplier = null;
            tbxActiveSupplier.Text = string.Empty;
            if (updatedSuccessfully)
            {
                MessageBox.Show("Success!");
                try
                {
                    stockManager.ExportMrisReport(exportableStocks.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some or all Stocks are not saved successfully!");
            }
        }

        private void btnChequeVoucher_Click(object sender, EventArgs e)
        {
            ChequeVoucherForm form = new ChequeVoucherForm();
            form.ShowDialog();
        }

        private void btnMaintenanceForm_Click(object sender, EventArgs e)
        {
            MaintenanceForm form = new MaintenanceForm();
            form.ShowDialog();
        }

        private void btnChequeIssuance_Click(object sender, EventArgs e)
        {
            ChequeIssuanceForm form = new ChequeIssuanceForm();
            form.ShowDialog();
        }
    }
}
