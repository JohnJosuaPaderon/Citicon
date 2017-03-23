using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Inventory
{
    public partial class IncomingStocksform : Form
    {
        ItemManager itemManager;
        StockManager stockManager;
        PaymentTermManager paymentTermManager;
        BranchManager branchManager;
        CompanyManager companyManager;
        SupplierManager supplierManager;
        Item[] items;
        Stock[] stocks;
        PaymentTerm[] paymentTerms;
        Branch[] branches;
        Company[] companies;
        Supplier[] suppliers;
        List<Item> tempItems;
        Item currentItem;
        DateTime _dueDate;
        AutoCompleteStringCollection autoCompleteStringCollection;
        Stock editingStock;
        bool editing;
        bool Editing
        {
            get { return editing; }
            set
            {
                //dtpDeliveryDate.Enabled = !value;
                //tbxAcceptedBy.Enabled = !value;
                //tbxRemarks.Enabled = !value;
                //cmbxBranches.Enabled = !value;
                //cmbxCompanies.Enabled = !value;
                //cmbxPaymentTerms.Enabled = !value;
                //cmbxSuppliers.Enabled = !value;
                //nudAddedStockValue.Enabled = !value;
                //nudDrNumber.Enabled = !value;
                //nudSiNumber.Enabled = !value;
                editing = value;
            }
        }
        enum SearchCategory
        {
            Description,
            Code,
            Classification,
            SubClassification
        }
        private string MrisNumber;
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
            stockManager.Updated += StockManager_Updated;
            stockManager.UpdatedUnsuccessful += StockManager_UpdatedUnsuccessful;

            paymentTermManager = new PaymentTermManager();
            paymentTermManager.ExceptionCatched += ExceptionCatched;
            paymentTermManager.NewItemGenerated += PaymentTermManager_NewItemGenerated;

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

        private void StockManager_UpdatedUnsuccessful(Stock e)
        {
            MessageBox.Show("Error on updating!");
        }

        private void StockManager_Updated(Stock e)
        {
            MessageBox.Show("Successfully modified!");
            ClearStockFields();
            DisplayStock(null);
            foreach (DataGridViewRow row in dgvStocks.Rows)
            {
                if (((Stock)row.Cells[colStock.Name].Value).Id == e.Id)
                {
                    row.Cells[colStock.Name].Value = e;
                    break;
                }
            }
        }

        private void StockManager_AddedUnsuccessful(Stock e)
        {
            MessageBox.Show("Adding unsuccessful!");
        }
        private void StockManager_Added(Stock e)
        {
            currentItem = itemManager.GetById(currentItem.Id);
            //await displayItem();

            dgvStocks.Rows.Insert(0, e, e.AddedStockValue.ToString("#,##0.00"), e.Supplier, e.SiNumber, e.DrNumber, e.DeliveryDate.ToString("MMM dd, yyyy"));

            ClearStockFields();
            MessageBox.Show("Successfully added!");

            if (ckbxRetainData.Checked)
            {
                nudDrNumber.Focus();
            }
        }
        private void ClearStockFields()
        {
            Editing = false;
            if (!ckbxRetainData.Checked)
            {
                cmbxBranches.SelectedItem = null;
                cmbxCompanies.SelectedItem = null;
                cmbxPaymentTerms.SelectedItem = null;
                cmbxSuppliers.SelectedItem = null;
                cmbxVehicles.SelectedItem = null;
                tbxAcceptedBy.Text = string.Empty;
                nudAddedStockValue.Value = 0;
                nudUnitPrice.Value = 0;
                tbxRemarks.Text = string.Empty;
                nudDrNumber.Value = 0;
                nudSiNumber.Value = 0;
                nudLength.Value = 0;
                nudWidth.Value = 0;
                nudHeight.Value = 0;
            }
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
            Invoke(new Action(() => dgvStocks.Rows.Add(e, e.AddedStockValue.ToString("#,##0.00"), e.Supplier, e.SiNumber, e.DrNumber, e.DeliveryDate.ToString("MMM dd, yyyy"))));
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
            cmbxSearchBy.Items.Clear();
            cmbxSearchBy.Items.AddRange(Enum.GetNames(typeof(SearchCategory)));
            tmrGenerateItems.Start();
            dgvItems.BringToFront();
            paymentTerms = await paymentTermManager.GetListAsync();
            //vehicles = await vehicleManager.GetListAsync();
            branches = await branchManager.GetListAsync();
            companies = await companyManager.GetListAsync();
            suppliers = await supplierManager.GetListAsync();

            if (suppliers != null)
            {
                cmbxSuppliers.Items.AddRange(suppliers);
            }

            await LoadItems();

        }
        private async void TmrGenerateItems_Tick(object sender, EventArgs e)
        {
            await LoadItems();
        }
        private async Task LoadItems()
        {
            items = null;
            tempItems.Clear();
            items = await itemManager.GetListAsync();
        }
        private void TbxSearchItems_TextChanged(object sender, EventArgs e)
        {
            AppendItems(items ?? tempItems?.ToArray(), false);
        }
        private void AppendItems(Item[] list, bool asIsSearching)
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
                                if (item.Description == key) AppendSingleItem(item); break;
                            case SearchCategory.Code:
                                if (item.Code == key) AppendSingleItem(item); break;
                            case SearchCategory.Classification:
                                if (item.Classification?.Description == key) AppendSingleItem(item); break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (searchCategory)
                        {
                            case SearchCategory.Description:
                                if (item.Description.StartsWith(key, StringComparison.CurrentCultureIgnoreCase)) AppendSingleItem(item); break;
                            case SearchCategory.Code:
                                if (item.Code.StartsWith(key, StringComparison.CurrentCultureIgnoreCase)) AppendSingleItem(item); break;
                            case SearchCategory.Classification:
                                if (item.Classification != null)
                                    if (item.Classification.Description.StartsWith(key, StringComparison.CurrentCultureIgnoreCase)) AppendSingleItem(item);
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
        private void AppendSingleItem(Item item)
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
                if (((Item)row.Cells[colItem.Name].Value) == item) return;
            dgvItems.Rows.Add(item, item.Code, item.Classification, item.StockValue.ToString("#,##0"));
            if (HasRows) dgvItems.Rows[0].Selected = true;
        }
        private void CmbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppendItems(items ?? tempItems?.ToArray(), false);
        }
        private bool HasRows
        {
            get { return dgvItems.Rows.Count > 0; }
        }
        private bool HasSelectedRows
        {
            get { return dgvItems.SelectedRows.Count > 0; }
        }
        private async void TbxSearchItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetItemFromDatagridView();
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
        private async void DgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await GetItemFromDatagridView();
            }
            else if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                tbxSearchItems.Focus();
                var x = (char)e.KeyData;
                tbxSearchItems.Text += !char.IsControl(x) ? x : '\0';
                tbxSearchItems.Select(tbxSearchItems.Text.Length, 0);
            }
        }
        private async void DgvItems_DoubleClick(object sender, EventArgs e)
        {
            await GetItemFromDatagridView();
        }
        private async Task GetItemFromDatagridView()
        {
            if (HasSelectedRows)
            {
                currentItem = (Item)dgvItems.SelectedRows[0].Cells[colItem.Name].Value;
                dgvItems.Rows.Clear();
                dgvItems.Height = 0;
                await DisplayItem();
            }
            else MessageBox.Show("No item is selected!");
        }
        private void EnableMeasurementDescriptionFields(Control control, bool enabled)
        {
            if (control is IContainerControl)
            {
                foreach (Control c in control.Controls)
                {
                    if (c.Tag == (object)"MeasurementDescription") c.Enabled = enabled;

                    if (c is NumericUpDown)
                    {
                        var nud = c as NumericUpDown;
                        nud.Value = 0;
                    }
                }
            }
        }
        private async Task DisplayItem()
        {
            EnableMeasurementDescriptionFields(this, false);
            tbxItemCode.Text = string.Empty;
            tbxItemDescription.Text = string.Empty;
            tbxItemStockValue.Text = 0.ToString("#,##0.00");
            dgvStocks.Rows.Clear();
            if (currentItem != null)
            {
                tbxItemCode.Text = currentItem.Code;
                tbxItemDescription.Text = currentItem.Description;
                tbxItemStockValue.Text = currentItem.StockValue.ToString("#,##0.00");
                if (currentItem.MeasurementUnit == MeasurementUnit.CubicMeter) EnableMeasurementDescriptionFields(this, true);
                stocks = await stockManager.GetListByItemAsync(currentItem);
                
            }
        }
        private void BtnSearchItems_Click(object sender, EventArgs e)
        {
            AppendItems(items ?? tempItems?.ToArray(), true);
        }
        private void TbxSearchItems_Enter(object sender, EventArgs e)
        {
            tbxSearchItems.Select(0, tbxSearchItems.Text.Length);
        }
        private void CmbxPaymentTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Editing)
            {
                ChangeComboBoxStyleToDropDownList(cmbxPaymentTerms);
                CalculateDueDate();
            }
        }
        private void SaveAcceptedBySuggest()
        {
            if (!tbxAcceptedBy.AutoCompleteCustomSource.Contains(tbxAcceptedBy.Text.Trim()))
            {
                var x = tbxAcceptedBy.Text.Trim();
                tbxAcceptedBy.AutoCompleteCustomSource.Add(x);
                Supports.AppendAcceptedBySuggest(x);
            }
        }
        private void TbxAcceptedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SaveAcceptedBySuggest();
        }
        private void DisplayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            var deliveryDate = dtpDeliveryDate.Value;
            var paymentTerm = (PaymentTerm)cmbxPaymentTerms.SelectedItem;
            //calculateDueDate();
            var dueDate = _dueDate;
            var vehicle = (Vehicle)cmbxVehicles.SelectedItem;
            var siNumber = Convert.ToUInt32(nudSiNumber.Value);
            var drNumber = Convert.ToUInt32(nudDrNumber.Value);
            var branch = (Branch)cmbxBranches.SelectedItem;
            var company = (Company)cmbxCompanies.SelectedItem;
            var addedStockValue = nudAddedStockValue.Value;
            var unitPrice = nudUnitPrice.Value;
            var supplier = (Supplier)cmbxSuppliers.SelectedItem;
            var remarks = tbxRemarks.Text.Trim();
            var acceptedBy = tbxAcceptedBy.Text.Trim();
            bool includeWithHoldingTax = ckbxIncludeWithHoldingTax.Checked;
            decimal? withHoldingTax = includeWithHoldingTax ? new decimal?(nudWithHoldingTax.Value) : null;
            var measurementDescription =
                (nudHeight.Value != 0.00M && nudLength.Value != 0.00M && nudWidth.Value != 0.00M)
                ? $"L = {nudLength.Value.ToString("#,###.##")}, W = {nudWidth.Value.ToString("#,###.##")}, H = {nudHeight.Value.ToString("#,###.##")} "
                : string.Empty;
            if (deliveryDate == default(DateTime))
            {
                DisplayError("Delivery Date must be valid!"); return;
            }
            if (paymentTerm == null)
            {
                DisplayError("Please select a valid Payment Term"); return;
            }
            if (dueDate < deliveryDate)
            {
                DisplayError("Due Date is invalid!"); return;
            }
            //if (vehicle == null)
            //{
            //    displayError("Vehicle must be valid!"); return;
            //}
            if (siNumber <= 0 && drNumber <= 0)
            {
                DisplayError("SI No. or DR No. should be valid!"); return;
            }
            //if (branch == null)
            //{
            //    displayError("Branch should be valid!"); return;
            //}
            //if (company == null)
            //{
            //    displayError("Company should be valid!"); return;
            //}
            if (addedStockValue == 0)
            {
                DisplayError("Added stock value shouldn't be having a value of 0 (zero)!"); return;
            }
            if (unitPrice < 0)
            {
                DisplayError("Unit Price shouldn't be having less than a value of 0 (zero)!"); return;
            }
            if (supplier == null)
            {
                DisplayError("Supplier should be valid!"); return;
            }
            if (acceptedBy == string.Empty)
            {
                DisplayError("Accepting personel must be valid!"); return;
            }
            if (currentItem == null)
            {
                DisplayError("Please select a valid Inventory item first!"); return;
            }
            if (Editing)
            {
                editingStock.AddedStockValue = addedStockValue;
                editingStock.PaymentTerm = paymentTerm;
                editingStock.UnitPrice = unitPrice;
                editingStock.AcceptedBy = acceptedBy;
                editingStock.Branch = branch;
                editingStock.Company = company;
                editingStock.DeliveryDate = deliveryDate;
                editingStock.DueDate = dueDate;
                editingStock.MrisNumber = null;
                editingStock.SiNumber = siNumber;
                editingStock.DrNumber = drNumber;
                editingStock.Supplier = supplier;
                editingStock.Vehicle = vehicle;
                editingStock.MeasurementDescription = measurementDescription;
                editingStock.IncludeWithHoldingTax = includeWithHoldingTax;
                editingStock.WithHoldingTax = withHoldingTax;
                editingStock.MrisNumber = MrisNumber;
                stockManager.Update(editingStock);
            }
            else
            {
                var cementSuppliedCode = ConfigurationManager.AppSettings["Item.Code.CementSupplied"];
                if (cementSuppliedCode == null)
                {
                    MessageBox.Show("Cement Supplied Code cannot be found in the Configuration");
                }
                else
                {
                    Client cementSuppliedClient = null;
                    Project[] cementSuppliedProjects = null;
                    if (cementSuppliedCode == currentItem.Code)
                    {
                        var form = new CementSuppliedProjectForm();
                        form.ShowDialog();
                        cementSuppliedClient = form.CementSuppliedClient;
                        cementSuppliedProjects = form.CementSuppliedProjects;
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
                        SiNumber = siNumber,
                        DrNumber = drNumber,
                        Supplier = supplier,
                        UnitPrice = unitPrice,
                        Vehicle = vehicle,
                        Paid = currentItem.CementSupplied,
                        MeasurementDescription = measurementDescription,
                        CementSuppliedClient = cementSuppliedClient,
                        CementSuppliedProjects = cementSuppliedProjects,
                        IncludeWithHoldingTax = includeWithHoldingTax,
                        WithHoldingTax = withHoldingTax
                    });     
                }
            }
        }
        private void DtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateDueDate();
        }
        private void CalculateDueDate()
        {
            if (cmbxPaymentTerms.SelectedItem != null)
            {
                var paymentTerm = (PaymentTerm)cmbxPaymentTerms.SelectedItem;
                _dueDate = dtpDeliveryDate.Value.AddDays(paymentTerm.DayCount);
                MessageBox.Show($"This must be paid on\\before {_dueDate.ToString("MMMM dd, yyyy")}");
            }
        }
        private void TbxAcceptedBy_Leave(object sender, EventArgs e)
        {   
            SaveAcceptedBySuggest();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearStockFields();
        }
        private void DgvItems_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CmbxPaymentTerms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        private void SearchableComboBox(object sender, MouseEventArgs e)
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
        private void Cmbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeComboBoxStyleToDropDownList((ComboBox)sender);
            }
        }
        private void ChangeComboBoxStyleToDropDownList(ComboBox cmbx)
        {
            if (cmbx.DropDownStyle != ComboBoxStyle.DropDownList) cmbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CmbxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void BtnEditSelectedUnitPrice_Click(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count == 1)
            {
                Editing = true;
                DisplayStock((Stock)dgvStocks.SelectedRows[0].Cells[colStock.Name].Value);
            }
        }
        private void DisplayStock(Stock stock)
        {
            tbxAcceptedBy.Text = string.Empty;
            tbxRemarks.Text = string.Empty;
            cmbxBranches.SelectedItem = null;
            cmbxCompanies.SelectedItem = null;
            cmbxPaymentTerms.SelectedItem = null;
            cmbxSuppliers.SelectedItem = null;
            nudAddedStockValue.Value = 0;
            nudDrNumber.Value = 0;
            nudHeight.Value = 0;
            nudLength.Value = 0;
            nudSiNumber.Value = 0;
            nudUnitPrice.Value = 0;
            nudWidth.Value = 0;
            dtpDeliveryDate.Value = DateTime.Now;
            MrisNumber = stock?.MrisNumber;
            if (stock != null)
            {
                editingStock = stock;
                _dueDate = editingStock.DueDate;
                dtpDeliveryDate.Value = stock.DeliveryDate;
                tbxAcceptedBy.Text = stock.AcceptedBy;
                tbxRemarks.Text = stock.Remarks;
                cmbxBranches.SelectedItem = stock.Branch;
                cmbxCompanies.SelectedItem = stock.Company;
                cmbxPaymentTerms.SelectedItem = stock.PaymentTerm;
                cmbxSuppliers.SelectedItem = stock.Supplier;
                nudAddedStockValue.Value = stock.AddedStockValue;
                nudDrNumber.Value = stock.DrNumber;
                if (stock.Item.MeasurementUnit == MeasurementUnit.CubicMeter)
                {
                    if (stock.MeasurementDescription.Contains("=") && stock.MeasurementDescription.Contains(";"))
                    {
                        var lwh = stock.MeasurementDescription?.Replace(' ', '\0')?.Split(';');
                        Dictionary<string, decimal> pair = new Dictionary<string, decimal>();
                        foreach (var item in lwh)
                        {
                            string key;
                            var x = item.Split('=');
                            key = x[0].Trim().Replace("\0","").ToLower();
                            decimal.TryParse(x[1].Trim().Replace("\0", ""), out decimal value);
                            pair.Add(key, value);
                        }
                        nudLength.Value = pair["l"];
                        nudWidth.Value = pair["w"];
                        nudHeight.Value = pair["h"];

                    }
                }

                nudSiNumber.Value = stock.SiNumber;
                nudUnitPrice.Value = stock.UnitPrice;
            }
        }

        private void CkbxIncludeWithHoldingTax_CheckedChanged(object sender, EventArgs e)
        {
            nudWithHoldingTax.Enabled = ckbxIncludeWithHoldingTax.Checked;
            nudWithHoldingTax.Value = 0;
        }

        private void NudWithHoldingTax_EnabledChanged(object sender, EventArgs e)
        {
            if (!nudWithHoldingTax.Enabled)
            {
                nudWithHoldingTax.Value = 0;
            }
        }

        private void LblHeight_Click(object sender, EventArgs e)
        {

        }

        private void LblWidth_Click(object sender, EventArgs e)
        {

        }

        private void NudHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NudWidth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NudLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TbxRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxAcceptedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSupplier_Click(object sender, EventArgs e)
        {

        }

        private void NudUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            if (nudWithHoldingTax.Value != 0)
            {
                var amount = nudAddedStockValue.Value * nudUnitPrice.Value;
                nudAmountDue.Value = amount / nudWithHoldingTax.Value;
            }
            else
            {
                nudAmountDue.Value = 0;
            }
        }

        private void NudAmountDue_ValueChanged(object sender, EventArgs e)
        {
            nudVat.Value = nudAmountDue.Value * 0.12M;
        }

        private void NudVat_ValueChanged(object sender, EventArgs e)
        {
            var sum = nudVat.Value + nudAmountDue.Value;

            if (nudTotalAmountDue.Maximum < sum)
            {
                nudTotalAmountDue.Maximum = sum;
            }

            nudTotalAmountDue.Value = sum;
        }

        private void CkbxRetainData_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
