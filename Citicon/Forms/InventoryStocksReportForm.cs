using Citicon.Data;
using Citicon.DataManager;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    public partial class InventoryStocksReportForm : Form
    {
        public InventoryStocksReportForm()
        {
            InitializeComponent();

            _ItemManager = new ItemManager();
            _SupplierManager = new SupplierManager();
            _BranchManager = new BranchManager();
        }

        private readonly ItemManager _ItemManager;
        private readonly SupplierManager _SupplierManager;
        private readonly BranchManager _BranchManager;

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            SearchButton.Text = "PLEASE WAIT...";
            SearchButton.Enabled = false;
            ExportButton.Enabled = false;
            await SearchAsync();
            SearchButton.Enabled = true;
            ExportButton.Enabled = true;
            SearchButton.Text = "SEARCH";
        }

        private async Task SearchAsync()
        {
            StockDataGridView.Rows.Clear();

            try
            {
                var stocks = await StockManager.Search(new SearchStockOptions
                {
                    Branch = BranchFilterComboBox.SelectedItem as Branch,
                    DeliveryDateRange = new DateTimeRange(DeliveryDateFilterBeginDateTimePicker.Value, DeliveryDateFilterEndDateTimePicker.Value),
                    DrNumber = DrNumberFilterNumericUpDown.Value.ToString(),
                    Item = DescriptionFilterComboBox.SelectedItem as Item,
                    SearchByBranch = BranchFilterCheckBox.Checked,
                    SearchByDeliveryDateRange = DeliveryDateFilterCheckBox.Checked,
                    SearchByDrNumber = DrNumberFilterCheckBox.Checked,
                    SearchByItem = DescriptionFilterCheckBox.Checked,
                    SearchBySiNumber = SiNumberFilterCheckBox.Checked,
                    SearchBySupplier = SupplierFilterCheckBox.Checked,
                    SiNumber = SiNumberFilterNumericUpDown.Value.ToString(),
                    Supplier = SupplierFilterComboBox.SelectedItem as Supplier
                });

                if (stocks != null && stocks.Any())
                {
                    foreach (var stock in stocks)
                    {
                        AddToUi(stock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUi(Stock stock)
        {
            var row = new DataGridViewRow()
            {
                Height = 30
            };

            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.Item });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.DeliveryDate });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.SiNumber });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.DrNumber });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.MrisNumber });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.AddedStockValue });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.UnitPrice });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.PaymentTerm });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.Branch });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.Company });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = stock.Supplier });

            StockDataGridView.Rows.Add(row);
        }

        private void DrNumberFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DrNumberFilterNumericUpDown.Enabled = DrNumberFilterCheckBox.Checked;
        }

        private void SiNumberFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SiNumberFilterNumericUpDown.Enabled = SiNumberFilterCheckBox.Checked;
        }

        private void DeliveryDateFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DeliveryDateFilterBeginDateTimePicker.Enabled = DeliveryDateFilterCheckBox.Checked;
            DeliveryDateFilterEndDateTimePicker.Enabled = DeliveryDateFilterCheckBox.Checked;
        }

        private void BranchFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BranchFilterComboBox.Enabled = BranchFilterCheckBox.Checked;
        }

        private void SupplierFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SupplierFilterComboBox.Enabled = SupplierFilterCheckBox.Checked;
        }

        private void DescriptionFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DescriptionFilterComboBox.Enabled = DescriptionFilterCheckBox.Checked;
        }

        private async void InventoryStocksReportForm_Load(object sender, EventArgs e)
        {
            await LoadItemsAsync();
            await LoadSuppliersAsync();
            await LoadBranchesAsync();
        }

        private async Task LoadItemsAsync()
        {
            DescriptionFilterComboBox.Items.Clear();

            var items = await _ItemManager.GetListAsync();

            if (items != null && items.Any())
            {
                DescriptionFilterComboBox.Items.AddRange(items);
            }
        }

        private async Task LoadSuppliersAsync()
        {
            SupplierFilterComboBox.Items.Clear();
            var suppliers = await _SupplierManager.GetListAsync();

            if (suppliers != null && suppliers.Any())
            {
                SupplierFilterComboBox.Items.AddRange(suppliers);
            }
        }

        private async Task LoadBranchesAsync()
        {
            BranchFilterComboBox.Items.Clear();
            var branches = await _BranchManager.GetListAsync();
            if (branches != null && branches.Any())
            {
                BranchFilterComboBox.Items.AddRange(branches);
            }
        }

        private async void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Text = "PLEASE WAIT...";
            SearchButton.Enabled = false;
            ExportButton.Enabled = false;
            await ExportAsync();
            SearchButton.Enabled = true;
            ExportButton.Enabled = true;
            ExportButton.Text = "EXPORT";
        }

        private async Task ExportAsync()
        {
            if (StockDataGridView.Rows.Count > 0)
            {
                var stocks = new List<Stock>();

                foreach (DataGridViewRow row in StockDataGridView.Rows)
                {
                    stocks.Add(row.Cells[StockColumn.Name].Value as Stock);
                }
                try
                {
                    await StockManager.ExportStocksReportAsync(stocks);
                    MessageBox.Show("Exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to export.{Environment.NewLine}{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Nothing to export.");
            }
        }
    }
}
