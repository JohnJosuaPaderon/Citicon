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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Inventory
{
    public partial class IncomingStocksform : Form
    {
        ItemManager itemManager;
        StockManager stockManager;
        PaymentTermManager paymentTermManager;
        VehicleManager vehicleManager;
        BranchManager branchManager;
        CompanyManager companyManager;
        SupplierManager supplierManager;

        Item[] items;
        Stock[] stocks;
        PaymentTerm[] paymentTerms;
        Vehicle[] vehicles;
        Branch[] branches;
        Company[] companies;
        Supplier[] suppliers;

        List<Item> tempItems;
        Item currentItem;
        
        DateTime _dueDate;

        AutoCompleteStringCollection autoCompleteStringCollection;

        enum SearchCategory
        {
            Description,
            Code,
            Classification,
            SubClassification
        }
        public IncomingStocksform()
        {
            InitializeComponent();
            itemManager = new ItemManager();
            itemManager.ExceptionCatched += ExceptionCatched;
            itemManager.NewItemGenerated += ItemManager_NewItemGenerated;

            stockManager = new StockManager();
            stockManager.ExceptionCatched += ExceptionCatched;
            stockManager.NewItemStockGenerated += StockManager_NewItemStockGenerated;
            stockManager.Added += StockManager_Added;
            stockManager.AddedUnsuccessful += StockManager_AddedUnsuccessful;

            paymentTermManager = new PaymentTermManager();
            paymentTermManager.ExceptionCatched += ExceptionCatched;
            paymentTermManager.NewItemGenerated += PaymentTermManager_NewItemGenerated;

            vehicleManager = new VehicleManager();
            vehicleManager.ExceptionCatched += ExceptionCatched;
            vehicleManager.NewItemGenerated += VehicleManager_NewItemGenerated;

            branchManager = new BranchManager();
            branchManager.ExceptionCatched += ExceptionCatched;
            branchManager.NewItemGenerated += BranchManager_NewItemGenerated;

            companyManager = new CompanyManager();
            companyManager.ExceptionCatched += ExceptionCatched;
            companyManager.NewItemGenerated += CompanyManager_NewItemGenerated;

            supplierManager = new SupplierManager();
            supplierManager.ExceptionCatched += ExceptionCatched;
            supplierManager.NewItemGenerated += SupplierManager_NewItemGenerated;
            tempItems = new List<Item>();
            autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(Supports.AcceptedBySuggests);
            tbxAcceptedBy.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void StockManager_AddedUnsuccessful(Stock e)
        {
            MessageBox.Show("Adding unsuccessful!");
        }

        private async void StockManager_Added(Stock e)
        {
            dgvStocks.Rows.Add(e, e.LastStockValue, e.AddedStockValue, e.DeliveryDate.ToString("MMM dd, yyyy"));
            currentItem = itemManager.GetById(currentItem.Id);
            await displayItem();
            clearStockFields();
            MessageBox.Show("Successfully added!");
        }

        private void clearStockFields()
        {
            cmbxBranches.SelectedItem = null;
            cmbxCompanies.SelectedItem = null;
            cmbxPaymentTerms.SelectedItem = null;
            cmbxSuppliers.SelectedItem = null;
            cmbxVehicles.SelectedItem = null;
            tbxAcceptedBy.Text = string.Empty;
            tbxSidrNumber.Text = string.Empty;
            nudAddedStockValue.Value = 0;
            nudUnitPrice.Value = 0;
            tbxRemarks.Text = string.Empty;
        }

        private void SupplierManager_NewItemGenerated(Supplier e)
        {
            Invoke(new Action(() => cmbxSuppliers.Items.Add(e)));
        }

        private void CompanyManager_NewItemGenerated(Company e)
        {
            Invoke(new Action(() => cmbxCompanies.Items.Add(e)));
        }

        private void BranchManager_NewItemGenerated(Branch e)
        {
            Invoke(new Action(() => cmbxBranches.Items.Add(e)));
        }

        private void VehicleManager_NewItemGenerated(Vehicle e)
        {
            Invoke(new Action(() => cmbxVehicles.Items.Add(e)));
        }

        private void PaymentTermManager_NewItemGenerated(PaymentTerm e)
        {
            Invoke(new Action(() => cmbxPaymentTerms.Items.Add(e)));
        }

        private void StockManager_NewItemStockGenerated(Stock e)
        {
            Invoke(new Action(() => dgvStocks.Rows.Add(e, e.LastStockValue, e.AddedStockValue, e.DeliveryDate.ToString("MMM dd, yyyy"))));
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
            //throw new NotImplementedException();
        }

        private async void IncomingStocksform_Load(object sender, EventArgs e)
        {
            tmrGenerateItems.Start();
            await loadItems();
            paymentTerms = await paymentTermManager.GetListAsync();
            vehicles = await vehicleManager.GetListAsync();
            branches = await branchManager.GetListAsync();
            companies = await companyManager.GetListAsync();
            suppliers = await supplierManager.GetListAsync();
            cmbxSearchBy.Items.Clear();
            cmbxSearchBy.Items.AddRange(Enum.GetNames(typeof(SearchCategory)));

        }

        private async void tmrGenerateItems_Tick(object sender, EventArgs e)
        {
            await loadItems();
        }

        private async Task loadItems()
        {
            items = null;
            tempItems.Clear();
            items = await itemManager.GetListAsync();
        }

        private void tbxSearchItems_TextChanged(object sender, EventArgs e)
        {
            appendItems(items != null ? items : tempItems?.ToArray(), false);
        }

        private void appendItems(Item[] list, bool asIsSearching)
        {
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
                            case SearchCategory.SubClassification:
                                if (item.SubClassification?.Description == key) appendSingleItem(item); break;
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
                            case SearchCategory.SubClassification:
                                if (item.SubClassification != null)
                                    if (item.SubClassification.Description.StartsWith(key, StringComparison.CurrentCultureIgnoreCase)) appendSingleItem(item); break;
                            default:
                                break;
                        }
                    }
                }
            }
            if (dgvItems.Height <= 350)
            {
                dgvItems.Height = 50 + (30 * dgvItems.Rows.Count);
            }
            if (dgvItems.Rows.Count == 0) dgvItems.Height = 0;
        }

        private void appendSingleItem(Item item)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
                if (((Item)row.Cells[colItem.Name].Value) == item) return;
            dgvItems.Rows.Add(item, item.Code, item.Classification, item.SubClassification, item.StockValue.ToString("#,##0"));
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
            tbxItemStockValue.Text = 0.ToString("#,##0");
            dgvStocks.Rows.Clear();
            if (currentItem != null)
            {
                tbxItemCode.Text = currentItem.Code;
                tbxItemDescription.Text = currentItem.Description;
                tbxItemStockValue.Text = currentItem.StockValue.ToString("#,##0");
                stocks = await stockManager.GetListByItemAsync(currentItem);
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

        private void cmbxPaymentTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateDueDate();
        }

        private void saveAcceptedBySuggest()
        {
            if (!tbxAcceptedBy.AutoCompleteCustomSource.Contains(tbxAcceptedBy.Text.Trim()))
            {
                var x = tbxAcceptedBy.Text.Trim();
                tbxAcceptedBy.AutoCompleteCustomSource.Add(x);
                Supports.AppendAcceptedBySuggest(x);
            }
        }

        private void tbxAcceptedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) saveAcceptedBySuggest();
        }

        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var deliveryDate = dtpDeliveryDate.Value;
            var paymentTerm = (PaymentTerm)cmbxPaymentTerms.SelectedItem;
            var dueDate = _dueDate;
            var vehicle = (Vehicle)cmbxVehicles.SelectedItem;
            var sidrNumber = tbxSidrNumber.Text.Trim();
            var branch = (Branch)cmbxBranches.SelectedItem;
            var company = (Company)cmbxCompanies.SelectedItem;
            var addedStockValue = (uint)nudAddedStockValue.Value;
            var unitPrice = nudUnitPrice.Value;
            var supplier = (Supplier)cmbxSuppliers.SelectedItem;
            var remarks = tbxRemarks.Text.Trim();
            var acceptedBy = tbxAcceptedBy.Text.Trim();
            
            if (deliveryDate == default(DateTime))
            {
                displayError("Delivery Date must be valid!"); return;
            }
            if (paymentTerm == null)
            {
                displayError("Please select a valid Payment Term"); return;
            }
            if (dueDate < deliveryDate)
            {
                displayError("Due Date is invalid!"); return;
            }
            if (vehicle == null)
            {
                displayError("Vehicle must be valid!"); return;
            }
            if (sidrNumber == string.Empty)
            {
                displayError("SIDR No. should be valid!"); return;
            }
            if (branch == null)
            {
                displayError("Branch should be valid!"); return;
            }
            if (company == null)
            {
                displayError("Company should be valid!"); return;
            }
            if (addedStockValue == 0)
            {
                displayError("Added stock value shouldn't be having a value of 0 (zero)!"); return;
            }
            if (unitPrice == 0)
            {
                displayError("Unit Price shouldn't be having a value of 0 (zero)!"); return;
            }
            if (supplier == null)
            {
                displayError("Supplier should be valid!"); return;
            }
            if (acceptedBy == string.Empty)
            {
                displayError("Accepting personel must be valid!"); return;
            }
            if (currentItem == null)
            {
                displayError("Please select a valid Inventory item first!"); return;
            }
            stockManager.Add(new Stock
            {
                AcceptedBy = acceptedBy,
                AddedStockValue = addedStockValue,
                Branch = branch,
                Company = company,
                DeliveryDate = deliveryDate,
                DueDate = dueDate,
                Item = currentItem,
                LastStockValue = currentItem.StockValue,
                MrisNumber = null,
                PaymentTerm = paymentTerm,
                SidrNumber = sidrNumber,
                Supplier = supplier,
                UnitPrice = unitPrice,
                Vehicle = vehicle
            });
        }

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            calculateDueDate();
        }

        private void calculateDueDate()
        {
            if (cmbxPaymentTerms.SelectedItem != null)
            {
                var paymentTerm = (PaymentTerm)cmbxPaymentTerms.SelectedItem;
                _dueDate = dtpDeliveryDate.Value.AddDays(paymentTerm.DayCount);
                MessageBox.Show($"This must be paid on\\before {_dueDate.ToString("MMMM dd, yyyy")}");
            }
        }

        private void tbxAcceptedBy_Leave(object sender, EventArgs e)
        {
            saveAcceptedBySuggest();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearStockFields();
        }
    }
}
