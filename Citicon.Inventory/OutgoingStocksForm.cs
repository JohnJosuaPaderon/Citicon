using Citicon.Data;
using Citicon.DataManager;
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

namespace Citicon.Inventory
{
    public partial class OutgoingStocksForm : Form
    {
        ItemManager itemManager;
        TransactionManager transactionManager;
        BranchManager branchManager;
        CompanyManager companyManager;
        VehicleManager vehicleManager;

        Item[] items;
        Transaction[] transactions;
        Branch[] branches;
        Company[] companies;
        Item currentItem;
        Vehicle[] vehicles;

        List<Item> tempItems;
        enum SearchCategory
        {
            Description,
            Code,
            Classification,
            SubClassification
        }

        public OutgoingStocksForm()
        {
            InitializeComponent();
            itemManager = new ItemManager();
            itemManager.ExceptionCatched += ExceptionCatched;
            itemManager.NewItemGenerated += ItemManager_NewItemGenerated;

            transactionManager = new TransactionManager();
            transactionManager.ExceptionCatched += ExceptionCatched;
            transactionManager.NewItemTransactionGenerated += TransactionManager_NewItemTransactionGenerated;
            transactionManager.Added += TransactionManager_Added;
            transactionManager.AddedUnsuccessful += TransactionManager_AddedUnsuccessful;

            branchManager = new BranchManager();
            branchManager.ExceptionCatched += ExceptionCatched;
            branchManager.NewItemGenerated += BranchManager_NewItemGenerated;

            companyManager = new CompanyManager();
            companyManager.ExceptionCatched += ExceptionCatched;
            companyManager.NewItemGenerated += CompanyManager_NewItemGenerated;

            vehicleManager = new VehicleManager();
            vehicleManager.ExceptionCatched += ExceptionCatched;
            vehicleManager.NewItemGenerated += VehicleManager_NewItemGenerated;

            tempItems = new List<Item>();
            tbxReleasedBy.AutoCompleteCustomSource.AddRange(Supports.ReleasedBySuggests);
            tbxRequestedBy.AutoCompleteCustomSource.AddRange(Supports.RequestedBySuggests);
        }

        private void VehicleManager_NewItemGenerated(Vehicle e)
        {
            Invoke(new Action(() => cmbxTruck.Items.Add(e)));
        }

        private void TransactionManager_AddedUnsuccessful(Transaction e)
        {
            MessageBox.Show("Adding unsuccessful!");
        }

        private async void TransactionManager_Added(Transaction e)
        {
            dgvStocks.Rows.Add(e, e.LastStockValue, e.RemovedStockValue, e.TransactionDate.ToString("MMM dd, yyyy"));
            currentItem = itemManager.GetById(currentItem.Id);
            await displayItem();
            clearTransactionFields();
            MessageBox.Show("Transaction has been saved!");
            try
            {
                transactionManager.ExportIssuanceSlip(e);
            }
            catch (Exception ex)
            {
                displayError(ex.Message);
            }
        }

        private void CompanyManager_NewItemGenerated(Company e)
        {
            Invoke(new Action(() => cmbxCompany.Items.Add(e)));
        }

        private void BranchManager_NewItemGenerated(Branch e)
        {
            Invoke(new Action(() => cmbxBranch.Items.Add(e)));
        }

        private void TransactionManager_NewItemTransactionGenerated(Transaction e)
        {
            Invoke(new Action(() => dgvStocks.Rows.Add(e, e.LastStockValue, e.RemovedStockValue, e.TransactionDate.ToString("MMM dd, yyyy"))));
        }

        private async Task loadItems()
        {
            items = null;
            tempItems.Clear();
            items = await itemManager.GetListAsync();
        }

        private void ItemManager_NewItemGenerated(Item e)
        {
            if (items == null)
            {
                tempItems.Add(e);
            }
        }

        private void ExceptionCatched(Exception ex)
        {
            if (Supports.DebugMode) MessageBox.Show(ex.Message);
        }

        private async void OutgoingStocksForm_Load(object sender, EventArgs e)
        {
            dgvItems.BringToFront();
            cmbxSearchBy.Items.Clear();
            cmbxSearchBy.Items.AddRange(Enum.GetNames(typeof(SearchCategory)));
            branches = await branchManager.GetListAsync();
            companies = await companyManager.GetListAsync();
            vehicles = await vehicleManager.GetListAsync();
            tmrGenerateItems.Start();
            await loadItems();
        }

        private async void tmrGenerateItems_Tick(object sender, EventArgs e)
        {
            //await loadItems();
        }

        private void tbxSearchItems_TextChanged(object sender, EventArgs e)
        {
            appendItems(items != null ? items : tempItems?.ToArray(), false);
        }

        private void appendItems(Item[] list, bool asIsSearching)
        {
            if (tbxSearchItems.Text.Length < 8)
            {
                return;
            }
            dgvItems.Rows.Clear();
            if (tbxSearchItems.Text.Trim() != string.Empty)
            {
                if (cmbxSearchBy.SelectedItem == null) cmbxSearchBy.SelectedIndex = 0;
                var searchCategory = (SearchCategory)Enum.Parse(typeof(SearchCategory), cmbxSearchBy.SelectedItem.ToString());
                var key = tbxSearchItems.Text.Trim();
                foreach (Item item in list)
                {
                    if (asIsSearching)
                    {
                        switch (searchCategory)
                        {
                            case SearchCategory.Description:
                                if (item.Description == key) appendSingleItem(item); break;
                            case SearchCategory.Code:
                                if (item.Code == key) appendSingleItem(item); break;
                            case SearchCategory.Classification:
                                if (item.Classification?.Description == key) appendSingleItem(item); break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (searchCategory)
                        {
                            case SearchCategory.Description:
                                if (item.Description.StartsWith(key, StringComparison.CurrentCultureIgnoreCase)) appendSingleItem(item); break;
                            case SearchCategory.Code:
                                if (item.Code.StartsWith(key, StringComparison.CurrentCultureIgnoreCase)) appendSingleItem(item); break;
                            case SearchCategory.Classification:
                                if (item.Classification != null)
                                    if (item.Classification.Description.StartsWith(key, StringComparison.CurrentCultureIgnoreCase)) appendSingleItem(item);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            dgvItems.Height = 50 + (30 * (dgvItems.Rows.Count <= 15 ? dgvItems.Rows.Count : 15));
            if (dgvItems.Rows.Count == 0) dgvItems.Height = 0;
        }

        private void appendSingleItem(Item item)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
                if (((Item)row.Cells[colItem.Name].Value) == item) return;
            dgvItems.Rows.Add(item, item.Code, item.Classification, item.StockValue.ToString("#,##0"));
            if (HasRows) dgvItems.Rows[0].Selected = true;
        }

        private void cmbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            appendItems(items != null ? items : tempItems?.ToArray(), false);
        }

        private bool HasRows
        {
            get { return dgvItems.Rows.Count > 0; }
        }

        private bool HasSelectedRows
        {
            get { return dgvItems.SelectedRows.Count > 0; }
        }

        private async void tbxSearchItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await getItemFromDatagridView();
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (HasRows)
                {
                    dgvItems.Focus();
                    if (!dgvItems.Rows[0].Selected) dgvItems.Rows[0].Selected = true;
                    else if (dgvItems.Rows.Count > 1) dgvItems.Rows[1].Selected = true;
                }
            }
        }

        private async void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await getItemFromDatagridView();
            }
            else if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                tbxSearchItems.Focus();
                var x = (char)e.KeyData;
                tbxSearchItems.Text += !char.IsControl(x) ? x : '\0';
                tbxSearchItems.Select(tbxSearchItems.Text.Length, 0);
            }
        }

        private void clearTransactionFields()
        {
            tbxPurpose.Text = string.Empty;
            tbxReleasedBy.Text = string.Empty;
            tbxRequestedBy.Text = string.Empty;
            cmbxBranch.SelectedItem = null;
            cmbxCompany.SelectedItem = null;
            cmbxTruck.SelectedItem = null;
            nudRemovedStockValue.Value = 0;
            dtpTransactionDate.Value = DateTime.Now;
        }

        private async void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            await getItemFromDatagridView();
        }

        private async Task getItemFromDatagridView()
        {
            if (HasSelectedRows)
            {
                currentItem = (Item)dgvItems.SelectedRows[0].Cells[colItem.Name].Value;
                dgvItems.Rows.Clear();
                dgvItems.Height = 0;
                await displayItem();
            }
            else MessageBox.Show("No item is selected!");
        }

        private async Task displayItem()
        {
            tbxItemCode.Text = string.Empty;
            tbxItemDescription.Text = string.Empty;
            tbxItemStockValue.Text = 0.ToString("#,##0.00");
            dgvStocks.Rows.Clear();
            if (currentItem != null)
            {
                tbxItemCode.Text = currentItem.Code;
                tbxItemDescription.Text = currentItem.Description;
                tbxItemStockValue.Text = currentItem.StockValue.ToString("#,##0.00");
                transactions = await transactionManager.GetListByItemAsync(currentItem);
            }
        }

        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            appendItems(items != null ? items : tempItems?.ToArray(), true);
        }

        private void tbxSearchItems_Enter(object sender, EventArgs e)
        {
            tbxSearchItems.Select(0, tbxSearchItems.Text.Length);
        }
        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var transactionDate = dtpTransactionDate.Value;
            var removedStockValue = nudRemovedStockValue.Value;
            var branch = (Branch)cmbxBranch.SelectedItem;
            var company = (Company)cmbxCompany.SelectedItem;
            var requestedBy = tbxRequestedBy.Text.Trim();
            var releasedBy = tbxReleasedBy.Text.Trim();
            var truck = (Vehicle)cmbxTruck.SelectedItem;
            var purpose = tbxPurpose.Text.Trim();
            var seriesNumber = (uint)nudSeriesNumber.Value;

            if (seriesNumber == 0)
            {
                displayError("Series No. should not be set to zero."); return;
            }

            if (transactionDate == default(DateTime))
            {
                displayError("Transaction Date should be valid!"); return;
            }
            if (removedStockValue == 0)
            {
                displayError("Removed stock valud should not be 0 (zero)!"); return;
            }
            if (branch == null)
            {
                displayError("Branch should be valid!"); return;
            }
            if (company == null)
            {
                displayError("Company should be valid!"); return;
            }
            if (requestedBy == string.Empty)
            {
                displayError("Requesting personnel should be indicated!"); return;
            }
            if (releasedBy == string.Empty)
            {
                displayError("Releasing personnel should be indicated!"); return;
            }
            //if (purpose == string.Empty)
            //{
            //    displayError("Purpose should be filled up!"); return;
            //}
            if (truck == null)
            {
                displayError("Truck should be valid!"); return;
            }
            if (currentItem == null)
            {
                displayError("Please select an item first!"); return;
            }
            if (currentItem.StockValue < removedStockValue)
            {
                displayError($"Stock value to be removed is greater than the current stock value of {currentItem}!"); return;
            }
            transactionManager.Add(new Transaction
            {
                Branch = branch,
                Company = company,
                Item = currentItem,
                LastStockValue = currentItem.StockValue,
                Purpose = purpose,
                ReleasedBy = releasedBy,
                RemovedStockValue = removedStockValue,
                RequestedBy = requestedBy,
                TransactionDate = transactionDate,
                Truck = truck,
                SeriesNumber = seriesNumber
            });
        }

        private void saveReleasedBySuggest()
        {
            var x = tbxReleasedBy.Text.Trim();
            if (!tbxReleasedBy.AutoCompleteCustomSource.Contains(x))
            {
                Supports.AppendReleasedBySuggest(x);
                tbxReleasedBy.AutoCompleteCustomSource.Add(x);
            }
        }

        private void saveRequestedBySuggest()
        {
            var x = tbxRequestedBy.Text.Trim();
            if (!tbxRequestedBy.AutoCompleteCustomSource.Contains(x))
            {
                Supports.AppendRequestedBySuggest(x);
                tbxRequestedBy.AutoCompleteCustomSource.Add(x);
            }
        }

        private void tbxRequestedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) saveRequestedBySuggest();
        }

        private void tbxReleasedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) saveReleasedBySuggest();
        }

        private void tbxRequestedBy_Leave(object sender, EventArgs e)
        {
            saveRequestedBySuggest();
        }

        private void tbxReleasedBy_Leave(object sender, EventArgs e)
        {
            saveReleasedBySuggest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTransactionFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchableComboBox(object sender, MouseEventArgs e)
        {
            if (e?.Button == MouseButtons.Right && sender is ComboBox)
            {
                var cmbx = (ComboBox)sender;
                cmbx.DropDownStyle = ComboBoxStyle.DropDown;
                cmbx.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cmbx.AutoCompleteCustomSource.Clear();
                var list = new List<string>();
                foreach (var item in cmbx.Items)
                    list.Add(item.ToString());
                cmbx.AutoCompleteCustomSource.AddRange(list.ToArray());
            }
        }

        private void cmbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeComboBoxStyleToDropDownList((ComboBox)sender);
            }
        }

        private void changeComboBoxStyleToDropDownList(ComboBox cmbx)
        {
            if (cmbx.DropDownStyle != ComboBoxStyle.DropDownList) cmbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
