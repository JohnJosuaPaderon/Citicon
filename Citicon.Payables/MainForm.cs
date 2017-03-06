using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using Citicon.Payables.Data;
using Citicon.Payables.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Payables
{
    public partial class MainForm : Form
    {
        StockManager stockManager;
        ItemManager itemManager;
        SupplierManager supplierManager;
        BranchManager branchManager;
        ExpenseManager expenseManager;
        CompanyManager companyManager;
        
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
            //stockManager.NewItemGenerated += StockManager_NewItemGenerated;
            //stockManager.NewUnpaidStockGenerated += StockManager_NewUnpaidStockGenerated;
            stockManager.Updated += StockManager_Updated;
            stockManager.UpdatedUnsuccessful += StockManager_UpdatedUnsuccessful;

            itemManager = new ItemManager();
            itemManager.NewItemGenerated += ItemManager_NewItemGenerated;
            supplierManager = new SupplierManager();
            //supplierManager.NewItemGenerated += SupplierManager_NewItemGenerated;
            branchManager = new BranchManager();
            companyManager = new CompanyManager();
            //branchManager.NewItemGenerated += BranchManager_NewItemGenerated;
            expenseManager = new ExpenseManager();
            expenseManager.NewItemGenerated += ExpenseManager_NewItemGenerated;
        }

        private void ExpenseManager_NewItemGenerated(Expense e)
        {
            BeginInvoke(new Action(() =>
            {
                cmbxExpense.Items.Add(e);
            }));
        }

        private void BranchManager_NewItemGenerated(Branch e)
        {
            if (this != null)
            {
                //Invoke(new Action(() => cmbxFilterByBranch.Items.Add(e))); 
            }
        }

        private void SupplierManager_NewItemGenerated(Supplier e)
        {
            if (this != null)
            {
                Invoke(new Action(() => cmbxFilterBySupplier.Items.Add(e)));
            }
        }

        private void ItemManager_NewItemGenerated(Item e)
        {
            if (this != null)
            {
                Invoke(new Action(() => cmbxFilterByItem.Items.Add(e)));
            }
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
            if (this != null)
            {
                //foreach (DataGridViewRow x in dgvUnpaidStocks.Rows)
                //{
                //    if (e == (Stock)x.Cells[colStock.Name].Value) return;
                //}
                DataGridViewRow row = new DataGridViewRow();
                var dateNow = DateTime.Now;
                var dueDate = new DateTime(e.DueDate.Year, e.DueDate.Month, e.DueDate.Day);
                var remaingDays = (e.DueDate - new DateTime(dateNow.Year, dateNow.Month, dateNow.Day)).Days;
                var today = remaingDays <= 0;
                row.Cells.Add(new DataGridViewTextBoxCell { Value = e });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = e.SiNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = e.DrNumber });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = e.Supplier });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = e.AddedStockValue.ToString("#,##0.00") });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = e.DeliveryDate.ToString("MMMM dd, yyyy") });
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserDisplayName.Text = User.CurrentUser?.DisplayName;
            if (!User.CurrentUser.Admin)
            {
                btnChequeIssuance.Enabled = false;
                btnChequeVoucher.Enabled = false;
            }
            generateMrisNumber();
            Parallel.Invoke(
                /*() => loadUnPaidStocks(),*/
                /*async () => await branchManager.GetListAsync(),*/
                GetBranchList,
                GetSupplierList,
                GetCompanyList,
                /*async () => await supplierManager.GetListAsync(),*/
                /*GetItemList*/
                async () => await itemManager.GetListAsync(),
                async () => await expenseManager.GetListAsync());
        }

        private void GetCompanyList()
        {
            var task = companyManager.GetListAsync();

            task.ContinueWith(x =>
            {
                if (x.Status == TaskStatus.RanToCompletion)
                {
                    Invoke(new Action(() =>
                    {
                        cmbxAccountCompany.Items.AddRange(x.Result);
                    }));
                }
            });
        }

        private void GetBranchList()
        {
            var task = branchManager.GetListAsync();
            task.ContinueWith((x) =>
            {
                if (x.Status == TaskStatus.RanToCompletion)
                {
                    Invoke(new Action(() =>
                    {
                        cmbxAccountBranch.Items.AddRange(x.Result);
                    }));
                }
            });
        }

        private void GetSupplierList()
        {
            var task = supplierManager.GetListAsync();
            task.ContinueWith((x) =>
            {
                if (x.Status == TaskStatus.RanToCompletion)
                {
                    Invoke(new Action(() =>
                    {
                        cmbxFilterBySupplier.Items.AddRange(x.Result);
                    }));
                }
            });
        }

        private void GetItemList()
        {
            //var task = Task.Run(() =>
            //{
            //    return itemManager.GetList();
            //});
            ////var task = itemManager.GetListAsync();
            //task.ContinueWith((x) =>
            //{
            //    if (x.Status == TaskStatus.RanToCompletion)
            //    {
            //        Invoke(new Action(() =>
            //        {
            //            cmbxFilterByItem.Items.AddRange(x.Result);
            //        }));
            //    }
            //});

            Task.Run(() =>
            {
                var list = itemManager.GetList();
                Invoke(new Action(() =>
                {
                    cmbxFilterByItem.Items.AddRange(list);
                }));
            });
        }

        private void loadUnPaidStocks()
        {
            if (!loadingUnpaidStocks)
            {
                setColumnVisibility();
                dgvUnpaidStocks.Rows.Clear();
                gbxFilter.Enabled = false;
                tbxGrandTotal.Text = "0.00";
                loadingUnpaidStocks = true;
                Debug.WriteLine("Unpaid List Generated Start : {0}", DateTime.Now);
                var task = stockManager.GetUnpaidListAsync();
                task.ContinueWith(x =>
                {
                    if (x.Status == TaskStatus.RanToCompletion)
                    {
                        if (x.Result != null)
                        {
                            //Parallel.ForEach(x.Result.AsEnumerable(), y => addStockToUnpaidStock(y));
                            foreach (var item in x.Result)
                            {
                                Parallel.Invoke(() => addStockToUnpaidStock(item));
                            }
                            Debug.WriteLine("Unpaid List Generated End : {0}", DateTime.Now);
                        }
                    }
                    Invoke(new Action(() =>
                    {
                        loadingUnpaidStocks = false;
                        gbxFilter.Enabled = true;
                    }));
                    countGrandTotal();
                });
            }
            else MessageBox.Show("Unpaid stocks already loading, please wait!");
        }

        private void countGrandTotal()
        {
            Invoke(new Action(() =>
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dgvUnpaidStocks.Rows)
                {
                    var stock = (Stock)row.Cells[colStock.Name].Value;
                    total += stock != null ? (stock.UnitPrice * stock.AddedStockValue) : 0;
                }
                tbxGrandTotal.Text = total.ToString("#,##0.00");
            }));
        }

        private void setColumnVisibility()
        {
            //colStockSiNumber.Visible = !ckbxFilterBySiNumber.Checked;
            //colStockDrNumber.Visible = !ckbxFilterByDrNumber.Checked;
            colStockDeliveryDate.Visible = !ckbxFilterByDeliveryDate.Checked;
            //colStockBranch.Visible = !ckbxFilterByBranch.Checked;
            colStockSupplier.Visible = !ckbxFilterBySupplier.Checked;
            colStock.Visible = !ckbxFilterByItem.Checked;
        }

        private void loadFilteredUnpaidStock()
        {
            if (!loadingUnpaidStocks)
            {
                setColumnVisibility();
                dgvUnpaidStocks.Rows.Clear();
                gbxFilter.Enabled = false;
                tbxGrandTotal.Text = "0.00";
                loadingUnpaidStocks = true;
                var task = stockManager.GetFilteredUnpaidListAsyc(
                    ckbxFilterByItem.Checked, (Item)cmbxFilterByItem.SelectedItem,
                    ckbxFilterBySupplier.Checked, (Supplier)cmbxFilterBySupplier.SelectedItem,
                    false, null,
                    ckbxFilterByDeliveryDate.Checked, dtpFilterByDeliveryDate.Value,
                    ckbxFilterBySiNumber.Checked, (uint)nudFilterBySiNumber.Value,
                    ckbxFilterByDrNumber.Checked, (uint)nudFilterByDrNumber.Value);
                task.ContinueWith(x =>
                {
                    if (x.Status == TaskStatus.RanToCompletion)
                    {
                        if (x.Result != null)
                        {
                            //Parallel.ForEach(x.Result.AsEnumerable(), y => addStockToUnpaidStock(y));
                            foreach (var item in x.Result)
                            {
                                Parallel.Invoke(() => addStockToUnpaidStock(item));
                            }
                        }
                    }
                    Invoke(new Action(() =>
                    {
                        loadingUnpaidStocks = false;
                        gbxFilter.Enabled = true;
                    }));
                    countGrandTotal();
                });
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUnPaidStocks();
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
            if (dgvMrisNumberIssuanceQueue.Rows.Count > 0)
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
                        stockManager.ExportMrisReport(exportableStocks.ToArray(), UsageTextBox.Text, ReceivedStoredByTextBox.Text, InspectedAcceptedByTextBox.Text, ApprovedByTextBox.Text);
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
            else MessageBox.Show("No MRIS to be issued.");
        }

        private void btnChequeVoucher_Click(object sender, EventArgs e)
        {
            ChequeVoucherForm form = new ChequeVoucherForm();
            form.Show();
        }

        private void btnMaintenanceForm_Click(object sender, EventArgs e)
        {
            MaintenanceForm form = new MaintenanceForm();
            form.ShowDialog();
        }

        private void btnChequeIssuance_Click(object sender, EventArgs e)
        {
            ChequeIssuanceForm form = new ChequeIssuanceForm();
            form.Show();
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User.CurrentUser = null;
            Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.ShowDialog();
        }

        private void SetFilterButtonEnable()
        {
            btnFilter.Enabled =
                //ckbxFilterByBranch.Checked ||
                ckbxFilterByDeliveryDate.Checked ||
                ckbxFilterByItem.Checked ||
                ckbxFilterBySupplier.Checked ||
                ckbxFilterByDrNumber.Checked ||
                ckbxFilterBySiNumber.Checked;
        }

        private void ckbxFilterByItem_CheckedChanged(object sender, EventArgs e)
        {
            cmbxFilterByItem.Enabled = ckbxFilterByItem.Checked;
            SetFilterButtonEnable();
        }

        private void ckbxFilterBySupplier_CheckedChanged(object sender, EventArgs e)
        {
            cmbxFilterBySupplier.Enabled = ckbxFilterBySupplier.Checked;
            SetFilterButtonEnable();
        }

        private void ckbxFilterByBranch_CheckedChanged(object sender, EventArgs e)
        {
            //cmbxFilterByBranch.Enabled = ckbxFilterByBranch.Checked;
            //SetFilterButtonEnable();
        }

        private void ckbxFilterByDeliveryDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterByDeliveryDate.Enabled = ckbxFilterByDeliveryDate.Checked;
            SetFilterButtonEnable();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            loadFilteredUnpaidStock();
        }

        private void ckbxFilterByDrNumber_CheckedChanged(object sender, EventArgs e)
        {
            nudFilterByDrNumber.Enabled = ckbxFilterByDrNumber.Checked;
            SetFilterButtonEnable();
        }

        private void ckbxFilterBySiNumber_CheckedChanged(object sender, EventArgs e)
        {
            nudFilterBySiNumber.Enabled = ckbxFilterBySiNumber.Checked;
            SetFilterButtonEnable();
        }

        private void dgvUnpaidStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudFilterBySiNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxGrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReprintMris_Click(object sender, EventArgs e)
        {
            var stocks = stockManager.GetListByMrisNumber_Reprint(tbxReprintMris.Text);
            if (stocks?.Length > 0)
            {
                try
                {
                    stockManager.ExportMrisReport(stocks, UsageTextBox.Text, ReceivedStoredByTextBox.Text, InspectedAcceptedByTextBox.Text, ApprovedByTextBox.Text);
                    MessageBox.Show("Successfully exported!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to reprint MRIS.", "Reprint MRIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nothing was found", "Reprint MRIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChangeAccountDescription_Click(object sender, EventArgs e)
        {
            if (dgvMrisNumberIssuanceQueue.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Selected Stock");
                return;
            }

            var row = dgvMrisNumberIssuanceQueue.SelectedRows[0];
            var index = row.Index;

            var stock = (Stock)row.Cells[colMrisNumberIssuanceQueue.Name].Value;
            stock.Expense = (Expense)cmbxExpense.SelectedItem;
            stock.Branch = (Branch)cmbxAccountBranch.SelectedItem;
            stock.Company = (Company)cmbxAccountCompany.SelectedItem;

            dgvMrisNumberIssuanceQueue.Rows[index].Cells[colMrisNumberIssuanceQueue.Name].Value = stock;
            dgvMrisNumberIssuanceQueue.InvalidateCell(dgvMrisNumberIssuanceQueue.Rows[index].Cells[colMrisNumberIssuanceQueue.Name]);

            ClearAccountChange();
        }

        private void ClearAccountChange()
        {
            cmbxAccountBranch.SelectedItem = null;
            cmbxAccountCompany.SelectedItem = null;
            cmbxExpense.SelectedItem = null;
        }

        private void btnRemoveExpenseClassification_Click(object sender, EventArgs e)
        {
            if (dgvMrisNumberIssuanceQueue.SelectedRows.Count == 0)
            {
                MessageBox.Show("No selected stock");
                return;
            }

            var row = dgvMrisNumberIssuanceQueue.SelectedRows[0];
            var index = row.Index;

            var stock = (Stock)row.Cells[colMrisNumberIssuanceQueue.Name].Value;
            stock.Expense = null;

            dgvMrisNumberIssuanceQueue.Rows[index].Cells[colMrisNumberIssuanceQueue.Name].Value = stock;
            dgvMrisNumberIssuanceQueue.InvalidateCell(dgvMrisNumberIssuanceQueue.Rows[index].Cells[colMrisNumberIssuanceQueue.Name]);
        }
    }
}
