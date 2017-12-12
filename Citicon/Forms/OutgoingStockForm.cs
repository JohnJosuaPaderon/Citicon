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
    public partial class OutgoingStockForm : Form
    {
        public OutgoingStockForm()
        {
            InitializeComponent();
            _TransactionManager = new TransactionManager();
        }

        private readonly TransactionManager _TransactionManager;

        public Item CurrentItem { get; set; }
        public Transaction CurrentTransaction { get; set; }
        public Stock LatestStock { get; set; }

        private async void OutgoingStockForm_Load(object sender, EventArgs e)
        {
            LoadSearchCategory();
            await GetLatestIssuanceSlipNumberAsync();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await SearchAsync();
        }

        private async void ItemDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            await SetCurrentItemAsync();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditTransaction();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveTransaction();
        }

        private async void SaveAndPrintButton_Click(object sender, EventArgs e)
        {
            await SaveAndPrintAsync();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddTransaction();
        }

        private void RemoveTransaction()
        {
            if (OutgoingStockDataGridView.SelectedRows.Count == 1)
            {
                var row = OutgoingStockDataGridView.SelectedRows[0];
                OutgoingStockDataGridView.Rows.Remove(row);
            }
        }

        private void AddTransaction()
        {
            if (CurrentItem != null)
            {
                foreach (DataGridViewRow row in OutgoingStockDataGridView.Rows)
                {
                    if (CurrentItem == (row.Cells[OutgoingStockColumn.Name].Value as Transaction).Item)
                    {
                        MessageBox.Show("Item already exists.");
                        return;
                    }
                }

                var result = ManageOutgoingStockItemForm.Add(CurrentItem, LatestStock?.UnitPrice, LatestStock?.DeliveryDate);

                if (!result.IsCancelled)
                {
                    AddToUi(result.Transaction);
                }
            }
        }

        private void EditTransaction()
        {
            if (OutgoingStockDataGridView.SelectedRows.Count == 1)
            {
                var row = OutgoingStockDataGridView.SelectedRows[0];
                var transaction = row.Cells[OutgoingStockColumn.Name].Value as Transaction;

                var result = ManageOutgoingStockItemForm.Edit(transaction);

                if (!result.IsCancelled)
                {
                    UpdateRow(row, result.Transaction);
                    OutgoingStockDataGridView.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Select only 1 outgoing stock item.");
            }
        }

        private void UpdateRow(DataGridViewRow row, Transaction transaction)
        {
            row.Cells[OutgoingStockColumn.Name].Value = transaction;
            row.Cells[OutgoingStock_ItemColumn.Name].Value = transaction.Item;
            row.Cells[OutgoingStock_CodeColumn.Name].Value = transaction.Item?.Code;
            row.Cells[OutgoingStock_TransactionDateColumn.Name].Value = transaction.TransactionDate;
            row.Cells[OutgoingStock_RemovedStockValueColumn.Name].Value = transaction.RemovedStockValue;
            row.Cells[OutgoingStock_BranchColumn.Name].Value = transaction.Branch;
            row.Cells[OutgoingStock_CompanyColumn.Name].Value = transaction.Company;
            row.Cells[OutgoingStock_VehicleColumn.Name].Value = transaction.Truck;
            row.Cells[OutgoingStock_RequestedByColumn.Name].Value = transaction.RequestedBy;
            row.Cells[OutgoingStock_ReleasedByColumn.Name].Value = transaction.ReleasedBy;
        }

        private void SetCurrentTransaction(Transaction transaction)
        {
            if (transaction != null)
            {
                CurrentTransaction = transaction;
            }
            else
            {
                CurrentTransaction = null;
                ItemLastPriceTextBox.Text = string.Empty;
                ItemLastPriceDateTextBox.Text = string.Empty;
            }
        }

        private void LoadSearchCategory()
        {
            SearchByComboBox.Items.Clear();
            SearchByComboBox.Items.Add(SearchItemCategory.Description);
            SearchByComboBox.Items.Add(SearchItemCategory.Code);

            SearchByComboBox.SelectedIndex = 0;
        }

        private async Task SearchAsync()
        {
            EnableSearchControls(false);

            try
            {
                ItemDataGridView.Rows.Clear();

                var items = await ItemManager.SearchAsync((SearchItemCategory)SearchByComboBox.SelectedItem, SearchTextBox.Text);

                if (items != null && items.Any())
                {
                    foreach (var item in items)
                    {
                        AddToUi(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            EnableSearchControls(true);
        }

        private void EnableSearchControls(bool enabled)
        {
            SearchTextBox.Enabled = enabled;
            SearchByComboBox.Enabled = enabled;
            SearchButton.Enabled = enabled;
        }

        private void AddToUi(Item item)
        {
            var row = new DataGridViewRow()
            {
                Height = 30
            };

            row.Cells.Add(new DataGridViewTextBoxCell { Value = item });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Code });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = item.StockValue });

            ItemDataGridView.Rows.Add(row);
        }

        private void AddToUi(Transaction transaction)
        {
            var row = new DataGridViewRow
            {
                Height = 30
            };

            row.Cells.AddRange(
                new DataGridViewTextBoxCell { Value = transaction },
                new DataGridViewTextBoxCell { Value = transaction.Item },
                new DataGridViewTextBoxCell { Value = transaction.Item?.Code },
                new DataGridViewTextBoxCell { Value = transaction.TransactionDate },
                new DataGridViewTextBoxCell { Value = transaction.RemovedStockValue },
                new DataGridViewTextBoxCell { Value = transaction.Branch },
                new DataGridViewTextBoxCell { Value = transaction.Company },
                new DataGridViewTextBoxCell { Value = transaction.Truck },
                new DataGridViewTextBoxCell { Value = transaction.RequestedBy },
                new DataGridViewTextBoxCell { Value = transaction.ReleasedBy });

            OutgoingStockDataGridView.Rows.Add(row);
        }

        private async Task SetCurrentItemAsync()
        {
            if (ItemDataGridView.SelectedRows.Count == 1)
            {
                CurrentItem = ItemDataGridView.SelectedRows[0].Cells[ItemColumn.Name].Value as Item;
                await GetItemLatestDetailsAsync();
            }
            else
            {
                ItemLastPriceTextBox.Text = string.Empty;
                ItemLastPriceDateTextBox.Text = string.Empty;
                CurrentItem = null;
            }
        }

        private async Task GetItemLatestDetailsAsync()
        {
            LatestStock = await StockManager.GetLatestByItemAsync(CurrentItem);

            if (LatestStock != null)
            {
                ItemLastPriceTextBox.Text = LatestStock.UnitPrice.ToString("#,##0.00");
                ItemLastPriceDateTextBox.Text = LatestStock.DeliveryDate.ToString("MMMM dd, yyyy");
            }
            else
            {
                ItemLastPriceTextBox.Text = string.Empty;
                ItemLastPriceDateTextBox.Text = string.Empty;
            }
        }

        private async Task GetLatestIssuanceSlipNumberAsync()
        {
            var issuanceSlipNumber = await TransactionManager.GenerateLatestIssuanceSlipNumberAsync();

            if (string.IsNullOrWhiteSpace(issuanceSlipNumber))
            {
                MessageBox.Show("Failed to generate Latest Issuance Slip No.");
                Close();
            }
            else
            {
                IssuanceSlipNumberTextBox.Text = issuanceSlipNumber;
            }
        }

        private async Task SaveAndPrintAsync()
        {
            if (OutgoingStockDataGridView.Rows.Count > 0)
            {
                await GetLatestIssuanceSlipNumberAsync();

                try
                {
                    var transactions = new List<Transaction>();

                    foreach (DataGridViewRow row in OutgoingStockDataGridView.Rows)
                    {
                        var transaction = row.Cells[OutgoingStockColumn.Name].Value as Transaction;
                        transaction.IssuanceSlipNumber = IssuanceSlipNumberTextBox.Text;
                        transactions.Add(transaction);
                    }

                    var savedTransactions = await _TransactionManager.InsertAsync(transactions);
                    OutgoingStockDataGridView.Rows.Clear();
                    await TransactionManager.ExportIssuanceSlipAsync(savedTransactions);
                    MessageBox.Show("Successfully saved and exported.");
                    await GetLatestIssuanceSlipNumberAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Add atleast 1 outgoing stock.");
            }
        }
    }
}
