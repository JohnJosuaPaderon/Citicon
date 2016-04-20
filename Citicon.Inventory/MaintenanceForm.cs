using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Citicon.Supports;

namespace Citicon.Inventory
{
    public partial class MaintenanceForm : Form
    {
        BranchManager branchManager;
        ClassificationManager classificationManager;
        CompanyManager companyManager;
        MeasurementUnitManager measurementUnitManager;
        PaymentTermManager paymentTermManager;
        SubClassificationManager subClassificationManager;
        SupplierManager supplierManager;
        VehicleManager vehicleManager;
        VehicleTypeManager vehicleTypeManager;

        Branch activeBranch;
        Classification activeClassification;
        Company activeCompany;
        MeasurementUnit activeMeasurementUnit;
        PaymentTerm activePaymentTerm;
        SubClassification activeSubClassification;
        Supplier activeSupplier;
        Vehicle activeVehicle;
        VehicleType activeVehicleType;

        List<Branch> branches;
        List<Classification> classifications;
        List<Company> companies;
        List<MeasurementUnit> measurementUnits;
        List<PaymentTerm> paymentTerms;
        List<SubClassification> subClassifications;
        List<Supplier> suppliers;
        List<Vehicle> vehicles;
        List<VehicleType> vehicleTypes;

        int idxBranch;
        int idxClassification;
        int idxCompany;
        int idxMeasurementUnit;
        int idxPaymentTerm;
        int idxSubClassification;
        int idxSupplier;
        int idxVehicle;
        int idxVehicleType;

        DataGridViewRow rowBranch;
        DataGridViewRow rowClassification;
        DataGridViewRow rowCompany;
        DataGridViewRow rowMeasurementUnit;
        DataGridViewRow rowPaymentTerm;
        DataGridViewRow rowSubClassification;
        DataGridViewRow rowSupplier;
        DataGridViewRow rowVehicle;
        DataGridViewRow rowVehicleType;

        public MaintenanceForm()
        {
            InitializeComponent();

            idxBranch = -1;
            idxCompany = -1;
            idxClassification = -1;
            idxSubClassification = -1;

            #region BRANCH MANAGER DECLARATION
            branchManager = new BranchManager();
            branchManager.ExceptionCatched += ExceptionCatched;
            branchManager.NewItemGenerated += BranchManager_NewItemGenerated;
            branchManager.Added += BranchManager_Added;
            branchManager.AddedUnsuccessful += BranchManager_AddedUnsuccessful;
            branchManager.Removed += BranchManager_Removed;
            branchManager.RemovedUnsuccessful += BranchManager_RemovedUnsuccessful;
            branchManager.Updated += BranchManager_Updated;
            branchManager.UpdatedUnsuccessful += BranchManager_UpdatedUnsuccessful;
            #endregion

            #region COMPANY MANAGER DECLARATION
            companyManager = new CompanyManager();
            companyManager.ExceptionCatched += ExceptionCatched;
            companyManager.NewItemGenerated += CompanyManager_NewItemGenerated;
            companyManager.Added += CompanyManager_Added;
            companyManager.AddedUnsuccessful += CompanyManager_AddedUnsuccessful;
            companyManager.Removed += CompanyManager_Removed;
            companyManager.RemovedUnsuccessful += CompanyManager_RemovedUnsuccessful;
            companyManager.Updated += CompanyManager_Updated;
            companyManager.UpdatedUnsuccessful += CompanyManager_UpdatedUnsuccessful;
            #endregion

            #region CLASSIFICATION MANAGER DECLARATION
            classificationManager = new ClassificationManager();
            classificationManager.ExceptionCatched += ExceptionCatched;
            classificationManager.NewItemGenerated += ClassificationManager_NewItemGenerated;
            classificationManager.Added += ClassificationManager_Added;
            classificationManager.AddedUnsuccessful += ClassificationManager_AddedUnsuccessful;
            classificationManager.Removed += ClassificationManager_Removed;
            classificationManager.RemovedUnsuccessful += ClassificationManager_RemovedUnsuccessful;
            classificationManager.Updated += ClassificationManager_Updated;
            classificationManager.UpdatedUnsuccessful += ClassificationManager_UpdatedUnsuccessful;
            #endregion

            #region SUB-CLASSIFICATION MANAGER DECLARATION
            subClassificationManager = new SubClassificationManager();
            subClassificationManager.ExceptionCatched += ExceptionCatched;
            subClassificationManager.NewItemGenerated += SubClassificationManager_NewItemGenerated;
            subClassificationManager.Added += SubClassificationManager_Added;
            subClassificationManager.AddedUnsuccessful += SubClassificationManager_AddedUnsuccessful;
            subClassificationManager.Removed += SubClassificationManager_Removed;
            subClassificationManager.RemovedUnsuccessful += SubClassificationManager_RemovedUnsuccessful;
            subClassificationManager.Updated += SubClassificationManager_Updated;
            subClassificationManager.UpdatedUnsuccessful += SubClassificationManager_UpdatedUnsuccessful;
            #endregion

            #region MEASUREMENT UNIT MANAGER DECLARATION
            measurementUnitManager = new MeasurementUnitManager();
            measurementUnitManager.ExceptionCatched += ExceptionCatched;
            measurementUnitManager.NewItemGenerated += MeasurementUnitManager_NewItemGenerated;
            measurementUnitManager.Added += MeasurementUnitManager_Added;
            measurementUnitManager.AddedUnsuccessful += MeasurementUnitManager_AddedUnsuccessful;
            measurementUnitManager.Removed += MeasurementUnitManager_Removed;
            measurementUnitManager.RemovedUnsuccessful += MeasurementUnitManager_RemovedUnsuccessful;
            measurementUnitManager.Updated += MeasurementUnitManager_Updated;
            measurementUnitManager.UpdatedUnsuccessful += MeasurementUnitManager_UpdatedUnsuccessful;
            #endregion

            #region PAYMENT TERM MANAGER DECLARATION
            paymentTermManager = new PaymentTermManager();
            paymentTermManager.ExceptionCatched += ExceptionCatched;
            paymentTermManager.NewItemGenerated += PaymentTermManager_NewItemGenerated;
            paymentTermManager.Added += PaymentTermManager_Added;
            paymentTermManager.AddedUnsuccessful += PaymentTermManager_AddedUnsuccessful;
            paymentTermManager.Removed += PaymentTermManager_Removed;
            paymentTermManager.RemovedUnsuccessful += PaymentTermManager_RemovedUnsuccessful;
            paymentTermManager.Updated += PaymentTermManager_Updated;
            paymentTermManager.UpdatedUnsuccessful += PaymentTermManager_UpdatedUnsuccessful;
            #endregion

            #region SUPPLIER MANAGER DECLARATION
            supplierManager = new SupplierManager();
            supplierManager.ExceptionCatched += ExceptionCatched;
            supplierManager.NewItemGenerated += SupplierManager_NewItemGenerated;
            supplierManager.Added += SupplierManager_Added;
            supplierManager.AddedUnsuccessful += SupplierManager_AddedUnsuccessful;
            supplierManager.Removed += SupplierManager_Removed;
            supplierManager.RemovedUnsuccessful += SupplierManager_RemovedUnsuccessful;
            supplierManager.Updated += SupplierManager_Updated;
            supplierManager.UpdatedUnsuccessful += SupplierManager_UpdatedUnsuccessful;
            #endregion

            #region VEHICLE MANAGER DECLARATION
            vehicleManager = new VehicleManager();
            vehicleManager.ExceptionCatched += ExceptionCatched;
            vehicleManager.NewItemGenerated += VehicleManager_NewItemGenerated;
            vehicleManager.Added += VehicleManager_Added;
            vehicleManager.AddedUnsuccessful += VehicleManager_AddedUnsuccessful;
            vehicleManager.Removed += VehicleManager_Removed;
            vehicleManager.RemovedUnsuccessful += VehicleManager_RemovedUnsuccessful;
            vehicleManager.Updated += VehicleManager_Updated;
            vehicleManager.UpdatedUnsuccessful += VehicleManager_UpdatedUnsuccessful;
            #endregion

            #region VEHICLE TYPE MANAGER DECLARATION
            vehicleTypeManager = new VehicleTypeManager();
            vehicleTypeManager.ExceptionCatched += ExceptionCatched;
            vehicleTypeManager.NewItemGenerated += VehicleTypeManager_NewItemGenerated;
            vehicleTypeManager.Added += VehicleTypeManager_Added;
            vehicleTypeManager.AddedUnsuccessful += VehicleTypeManager_AddedUnsuccessful;
            vehicleTypeManager.Removed += VehicleTypeManager_Removed;
            vehicleTypeManager.RemovedUnsuccessful += VehicleTypeManager_RemovedUnsuccessful;
            vehicleTypeManager.Updated += VehicleTypeManager_Updated;
            vehicleTypeManager.UpdatedUnsuccessful += VehicleTypeManager_UpdatedUnsuccessful;
            #endregion
        }
        
        #region DATA ADDED
        private async void BranchManager_Added(Branch e)
        {
            notify("Successfully added!");
            await loadBranches();
            displayBranch();
        }
        private async void ClassificationManager_Added(Classification e)
        {
            notify("Successfully added!");
            await loadClassifications();
            displayClassification();
        }
        private async void CompanyManager_Added(Company e)
        {
            notify("Successfully added!");
            await loadCompanies();
            displayCompany();
        }
        private async void MeasurementUnitManager_Added(MeasurementUnit e)
        {
            notify("Successfully added!");
            await loadMeasurementUnits();
            displayMeasurementUnit();
        }
        private async void PaymentTermManager_Added(PaymentTerm e)
        {
            notify("Successfully added!");
            await loadPaymentTerms();
            displayPaymentTerm();
        }
        private async void SubClassificationManager_Added(SubClassification e)
        {
            notify("Successfully added!");
            await loadSubClassifications();
            displaySubClassification();
        }
        private async void SupplierManager_Added(Supplier e)
        {
            notify("Successfully added!");
            await loadSuppliers();
            displaySupplier();
        }
        private async void VehicleManager_Added(Vehicle e)
        {
            notify("Successfully added!");
            await loadVehicles();
            displayVehicle();
        }
        private async void VehicleTypeManager_Added(VehicleType e)
        {
            notify("Successfully added!");
            await loadVehicleTypes();
            displayVehicleType();
        }
        #endregion

        #region DATA ADDED UNSUCCESSFUL
        private void BranchManager_AddedUnsuccessful(Branch e)
        {
            displayError("Adding failed!");
        }
        private void ClassificationManager_AddedUnsuccessful(Classification e)
        {
            displayError("Adding failed!");
        }
        private void CompanyManager_AddedUnsuccessful(Company e)
        {
            displayError("Adding failed!");
        }
        private void MeasurementUnitManager_AddedUnsuccessful(MeasurementUnit e)
        {
            displayError("Adding failed!");
        }
        private void PaymentTermManager_AddedUnsuccessful(PaymentTerm e)
        {
            displayError("Adding failed!");
        }
        private void SubClassificationManager_AddedUnsuccessful(SubClassification e)
        {
            displayError("Adding failed!");
        }
        private void SupplierManager_AddedUnsuccessful(Supplier e)
        {
            displayError("Adding failed!");
        }
        private void VehicleManager_AddedUnsuccessful(Vehicle e)
        {
            displayError("Adding failed!");
        }
        private void VehicleTypeManager_AddedUnsuccessful(VehicleType e)
        {
            displayError("Adding failed!");
        }
        #endregion

        #region DATA REMOVED
        private void BranchManager_Removed(Branch e)
        {
            notify("Successfully removed!");
            dgvBranches.Rows.Remove(rowBranch);
            rowBranch = null;
            idxBranch = -1;
            activeBranch = null;
        }
        private void ClassificationManager_Removed(Classification e)
        {
            notify("Successfully removed!");
            dgvClassifications.Rows.Remove(rowClassification);
            rowClassification = null;
            idxClassification = -1;
            activeClassification = null;
        }
        private void CompanyManager_Removed(Company e)
        {
            notify("Successfully removed!");
            dgvCompanies.Rows.Remove(rowCompany);
            rowCompany = null;
            idxCompany = -1;
            activeCompany = null;
        }
        private void MeasurementUnitManager_Removed(MeasurementUnit e)
        {
            notify("Successfully removed!");
            dgvMeasurementUnits.Rows.Remove(rowMeasurementUnit);
            rowMeasurementUnit = null;
            idxMeasurementUnit = -1;
            activeMeasurementUnit = null;
        }
        private void PaymentTermManager_Removed(PaymentTerm e)
        {
            notify("Successfully removed!");
            dgvPaymentTerms.Rows.Remove(rowPaymentTerm);
            rowPaymentTerm = null;
            idxPaymentTerm = -1;
            activePaymentTerm = null;
        }
        private void SubClassificationManager_Removed(SubClassification e)
        {
            notify("Successfully removed!");
            dgvSubClassifications.Rows.Remove(rowSubClassification);
            rowSubClassification = null;
            idxSubClassification = -1;
            activeSubClassification = null;
        }
        private void SupplierManager_Removed(Supplier e)
        {
            notify("Successfully removed!");
            dgvSuppliers.Rows.Remove(rowSupplier);
            rowSupplier = null;
            idxSupplier = -1;
            activeSupplier = null;
        }
        private void VehicleManager_Removed(Vehicle e)
        {
            notify("Successfully removed!");
            dgvVehicles.Rows.Remove(rowVehicle);
            rowVehicle = null;
            idxVehicle = -1;
            activeVehicle = null;
        }
        private void VehicleTypeManager_Removed(VehicleType e)
        {
            notify("Successfully removed!");
            dgvVehicleTypes.Rows.Remove(rowVehicleType);
            rowVehicleType = null;
            idxVehicleType = -1;
            activeVehicleType = null;
        }
        #endregion

        #region DATA REMOVED UNSUCCESSFUL
        private void BranchManager_RemovedUnsuccessful(Branch e)
        {
            displayError("Removing failed!");
        }
        private void ClassificationManager_RemovedUnsuccessful(Classification e)
        {
            displayError("Removing failed!");
        }
        private void CompanyManager_RemovedUnsuccessful(Company e)
        {
            displayError("Removing failed!");
        }
        private void MeasurementUnitManager_RemovedUnsuccessful(MeasurementUnit e)
        {
            displayError("Removing failed!");
        }
        private void PaymentTermManager_RemovedUnsuccessful(PaymentTerm e)
        {
            displayError("Removing failed!");
        }
        private void SubClassificationManager_RemovedUnsuccessful(SubClassification e)
        {
            displayError("Removing failed!");
        }
        private void SupplierManager_RemovedUnsuccessful(Supplier e)
        {
            displayError("Removing failed!");
        }
        private void VehicleManager_RemovedUnsuccessful(Vehicle e)
        {
            displayError("Removing failed!");
        }
        private void VehicleTypeManager_RemovedUnsuccessful(VehicleType e)
        {
            displayError("Removing failed!");
        }
        #endregion

        #region DATA UPDATED
        private void BranchManager_Updated(Branch e)
        {
            notify("Successfully updated!");
            insertActiveBranch();
        }
        private void ClassificationManager_Updated(Classification e)
        {
            notify("Successfully updated!");
            insertActiveClassification();
        }
        private void CompanyManager_Updated(Company e)
        {
            notify("Successfully updated!");
            insertActiveCompany();
        }
        private void MeasurementUnitManager_Updated(MeasurementUnit e)
        {
            notify("Successfully updated!");
            insertActiveMeasurementUnit();
        }
        private void PaymentTermManager_Updated(PaymentTerm e)
        {
            notify("Successfully updated!");
            insertActivePaymentTerm();
        }
        private void SubClassificationManager_Updated(SubClassification e)
        {
            notify("Successfully updated!");
            insertActiveSubClassification();
        }
        private void SupplierManager_Updated(Supplier e)
        {
            notify("Successfully updated!");
            insertActiveSupplier();
        }
        private void VehicleManager_Updated(Vehicle e)
        {
            notify("Successfully updated!");
            insertActiveVehicle();
        }
        private void VehicleTypeManager_Updated(VehicleType e)
        {
            notify("Successfully updated!");
            insertActiveVehicleType();
        }
        #endregion

        #region DATA UPDATED UNSUCCESSFUL
        private void BranchManager_UpdatedUnsuccessful(Branch e)
        {
            displayError("Updating failed!");
        }
        private void ClassificationManager_UpdatedUnsuccessful(Classification e)
        {
            displayError("Updating failed!");
        }
        private void CompanyManager_UpdatedUnsuccessful(Company e)
        {
            displayError("Updating failed!");
        }
        private void MeasurementUnitManager_UpdatedUnsuccessful(MeasurementUnit e)
        {
            displayError("Updating failed!");
        }
        private void PaymentTermManager_UpdatedUnsuccessful(PaymentTerm e)
        {
            displayError("Updating failed!");
        }
        private void SubClassificationManager_UpdatedUnsuccessful(SubClassification e)
        {
            displayError("Updating failed!");
        }
        private void SupplierManager_UpdatedUnsuccessful(Supplier e)
        {
            displayError("Updating failed!");
        }
        private void VehicleManager_UpdatedUnsuccessful(Vehicle e)
        {
            displayError("Updating failed!");
        }
        private void VehicleTypeManager_UpdatedUnsuccessful(VehicleType e)
        {
            displayError("Updating failed!");
        }
        #endregion

        #region NEW ITEM GENERATION
        private void VehicleManager_NewItemGenerated(Vehicle e)
        {
            Invoke(new Action(() => dgvVehicles.Rows.Add(e, e.Type)));
        }
        private void PaymentTermManager_NewItemGenerated(PaymentTerm e)
        {
            Invoke(new Action(() => dgvPaymentTerms.Rows.Add(e, e.DayCount)));
        }
        private void VehicleTypeManager_NewItemGenerated(VehicleType e)
        {
            Invoke(new Action(() =>
            {
                dgvVehicleTypes.Rows.Add(e, e.Code);
                cmbxVehicleVehicleType.Items.Add(e);
            }));
        }
        private void SupplierManager_NewItemGenerated(Supplier e)
        {
            Invoke(new Action(() => dgvSuppliers.Rows.Add(e, e.Code, e.Address, e.ContactNumber)));
        }
        private void SubClassificationManager_NewItemGenerated(SubClassification e)
        {
            Invoke(new Action(() => dgvSubClassifications.Rows.Add(e, e.Classification, e.Code, e.MeasurementUnit)));
        }
        private void ClassificationManager_NewItemGenerated(Classification e)
        {
            Invoke(new Action(() =>
            {
                dgvClassifications.Rows.Add(e, e.Code, e.MeasurementUnit);
                cmbxSubClassificationClassification.Items.Add(e);
            }));
        }
        private void CompanyManager_NewItemGenerated(Company e)
        {
            Invoke(new Action(() => dgvCompanies.Rows.Add(e, e.Code)));
        }
        private void BranchManager_NewItemGenerated(Branch e)
        {
            Invoke(new Action(() => dgvBranches.Rows.Add(e, e.Code)));
        }
        private void MeasurementUnitManager_NewItemGenerated(MeasurementUnit e)
        {
            Invoke(new Action(() =>
            {
                dgvMeasurementUnits.Rows.Add(e, e.Symbol);
                cmbxClassificationMeasurementUnit.Items.Add(e);
                cmbxSubClassificationMeasurementUnit.Items.Add(e);
            }));
        }
        #endregion

        #region DATA LOADING
        private async Task loadBranches()
        {
            dgvBranches.Rows.Clear();
            activeBranch = null;
            branches = (await branchManager.GetListAsync())?.ToList();
        }
        private async Task loadCompanies()
        {
            dgvCompanies.Rows.Clear();
            activeCompany = null;
            companies = (await companyManager.GetListAsync())?.ToList();
        }
        private async Task loadClassifications()
        {
            dgvClassifications.Rows.Clear();
            cmbxSubClassificationClassification.Items.Clear();
            activeClassification = null;
            classifications = (await classificationManager.GetListAsync())?.ToList();
        }
        private async Task loadSubClassifications()
        {
            dgvSubClassifications.Rows.Clear();
            activeSubClassification = null;
            subClassifications = (await subClassificationManager.GetListAsync())?.ToList();
        }
        private async Task loadMeasurementUnits()
        {
            dgvMeasurementUnits.Rows.Clear();
            cmbxClassificationMeasurementUnit.Items.Clear();
            cmbxSubClassificationMeasurementUnit.Items.Clear();
            activeSubClassification = null;
            measurementUnits = (await measurementUnitManager.GetListAsync())?.ToList();
        }
        private async Task loadPaymentTerms()
        {
            dgvPaymentTerms.Rows.Clear();
            activePaymentTerm = null;
            paymentTerms = (await paymentTermManager.GetListAsync())?.ToList();
        }
        private async Task loadSuppliers()
        {
            dgvSuppliers.Rows.Clear();
            activeSupplier = null;
            suppliers = (await supplierManager.GetListAsync())?.ToList();
        }
        private async Task loadVehicles()
        {
            dgvVehicles.Rows.Clear();
            activeVehicle = null;
            vehicles = (await vehicleManager.GetListAsync())?.ToList();
        }
        private async Task loadVehicleTypes()
        {
            dgvVehicleTypes.Rows.Clear();
            cmbxVehicleVehicleType.Items.Clear();
            activeVehicleType = null;
            vehicleTypes = (await vehicleTypeManager.GetListAsync())?.ToList();
        }
        #endregion
        
        private void ExceptionCatched(Exception ex)
        {
            if (DebugMode) MessageBox.Show(ex.Message);
        }
        private async void MaintenanceForm_Load(object sender, EventArgs e)
        {
            await loadBranches();
            await loadCompanies();
            await loadSuppliers();
            await loadPaymentTerms();
            await loadMeasurementUnits();
            await loadVehicleTypes();
            await loadClassifications();
            await loadVehicles();
            await loadSubClassifications();
        }
        private void deselectRows(DataGridView dgv)
        {
            foreach (DataGridViewRow item in dgv.Rows)
                item.Selected = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region DISPLAY MESSAGE
        private void notify(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void displayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private DialogResult ask(string message)
        {
            return MessageBox.Show(message, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        #region DISPLAY DATA
        private void displayBranch()
        {
            tbxBranchCode.Text = string.Empty;
            tbxBranchDescription.Text = string.Empty;
            if (activeBranch != null)
            {
                tbxBranchCode.Text = activeBranch.Code;
                tbxBranchDescription.Text = activeBranch.Description;
            }
            else
            {
                tbxBranchCode.Text = $"{CodePrefixes.Branch}-{generateCode(dgvBranches, colBranchCode)}";
            }
        }
        private void displayCompany()
        {
            tbxCompanyCode.Text = string.Empty;
            tbxCompanyDescription.Text = string.Empty;
            if (activeCompany != null)
            {
                tbxCompanyCode.Text = activeCompany.Code;
                tbxCompanyDescription.Text = activeCompany.Description;
            }
            else
            {
                tbxCompanyCode.Text = $"{CodePrefixes.Company}-{generateCode(dgvCompanies, colCompanyCode)}";
            }
        }
        private void displayClassification()
        {
            tbxClassificationCode.Text = string.Empty;
            tbxClassificationDescription.Text = string.Empty;
            cmbxClassificationMeasurementUnit.SelectedItem = null;
            if (activeClassification != null)
            {
                tbxClassificationCode.Text = activeClassification.Code;
                tbxClassificationDescription.Text = activeClassification.Description;
                cmbxClassificationMeasurementUnit.SelectedItem = activeClassification.MeasurementUnit;
            }
            else
            {
                tbxClassificationCode.Text = $"{CodePrefixes.Classification}-{generateCode(dgvClassifications, colClassificationCode)}";
            }
        }
        private void displayMeasurementUnit()
        {
            tbxMeasurementUnitDescription.Text = string.Empty;
            tbxMeasurementUnitSymbol.Text = string.Empty;
            if (activeMeasurementUnit != null)
            {
                tbxMeasurementUnitDescription.Text = activeMeasurementUnit.Description;
                tbxMeasurementUnitSymbol.Text = activeMeasurementUnit.Symbol;
            }
        }
        private void displaySubClassification()
        {
            tbxSubClassificationCode.Text = string.Empty;
            tbxSubClassificationDescription.Text = string.Empty;
            cmbxSubClassificationClassification.SelectedItem = null;
            cmbxSubClassificationMeasurementUnit.SelectedItem = null;
            if (activeSubClassification != null)
            {
                tbxSubClassificationDescription.Text = activeSubClassification.Description;
                cmbxSubClassificationClassification.SelectedItem = activeSubClassification.Classification;
                cmbxSubClassificationMeasurementUnit.SelectedItem = activeSubClassification.MeasurementUnit;
                tbxSubClassificationCode.Text = activeSubClassification.Code;
            }
        }
        private void displayPaymentTerm()
        {
            tbxPaymentTermDescription.Text = string.Empty;
            nudPaymentTermDayCount.Value = 0;
            if (activePaymentTerm != null)
            {
                tbxPaymentTermDescription.Text = activePaymentTerm.Description;
                nudPaymentTermDayCount.Value = activePaymentTerm.DayCount;
            }
        }
        private void displaySupplier()
        {
            tbxSupplierAddress.Text = string.Empty;
            tbxSupplierCode.Text = string.Empty;
            tbxSupplierContactNumber.Text = string.Empty;
            tbxSupplierDescription.Text = string.Empty;
            if (activeSupplier != null)
            {
                tbxSupplierAddress.Text = activeSupplier.Address;
                tbxSupplierCode.Text = activeSupplier.Code;
                tbxSupplierContactNumber.Text = activeSupplier.ContactNumber;
                tbxSupplierDescription.Text = activeSupplier.Description;
            }
            else
            {
                tbxSupplierCode.Text = $"{CodePrefixes.Supplier}-{generateCode(dgvSuppliers, colSupplierCode)}";
            }
        }
        private void displayVehicle()
        {
            tbxVehiclePhysicalNumber.Text = string.Empty;
            tbxVehiclePlateNumber.Text = string.Empty;
            cmbxVehicleVehicleType.SelectedItem = null;
            if (activeVehicle != null)
            {
                tbxVehiclePhysicalNumber.Text = activeVehicle.PhysicalNumber;
                tbxVehiclePlateNumber.Text = activeVehicle.PlateNumber;
                cmbxVehicleVehicleType.SelectedItem = activeVehicle.Type;
            }
        }
        private void displayVehicleType()
        {
            tbxVehicleTypeCode.Text = string.Empty;
            tbxVehicleTypeDescription.Text = string.Empty;
            if (activeVehicleType != null)
            {
                tbxVehicleTypeCode.Text = activeVehicleType.Code;
                tbxVehicleTypeDescription.Text = activeVehicleType.Description;
            }
        }
        #endregion

        #region ENABLE DATA FIELDS
        private void enableBranchFields(bool enabled)
        {
            tbxBranchCode.Enabled = enabled;
            tbxBranchDescription.Enabled = enabled;
        }
        private void enableCompanyFields(bool enabled)
        {
            tbxCompanyCode.Enabled = enabled;
            tbxCompanyDescription.Enabled = enabled;
        }
        private void enableClassificationFields(bool enabled)
        {
            tbxClassificationCode.Enabled = enabled;
            tbxClassificationDescription.Enabled = enabled;
            cmbxClassificationMeasurementUnit.Enabled = enabled;
        }
        private void enableMeasurementUnitFields(bool enabled)
        {
            tbxMeasurementUnitDescription.Enabled = enabled;
            tbxMeasurementUnitSymbol.Enabled = enabled;
        }
        private void enableSubClassificationFields(bool enabled)
        {
            tbxSubClassificationCode.Enabled = enabled;
            tbxSubClassificationDescription.Enabled = enabled;
            cmbxSubClassificationClassification.Enabled = enabled;
            cmbxSubClassificationMeasurementUnit.Enabled = enabled;
        }
        private void enablePaymentTermFields(bool enabled)
        {
            tbxPaymentTermDescription.Enabled = enabled;
            nudPaymentTermDayCount.Enabled = enabled;
        }
        private void enableSupplierFields(bool enabled)
        {
            tbxSupplierAddress.Enabled = enabled;
            tbxSupplierCode.Enabled = enabled;
            tbxSupplierContactNumber.Enabled = enabled;
            tbxSupplierDescription.Enabled = enabled;
        }
        private void enableVehicleFields(bool enabled)
        {
            tbxVehiclePhysicalNumber.Enabled = enabled;
            tbxVehiclePlateNumber.Enabled = enabled;
            cmbxVehicleVehicleType.Enabled = enabled;
        }
        private void enableVehicleTypeFields(bool enabled)
        {
            tbxVehicleTypeCode.Enabled = enabled;
            tbxVehicleTypeDescription.Enabled = enabled;
        }
        #endregion

        #region DATA HAS CHANGES
        private bool branchHasChanges()
        {
            var code = tbxBranchCode.Text.Trim();
            var description = tbxBranchDescription.Text.Trim();
            if (activeBranch != null)
            {
                if (code != activeBranch.Code) return true;
                if (description != activeBranch.Description) return true;
            }
            return false;
        }
        private bool companyHasChanges()
        {
            var code = tbxCompanyCode.Text.Trim();
            var description = tbxCompanyDescription.Text.Trim();
            if (activeCompany != null)
            {
                if (code != activeCompany.Code) return true;
                if (description != activeCompany.Description) return true;
            }
            return false;
        }
        private bool classificationHasChanges()
        {
            var code = tbxClassificationCode.Text.Trim();
            var description = tbxClassificationDescription.Text.Trim();
            var measurementUnit = (MeasurementUnit)cmbxClassificationMeasurementUnit.SelectedItem;
            if (activeClassification != null)
            {
                if (code != activeClassification.Code) return true;
                if (description != activeClassification.Description) return true;
                if (measurementUnit != activeClassification.MeasurementUnit) return true;
            }
            return false;
        }
        private bool measurementUnitHasChanges()
        {
            var description = tbxMeasurementUnitDescription.Text.Trim();
            var symbol = tbxMeasurementUnitSymbol.Text.Trim();
            if (activeMeasurementUnit != null)
            {
                if (description != activeMeasurementUnit.Description) return true;
                if (symbol != activeMeasurementUnit.Symbol) return true;
            }
            return false;
        }
        private bool subClassificationHasChanges()
        {
            var description = tbxSubClassificationDescription.Text.Trim();
            var code = tbxSubClassificationCode.Text.Trim();
            var classification = (Classification)cmbxSubClassificationClassification.SelectedItem;
            var measurementUnit = (MeasurementUnit)cmbxSubClassificationMeasurementUnit.SelectedItem;
            if (activeSubClassification != null)
            {
                if (description != activeSubClassification.Description) return true;
                if (code != activeSubClassification.Code) return true;
                if (classification != activeSubClassification.Classification) return true;
                if (measurementUnit != activeSubClassification.MeasurementUnit) return true;
            }
            return false;
        }
        private bool paymentTermHasChanges()
        {
            var description = tbxPaymentTermDescription.Text.Trim();
            var dayCount = (uint)nudPaymentTermDayCount.Value;
            if (activePaymentTerm != null)
            {
                if (description != activePaymentTerm.Description) return true;
                if (dayCount != activePaymentTerm.DayCount) return true;
            }
            return false;
        }
        private bool supplierHasChanges()
        {
            var code = tbxSupplierCode.Text.Trim();
            var description = tbxSupplierDescription.Text.Trim();
            var address = tbxSupplierAddress.Text.Trim();
            var contactNumber = tbxSupplierContactNumber.Text.Trim();
            if (activeSupplier != null)
            {
                if (code != activeSupplier.Code) return true;
                if (description != activeSupplier.Description) return true;
                if (address != activeSupplier.Address) return true;
                if (contactNumber != activeSupplier.ContactNumber) return true;
            }
            return false;
        }
        private bool vehicleHasChanges()
        {
            var physicalNumber = tbxVehiclePhysicalNumber.Text.Trim();
            var plateNumber = tbxVehiclePlateNumber.Text.Trim();
            var vehicleType = (VehicleType)cmbxVehicleVehicleType.SelectedItem;
            if (activeVehicle != null)
            {
                if (physicalNumber != activeVehicle.PhysicalNumber) return true;
                if (plateNumber != activeVehicle.PlateNumber) return true;
                if (vehicleType != activeVehicle.Type) return true;
            }
            return false;
        }
        private bool vehicleTypeHasChanges()
        {
            var code = tbxVehicleTypeCode.Text.Trim();
            var description = tbxVehicleTypeDescription.Text.Trim();
            if (activeVehicleType != null)
            {
                if (code != activeVehicleType.Code) return true;
                if (description != activeVehicleType.Description) return true;
            }
            return false;
        }
        #endregion

        #region CHECK DATA CHANGES
        private void checkBranchChanges()
        {
            if (activeBranch != null)
            {
                if (branchHasChanges())
                {
                    if (ask("Changes in branch details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveBranch();
                    else insertActiveBranch();
                }
                else insertActiveBranch();
            }
            displayBranch();
            enableBranchFields(false);
        }
        private void checkCompanyChanges()
        {
            if (activeCompany != null)
            {
                if (companyHasChanges())
                {
                    if (ask("Changes in company details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveCompany();
                    else insertActiveCompany();
                }
                else insertActiveCompany();
            }
            displayCompany();
            enableCompanyFields(false);
        }
        private void checkClassificationChanges()
        {
            if (activeClassification != null)
            {
                if (classificationHasChanges())
                {
                    if (ask("Changes in classification details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveClassification();
                    else insertActiveClassification();
                }
                else insertActiveClassification();
            }
            displayClassification();
            enableClassificationFields(false);
        }
        private void checkMeasurementUnitChanges()
        {
            if (activeMeasurementUnit != null)
            {
                if (measurementUnitHasChanges())
                {
                    if (ask("Changes in measurement unit details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveMeasurementUnit();
                    else insertActiveMeasurementUnit();
                }
                else insertActiveMeasurementUnit();
            }
            displayMeasurementUnit();
            enableMeasurementUnitFields(false);
        }
        private void checkSubClassificationChanges()
        {
            if (activeSubClassification != null)
            {
                if (subClassificationHasChanges())
                {
                    if (ask("Changes in sub-classification details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveSubClassification();
                    else insertActiveSubClassification();
                }
                else insertActiveSubClassification();
            }
            displaySubClassification();
            enableSubClassificationFields(false);
        }
        private void checkPaymentTermChanges()
        {
            if (activePaymentTerm != null)
            {
                if (paymentTermHasChanges())
                {
                    if (ask("Changes in payment term details has been detected, do you want to save this first?") == DialogResult.Yes)
                        savePaymentTerm();
                    else insertActivePaymentTerm();
                }
                else insertActivePaymentTerm();
            }
            displayPaymentTerm();
            enablePaymentTermFields(false);
        }
        private void checkSupplierChanges()
        {
            if (activeSupplier != null)
            {
                if (supplierHasChanges())
                {
                    if (ask("Changes in supplier details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveSupplier();
                    else insertActiveSupplier();
                }
                else insertActiveSupplier();
            }
            displaySupplier();
            enableSupplierFields(false);
        }
        private void checkVehicleChanges()
        {
            if (activeVehicle != null)
            {
                if (vehicleHasChanges())
                {
                    if (ask("Changes in vehicle details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveVehicle();
                    else insertActiveVehicle();
                }
                else insertActiveVehicle();
            }
            displayVehicle();
            enableVehicleFields(false);
        }
        private void checkVehicleTypeChanges()
        {
            if (activeVehicleType != null)
            {
                if (vehicleTypeHasChanges())
                {
                    if (ask("Changes in vehicle type details has been detected, do you want to save this first?") == DialogResult.Yes)
                        saveVehicleType();
                    else insertActiveVehicleType();
                }
                else insertActiveVehicleType();
            }
            displayVehicleType();
            enableVehicleTypeFields(false);
        }
        #endregion

        #region INSERT ACTIVE DATA TO DISPLAY
        private void insertActiveBranch()
        {
            if (idxBranch < 0) idxBranch = dgvBranches.Rows.Count - 1;
            dgvBranches.Rows.Insert(idxBranch, activeBranch, activeBranch.Code);
            activeBranch = null;
            rowBranch = null;
            idxBranch = -1;
            displayBranch();
            enableBranchFields(false);
        }
        private void insertActiveCompany()
        {
            if (idxCompany < 0) idxCompany = dgvCompanies.Rows.Count - 1;
            dgvCompanies.Rows.Insert(idxCompany, activeCompany, activeCompany.Code);
            activeCompany = null;
            rowCompany = null;
            idxCompany = -1;
            displayCompany();
            enableCompanyFields(false);
        }
        private void insertActiveClassification()
        {
            if (idxClassification < 0) idxClassification = dgvClassifications.Rows.Count - 1;
            dgvClassifications.Rows.Insert(idxClassification, activeClassification, activeClassification.Code, activeClassification.MeasurementUnit);
            activeClassification = null;
            rowClassification = null;
            idxClassification = -1;
            displayClassification();
            enableClassificationFields(false);
        }
        private void insertActiveMeasurementUnit()
        {
            if (idxMeasurementUnit < 0) idxMeasurementUnit = dgvMeasurementUnits.Rows.Count - 1;
            dgvMeasurementUnits.Rows.Insert(idxMeasurementUnit, activeMeasurementUnit, activeMeasurementUnit.Symbol);
            activeMeasurementUnit = null;
            rowMeasurementUnit = null;
            idxMeasurementUnit = -1;
            displayMeasurementUnit();
            enableMeasurementUnitFields(false);
        }
        private void insertActiveSubClassification()
        {
            if (idxSubClassification < 0) idxSubClassification = dgvSubClassifications.Rows.Count - 1;
            dgvSubClassifications.Rows.Insert(idxSubClassification, activeSubClassification, activeSubClassification.Classification, activeSubClassification.Code, activeSubClassification.MeasurementUnit);
            activeSubClassification = null;
            rowSubClassification = null;
            idxSubClassification = -1;
            displaySubClassification();
            enableSubClassificationFields(false);
        }
        private void insertActivePaymentTerm()
        {
            if (idxPaymentTerm < 0) idxPaymentTerm = dgvPaymentTerms.Rows.Count - 1;
            dgvPaymentTerms.Rows.Insert(idxPaymentTerm, activePaymentTerm, activePaymentTerm.DayCount);
            activePaymentTerm = null;
            rowPaymentTerm = null;
            idxPaymentTerm = -1;
            displayPaymentTerm();
            enablePaymentTermFields(false);
        }
        private void insertActiveSupplier()
        {
            if (idxSupplier < 0) idxSupplier = dgvSuppliers.Rows.Count - 1;
            dgvSuppliers.Rows.Insert(idxSupplier, activeSupplier, activeSupplier.Code, activeSupplier.Address, activeSupplier.ContactNumber);
            activeSupplier = null;
            rowSupplier = null;
            idxSupplier = -1;
            displaySupplier();
            enableSupplierFields(false);
        }
        private void insertActiveVehicle()
        {
            if (idxVehicle < 0) idxVehicle = dgvVehicles.Rows.Count - 1;
            dgvVehicles.Rows.Insert(idxVehicle, activeVehicle, activeVehicle.Type);
            activeVehicle = null;
            rowVehicle = null;
            idxVehicle = -1;
            displayVehicle();
            enableVehicleFields(false);
        }
        private void insertActiveVehicleType()
        {
            if (idxVehicleType < 0) idxVehicleType = dgvVehicleTypes.Rows.Count - 1;
            dgvVehicleTypes.Rows.Insert(idxVehicleType, activeVehicleType, activeVehicleType.Code);
            activeVehicleType = null;
            rowVehicleType = null;
            idxVehicleType = -1;
            displayVehicleType();
            enableVehicleTypeFields(false);
        }
        #endregion

        #region DATA VALIDATION
        private bool branchValidation()
        {
            var code = tbxBranchCode.Text.Trim();
            var description = tbxBranchDescription.Text.Trim();
            if (code == string.Empty)
            {
                displayError("Branch code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                displayError("Branch name must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvBranches.Rows)
            {
                var branch = (Branch)item.Cells[colBranch.Name].Value;
                if (code == branch.Code)
                {
                    displayError("Branch Code already in use!");
                    return false;
                }
                if (description == branch.Description)
                {
                    displayError("Branch name already exists!");
                    return false;
                }
            }
            return true;
        }
        private bool companyValidation()
        {
            var code = tbxCompanyCode.Text.Trim();
            var description = tbxCompanyDescription.Text.Trim();
            if (code == string.Empty)
            {
                displayError("Company code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                displayError("Company description must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvCompanies.Rows)
            {
                var company = (Company)item.Cells[colCompany.Name].Value;
                if (code == company.Code)
                {
                    displayError("Company code already in use!");
                    return false;
                }
                if (description == company.Description)
                {
                    displayError("Company name already exists!");
                    return false;
                }
            }
            return true;
        }
        private bool classificationValidation()
        {
            var code = tbxClassificationCode.Text.Trim();
            var description = tbxClassificationDescription.Text.Trim();
            var measurementUnit = (MeasurementUnit)cmbxClassificationMeasurementUnit.SelectedItem;
            if (code == string.Empty)
            {
                displayError("Classification code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                displayError("Classification name must be valid!");
                return false;
            }
            if (measurementUnit == null)
            {
                displayError("Measurement unit for classification must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvClassifications.Rows)
            {
                var classification = (Classification)item.Cells[colClassification.Name].Value;
                if (code == classification.Code)
                {
                    displayError("Classification code already in use!");
                    return false;
                }
                if (description == classification.Description)
                {
                    displayError("Classification name already exists!");
                    return false;
                }
            }
            return true;
        }
        private bool measurementUnitValidation()
        {
            var description = tbxMeasurementUnitDescription.Text.Trim();
            var symbol = tbxMeasurementUnitSymbol.Text.Trim();
            if (description == string.Empty)
            {
                displayError("Measurement unit name must be valid!");
                return false;
            }
            if (symbol == string.Empty)
            {
                displayError("Measurement unit symbol must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvMeasurementUnits.Rows)
            {
                var measurementUnit = (MeasurementUnit)item.Cells[colMeasurementUnit.Name].Value;
                if (description == measurementUnit.Description)
                {
                    displayError("Measurement unit name already exists!");
                    return false;
                }
                if (symbol == measurementUnit.Symbol)
                {
                    displayError("Measurement unit symbol already in use!");
                    return false;
                }
            }
            return true;
        }
        private bool subClassificationValidation()
        {
            var classification = (Classification)cmbxSubClassificationClassification.SelectedItem;
            var code = tbxSubClassificationCode.Text.Trim();
            var description = tbxSubClassificationDescription.Text;
            var measurementUnit = (MeasurementUnit)cmbxSubClassificationMeasurementUnit.SelectedItem;
            if (classification == null)
            {
                displayError("Classification must be selected!");
                return false;
            }
            if (code == string.Empty)
            {
                displayError("Sub-classification code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                displayError("Sub-classification name must be valid!");
                return false;
            }
            if (measurementUnit == null)
            {
                displayError("Measurement unit of Sub-classification must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvSubClassifications.Rows)
            {
                var subClassification = (SubClassification)item.Cells[colSubClassification.Name].Value;
                if (code == subClassification.Code)
                {
                    displayError("Sub-classification code already in use!");
                    return false;
                }
                if (description == subClassification.Description)
                {
                    displayError("Sub-classification already exists!");
                    return false;
                }
            }
            return true;
        }
        private bool paymentTermValidation()
        {
            var description = tbxPaymentTermDescription.Text.Trim();
            var dayCount = (uint)nudPaymentTermDayCount.Value;
            if (description == string.Empty)
            {
                displayError("Payment term name must be valid!");
                return false;
            }
            if (dayCount == 0)
            {
                displayError("Count of days must not be zero!");
                return false;
            }
            foreach (DataGridViewRow item in dgvPaymentTerms.Rows)
            {
                var paymentTerm = (PaymentTerm)item.Cells[colPaymentTerm.Name].Value;
                if (description == paymentTerm.Description)
                {
                    displayError("Payment term name already exists!");
                    return false;
                }
                if (dayCount == paymentTerm.DayCount)
                {
                    displayError("Count of days already exists!");
                    return false;
                }
            }
            return true;
        }
        private bool supplierValidation()
        {
            var description = tbxSupplierDescription.Text.Trim();
            var code = tbxSupplierCode.Text.Trim();
            if (description == string.Empty)
            {
                displayError("Supplier name must be valid!");
                return false;
            }
            if (code == string.Empty)
            {
                displayError("Supplier code must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvSuppliers.Rows)
            {
                var supplier = (Supplier)item.Cells[colSupplier.Name].Value;
                if (description == supplier.Description)
                {
                    displayError("Supplier name already exists!");
                    return false;
                }
                if (code == supplier.Code)
                {
                    displayError("Supplier code already in use!");
                    return false;
                }
            }
            return true;
        }
        private bool vehicleValidation()
        {
            var physicalNumber = tbxVehiclePhysicalNumber.Text.Trim();
            var plateNumber = tbxVehiclePlateNumber.Text.Trim();
            if (physicalNumber == string.Empty)
            {
                displayError("Vehicle's physical no. must be valid!");
                return false;
            }
            if (plateNumber == string.Empty)
            {
                displayError("Vehicle's plate no. must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvVehicles.Rows)
            {
                var vehicle = (Vehicle)item.Cells[colVehicle.Name].Value;
                if (physicalNumber == vehicle.PhysicalNumber)
                {
                    displayError("Physical no. already in use!");
                    return false;
                }
                if (plateNumber == vehicle.PlateNumber)
                {
                    displayError("Plate no. already in use!");
                    return false;
                }
            }
            return true;
        }
        private bool vehicleTypeValidation()
        {
            var code = tbxVehicleTypeCode.Text.Trim();
            var description = tbxVehicleTypeDescription.Text.Trim();
            if (code == string.Empty)
            {
                displayError("Vehicle type code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                displayError("Vehicle type name must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvVehicleTypes.Rows)
            {
                var vehicleType = (VehicleType)item.Cells[colVehicleType.Name].Value;
                if (code == vehicleType.Code)
                {
                    displayError("Code already in use!");
                    return false;
                }
                if (description == vehicleType.Description)
                {
                    displayError("Vehicle type name already exists!");
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region SAVE DATA
        private void saveBranch()
        {
            if (branchValidation())
            {
                var code = tbxBranchCode.Text.Trim();
                var description = tbxBranchDescription.Text.Trim();
                if (activeBranch == null)
                {
                    activeBranch = new Branch
                    {
                        Code = code,
                        Description = description
                    };
                    branchManager.Add(activeBranch);
                }
                else
                {
                    if (branchHasChanges())
                    {
                        activeBranch.Code = code;
                        activeBranch.Description = description;
                        branchManager.Update(activeBranch);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveCompany()
        {
            if (companyValidation())
            {
                var code = tbxCompanyCode.Text.Trim();
                var description = tbxCompanyDescription.Text.Trim();
                if (activeCompany == null)
                {
                    activeCompany = new Company
                    {
                        Code = code,
                        Description = description
                    };
                    companyManager.Add(activeCompany);
                }
                else
                {
                    if (companyHasChanges())
                    {
                        activeCompany.Code = code;
                        activeCompany.Description = description;
                        companyManager.Update(activeCompany);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveClassification()
        {
            if (classificationValidation())
            {
                var code = tbxClassificationCode.Text.Trim();
                var description = tbxClassificationDescription.Text.Trim();
                var measurementUnit = (MeasurementUnit)cmbxClassificationMeasurementUnit.SelectedItem;
                if (activeClassification == null)
                {
                    activeClassification = new Classification
                    {
                        Code = code,
                        Description = description,
                        MeasurementUnit = measurementUnit
                    };
                    classificationManager.Add(activeClassification);
                }
                else
                {
                    if (classificationHasChanges())
                    {
                        activeClassification.Code = code;
                        activeClassification.Description = description;
                        activeClassification.MeasurementUnit = measurementUnit;
                        classificationManager.Update(activeClassification);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveMeasurementUnit()
        {
            if (measurementUnitValidation())
            {
                var description = tbxMeasurementUnitDescription.Text.Trim();
                var symbol = tbxMeasurementUnitSymbol.Text.Trim();
                if (activeMeasurementUnit == null)
                {
                    activeMeasurementUnit = new MeasurementUnit
                    {
                        Description = description,
                        Symbol = symbol
                    };
                    measurementUnitManager.Add(activeMeasurementUnit);
                }
                else
                {
                    if (measurementUnitHasChanges())
                    {
                        activeMeasurementUnit.Description = description;
                        activeMeasurementUnit.Symbol = symbol;
                        measurementUnitManager.Update(activeMeasurementUnit);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveSubClassification()
        {
            if (subClassificationValidation())
            {
                var classification = (Classification)cmbxSubClassificationClassification.SelectedItem;
                var code = tbxSubClassificationCode.Text.Trim();
                var description = tbxSubClassificationDescription.Text.Trim();
                var measurementUnit = (MeasurementUnit)cmbxSubClassificationMeasurementUnit.SelectedItem;
                if (activeSubClassification == null)
                {
                    activeSubClassification = new SubClassification
                    {
                        Classification = classification,
                        Code = code,
                        Description = description,
                        MeasurementUnit = measurementUnit
                    };
                    subClassificationManager.Add(activeSubClassification);
                }
                else
                {
                    if (subClassificationHasChanges())
                    {
                        activeSubClassification.Classification = classification;
                        activeSubClassification.Code = code;
                        activeSubClassification.Description = description;
                        activeSubClassification.MeasurementUnit = measurementUnit;
                        subClassificationManager.Update(activeSubClassification);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void savePaymentTerm()
        {
            if (paymentTermValidation())
            {
                var description = tbxPaymentTermDescription.Text.Trim();
                var dayCount = (uint)nudPaymentTermDayCount.Value;
                if (activePaymentTerm == null)
                {
                    activePaymentTerm = new PaymentTerm
                    {
                        DayCount = dayCount,
                        Description = description
                    };
                    paymentTermManager.Add(activePaymentTerm);
                }
                else
                {
                    if (paymentTermHasChanges())
                    {
                        activePaymentTerm.DayCount = dayCount;
                        activePaymentTerm.Description = description;
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveSupplier()
        {
            if (supplierValidation())
            {
                var description = tbxSupplierDescription.Text.Trim();
                var code = tbxSupplierCode.Text.Trim();
                var address = tbxSupplierAddress.Text.Trim();
                var contactNumber = tbxSupplierContactNumber.Text.Trim();
                if (activeSupplier == null)
                {
                    activeSupplier = new Supplier
                    {
                        Address = address,
                        Code = code,
                        ContactNumber = contactNumber,
                        Description = description
                    };
                    supplierManager.Add(activeSupplier);
                }
                else
                {
                    if (supplierHasChanges())
                    {
                        activeSupplier.Address = address;
                        activeSupplier.Code = code;
                        activeSupplier.ContactNumber = contactNumber;
                        activeSupplier.Description = description;
                        supplierManager.Update(activeSupplier);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveVehicle()
        {
            if (vehicleValidation())
            {
                var physicalNumber = tbxVehiclePhysicalNumber.Text.Trim();
                var plateNumber = tbxVehiclePlateNumber.Text.Trim();
                var vehicleType = (VehicleType)cmbxVehicleVehicleType.SelectedItem;
                if (activeVehicle == null)
                {
                    activeVehicle = new Vehicle
                    {
                        PhysicalNumber = physicalNumber,
                        PlateNumber = plateNumber,
                        Type = vehicleType
                    };
                    vehicleManager.Add(activeVehicle);
                }
                else
                {
                    if (vehicleHasChanges())
                    {
                        activeVehicle.PhysicalNumber = physicalNumber;
                        activeVehicle.PlateNumber = plateNumber;
                        activeVehicle.Type = vehicleType;
                        vehicleManager.Update(activeVehicle);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        private void saveVehicleType()
        {
            if (vehicleTypeValidation())
            {
                var code = tbxVehicleTypeCode.Text.Trim();
                var description = tbxVehicleTypeDescription.Text.Trim();
                if (activeVehicleType == null)
                {
                    activeVehicleType = new VehicleType
                    {
                        Code = code,
                        Description = description
                    };
                    vehicleTypeManager.Add(activeVehicleType);
                }
                else
                {
                    if (vehicleTypeHasChanges())
                    {
                        activeVehicleType.Code = code;
                        activeVehicleType.Description = description;
                        vehicleTypeManager.Update(activeVehicleType);
                    }
                    else displayError("No changes detected!");
                }
            }
        }
        #endregion

        #region DATA GRID VIEW DATA SELECTION CHANGED
        private void dgvBranches_SelectionChanged(object sender, EventArgs e)
        {
            enableBranchFields(false);
        }
        private void dgvCompanies_SelectionChanged(object sender, EventArgs e)
        {
            enableCompanyFields(false);
        }
        private void dgvClassifications_SelectionChanged(object sender, EventArgs e)
        {
            enableClassificationFields(false);
        }
        private void dgvMeasurementUnits_SelectionChanged(object sender, EventArgs e)
        {
            enableMeasurementUnitFields(false);
        }
        private void dgvSubClassifications_SelectionChanged(object sender, EventArgs e)
        {
            enableSubClassificationFields(false);
        }
        private void dgvPaymentTerms_SelectionChanged(object sender, EventArgs e)
        {
            enablePaymentTermFields(false);
        }
        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            enableSupplierFields(false);
        }
        private void dgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            enableVehicleFields(false);
        }
        private void dgvVehicleTypes_SelectionChanged(object sender, EventArgs e)
        {
            enableVehicleTypeFields(false);
        }
        #endregion

        #region BUTTON NEW DATA CLICK
        private void btnNewBranches_Click(object sender, EventArgs e)
        {
            checkBranchChanges();
            activeBranch = null;
            displayBranch();
            enableBranchFields(true);
        }
        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            checkCompanyChanges();
            activeCompany = null;
            displayCompany();
            enableCompanyFields(true);
        }
        private void btnNewClassification_Click(object sender, EventArgs e)
        {
            checkClassificationChanges();
            activeClassification = null;
            displayClassification();
            enableClassificationFields(true);
        }
        private void btnNewMeasurementUnit_Click(object sender, EventArgs e)
        {
            checkMeasurementUnitChanges();
            activeMeasurementUnit = null;
            displayMeasurementUnit();
            enableMeasurementUnitFields(true);
        }
        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            checkSupplierChanges();
            activeSupplier = null;
            displaySupplier();
            enableSupplierFields(true);
        }
        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            checkVehicleChanges();
            activeVehicle = null;
            displayVehicle();
            enableVehicleFields(true);
        }
        private void btnNewVehicleType_Click(object sender, EventArgs e)
        {
            checkVehicleTypeChanges();
            activeVehicleType = null;
            displayVehicleType();
            enableVehicleTypeFields(true);
        }
        private void btnNewSubClassification_Click(object sender, EventArgs e)
        {
            checkSubClassificationChanges();
            activeSubClassification = null;
            displaySubClassification();
            enableSubClassificationFields(true);
        }
        private void btnNewPaymentTerm_Click(object sender, EventArgs e)
        {
            checkPaymentTermChanges();
            activePaymentTerm = null;
            displayPaymentTerm();
            enablePaymentTermFields(true);
        }
        #endregion

        #region BUTTON EDIT DATA CLICK
        private void btnEditBranch_Click(object sender, EventArgs e)
        {
            if (dgvBranches.SelectedRows.Count == 1)
            {
                checkBranchChanges();
                rowBranch = dgvBranches.SelectedRows[0];
                idxBranch = rowBranch.Index;
                activeBranch = (Branch)rowBranch.Cells[colBranch.Name].Value;
                displayBranch();
                dgvBranches.Rows.Remove(rowBranch);
                enableBranchFields(true);
            }
        }
        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvCompanies.SelectedRows.Count == 1)
            {
                checkCompanyChanges();
                rowCompany = dgvCompanies.SelectedRows[0];
                idxCompany = rowCompany.Index;
                activeCompany = (Company)rowCompany.Cells[colCompany.Name].Value;
                displayCompany();
                dgvCompanies.Rows.Remove(rowCompany);
                enableCompanyFields(true);
            }
        }
        private void btnEditClassification_Click(object sender, EventArgs e)
        {
            if (dgvClassifications.SelectedRows.Count == 1)
            {
                checkClassificationChanges();
                rowClassification = dgvClassifications.SelectedRows[0];
                idxClassification = rowClassification.Index;
                activeClassification = (Classification)rowClassification.Cells[colClassification.Name].Value;
                displayClassification();
                dgvClassifications.Rows.Remove(rowClassification);
                enableClassificationFields(true);
            }
        }
        private void btnEditMeasurementUnit_Click(object sender, EventArgs e)
        {
            if (dgvMeasurementUnits.SelectedRows.Count == 1)
            {
                checkMeasurementUnitChanges();
                rowMeasurementUnit = dgvMeasurementUnits.SelectedRows[0];
                idxMeasurementUnit = rowMeasurementUnit.Index;
                activeMeasurementUnit = (MeasurementUnit)rowMeasurementUnit.Cells[colMeasurementUnit.Name].Value;
                displayMeasurementUnit();
                dgvMeasurementUnits.Rows.Remove(rowMeasurementUnit);
                enableMeasurementUnitFields(true);
            }
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 1)
            {
                checkSupplierChanges();
                rowSupplier = dgvSuppliers.SelectedRows[0];
                idxSupplier = rowSupplier.Index;
                activeSupplier = (Supplier)rowSupplier.Cells[colSupplier.Name].Value;
                displaySupplier();
                dgvSuppliers.Rows.Remove(rowSupplier);
                enableSupplierFields(true);
            }
        }
        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 1)
            {
                checkVehicleChanges();
                rowVehicle = dgvVehicles.SelectedRows[0];
                idxVehicle = rowVehicle.Index;
                activeVehicle = (Vehicle)rowVehicle.Cells[colVehicle.Name].Value;
                displayVehicle();
                dgvVehicles.Rows.Remove(rowVehicle);
                enableVehicleFields(true);
            }
        }
        private void btnEditVehicleType_Click(object sender, EventArgs e)
        {
            if (dgvVehicleTypes.SelectedRows.Count == 1)
            {
                checkVehicleTypeChanges();
                rowVehicleType = dgvVehicleTypes.SelectedRows[0];
                idxVehicleType = rowVehicleType.Index;
                activeVehicleType = (VehicleType)rowVehicleType.Cells[colVehicleType.Name].Value;
                displayVehicleType();
                dgvVehicleTypes.Rows.Remove(rowVehicleType);
                enableVehicleTypeFields(true);
            }
        }
        private void btnEditSubClassification_Click(object sender, EventArgs e)
        {
            if (dgvSubClassifications.SelectedRows.Count == 1)
            {
                checkSubClassificationChanges();
                rowSubClassification = dgvSubClassifications.SelectedRows[0];
                idxSubClassification = rowSubClassification.Index;
                activeSubClassification = (SubClassification)rowSubClassification.Cells[colSubClassification.Name].Value;
                displaySubClassification();
                dgvSubClassifications.Rows.Remove(rowSubClassification);
                enableSubClassificationFields(true);
            }
        }
        private void btnEditPaymentTerm_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTerms.SelectedRows.Count == 1)
            {
                checkPaymentTermChanges();
                rowPaymentTerm = dgvPaymentTerms.SelectedRows[0];
                idxPaymentTerm = rowPaymentTerm.Index;
                activePaymentTerm = (PaymentTerm)rowPaymentTerm.Cells[colPaymentTerm.Name].Value;
                displayPaymentTerm();
                dgvPaymentTerms.Rows.Remove(rowPaymentTerm);
                enablePaymentTermFields(true);
            }
        }
        #endregion

        #region BUTTON CANCEL DATA CLICK
        private void btnCancelBranch_Click(object sender, EventArgs e)
        {
            checkBranchChanges();
        }
        private void btnCancelCompany_Click(object sender, EventArgs e)
        {
            checkCompanyChanges();
        }
        private void btnCancelClassification_Click(object sender, EventArgs e)
        {
            checkClassificationChanges();
        }
        private void btnCancelMeasurementUnit_Click(object sender, EventArgs e)
        {
            checkMeasurementUnitChanges();
        }
        private void btnCancelSupplier_Click(object sender, EventArgs e)
        {
            checkSupplierChanges();
        }
        private void btnCancelVehicle_Click(object sender, EventArgs e)
        {
            checkVehicleChanges();
        }
        private void btnCancelVehicleType_Click(object sender, EventArgs e)
        {
            checkVehicleTypeChanges();
        }
        private void btnCancelSubClassification_Click(object sender, EventArgs e)
        {
            checkSubClassificationChanges();
        }
        private void btnCancelPaymentTerm_Click(object sender, EventArgs e)
        {
            checkPaymentTermChanges();
        }
        #endregion

        #region BUTTON SAVE DATA CLICK
        private void btnSaveBranch_Click(object sender, EventArgs e)
        {
            saveBranch();
        }
        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            saveCompany();
        }
        private void btnSaveClassification_Click(object sender, EventArgs e)
        {
            saveClassification();
        }
        private void btnSaveMeasurementUnit_Click(object sender, EventArgs e)
        {
            saveMeasurementUnit();
        }
        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            saveSupplier();
        }
        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            saveVehicle();
        }
        private void btnSaveVehicleType_Click(object sender, EventArgs e)
        {
            saveVehicleType();
        }
        private void btnSaveSubClassification_Click(object sender, EventArgs e)
        {
            saveSubClassification();
        }
        private void btnSavePaymentTerm_Click(object sender, EventArgs e)
        {
            savePaymentTerm();
        }
        #endregion

        #region BUTTON REMOVE DATA CLICK
        private void btnRemoveBranch_Click(object sender, EventArgs e)
        {
            if (dgvBranches.SelectedRows.Count == 1)
            {
                checkBranchChanges();
                rowBranch = dgvBranches.SelectedRows[0];
                idxBranch = rowBranch.Index;
                activeBranch = (Branch)rowBranch.Cells[colBranch.Name].Value;
                if (ask($"Are you sure, you want to remove {activeBranch} branch?") == DialogResult.Yes)
                {
                    branchManager.Remove(activeBranch);
                }
                activeBranch = null;
            }

        }
        private void btnRemoveCompany_Click(object sender, EventArgs e)
        {
            if (dgvCompanies.SelectedRows.Count == 1)
            {
                checkCompanyChanges();
                rowCompany = dgvCompanies.SelectedRows[0];
                idxCompany = rowCompany.Index;
                activeCompany = (Company)rowCompany.Cells[colCompany.Name].Value;
                if (ask($"Are you sure, you want to remove {activeCompany}?") == DialogResult.Yes)
                {
                    companyManager.Remove(activeCompany);
                }
                activeCompany = null;
            }
        }
        private void btnRemoveClassification_Click(object sender, EventArgs e)
        {
            if (dgvClassifications.SelectedRows.Count == 1)
            {
                checkClassificationChanges();
                rowClassification = dgvClassifications.SelectedRows[0];
                idxClassification = rowClassification.Index;
                activeClassification = (Classification)rowClassification.Cells[colClassification.Name].Value;
                if (ask($"Are you sure, you want to remove {activeClassification}?") == DialogResult.Yes)
                {
                    classificationManager.Remove(activeClassification);
                }
                activeClassification = null;
            }
        }
        private void btnRemoveMeasurementUnit_Click(object sender, EventArgs e)
        {
            if (dgvMeasurementUnits.SelectedRows.Count == 1)
            {
                checkMeasurementUnitChanges();
                rowMeasurementUnit = dgvMeasurementUnits.SelectedRows[0];
                idxMeasurementUnit = rowMeasurementUnit.Index;
                activeMeasurementUnit = (MeasurementUnit)rowMeasurementUnit.Cells[colMeasurementUnit.Name].Value;
                if (ask($"Are you sure, you want to remove {activeMeasurementUnit}?") == DialogResult.Yes)
                {
                    measurementUnitManager.Remove(activeMeasurementUnit);
                }
                activeMeasurementUnit = null;
            }
        }
        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 1)
            {
                checkSupplierChanges();
                rowSupplier = dgvSuppliers.SelectedRows[0];
                idxSupplier = rowSupplier.Index;
                activeSupplier = (Supplier)rowSupplier.Cells[colSupplier.Name].Value;
                if (ask($"Are you sure, you want to remove {activeSupplier}?") == DialogResult.Yes)
                {
                    supplierManager.Remove(activeSupplier);
                }
                activeSupplier = null;
            }
        }
        private void btnRemoveVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 1)
            {
                checkVehicleChanges();
                rowVehicle = dgvVehicles.SelectedRows[0];
                idxVehicle = rowVehicle.Index;
                activeVehicle = (Vehicle)rowVehicle.Cells[colVehicle.Name].Value;
                if (ask($"Are you sure, you want to remove {activeVehicle}?") == DialogResult.Yes)
                {
                    vehicleManager.Remove(activeVehicle);
                }
                activeVehicle = null;
            }
        }
        private void btnRemoveVehicleType_Click(object sender, EventArgs e)
        {
            if (dgvVehicleTypes.SelectedRows.Count == 1)
            {
                checkVehicleTypeChanges();
                rowVehicleType = dgvVehicleTypes.SelectedRows[0];
                idxVehicleType = rowVehicleType.Index;
                activeVehicleType = (VehicleType)rowVehicleType.Cells[colVehicleType.Name].Value;
                if (ask($"Are you sure, you want to remove {activeVehicleType}?") == DialogResult.Yes)
                {
                    vehicleTypeManager.Remove(activeVehicleType);
                }
                activeVehicleType = null;
            }
        }
        private void btnRemoveSubClassification_Click(object sender, EventArgs e)
        {
            if (dgvSubClassifications.SelectedRows.Count == 1)
            {
                checkSubClassificationChanges();
                rowSubClassification = dgvSubClassifications.SelectedRows[0];
                idxSubClassification = rowSubClassification.Index;
                activeSubClassification = (SubClassification)rowSubClassification.Cells[colSubClassification.Name].Value;
                if (ask($"Are you sure, you want to remove {activeSubClassification}?") == DialogResult.Yes)
                {
                    subClassificationManager.Remove(activeSubClassification);
                }
                activeSubClassification = null;
            }
        }
        private void btnRemovePaymentTerm_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTerms.SelectedRows.Count == 1)
            {
                checkPaymentTermChanges();
                rowPaymentTerm = dgvPaymentTerms.SelectedRows[0];
                idxPaymentTerm = rowPaymentTerm.Index;
                activePaymentTerm = (PaymentTerm)rowPaymentTerm.Cells[colPaymentTerm.Name].Value;
                if (ask($"Are you sure, you want to remove {activePaymentTerm}?") == DialogResult.Yes)
                {
                    paymentTermManager.Remove(activePaymentTerm);
                }
                activePaymentTerm = null;
            }
        }

        #endregion

        private string generateCode(DataGridView dgv, DataGridViewColumn col)
        {
            List<uint> rawCodes = new List<uint>();
            string code = string.Empty;
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    code = (string)row.Cells[col.Name].Value;
                    rawCodes.Add(uint.Parse(code.Substring(code.Length - 4)));
                }
                for (int i = 1; i < 10000; i++)
                    if (!exists(rawCodes, (uint)i)) return i.ToString("0000");
            }
            return "0001";
        }

        private string generateSubClassificationCode()
        {
            List<uint> rawCodes = new List<uint>();
            string code = string.Empty;
            var tempClassification = (Classification)cmbxSubClassificationClassification.SelectedItem;
            if (dgvSubClassifications.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvSubClassifications.Rows)
                {
                    var classification = (Classification)item.Cells[colSubClassificationClassification.Name].Value;
                    if (classification == tempClassification)
                    {
                        code = (string)item.Cells[colSubClassificationCode.Name].Value;
                        rawCodes.Add(uint.Parse(code.Substring(code.Length - 4)));
                    }
                }
                for (int i = 1; i < 10000; i++)
                    if (!exists(rawCodes, (uint)i)) return i.ToString("0000"); 
            }
            return "0001";
        }

        private bool exists(List<uint> list, uint x)
        {
            foreach (var item in list)
                if (x == item) return true;
            return false;
        }

        private void cmbxSubClassificationClassification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxSubClassificationClassification.SelectedItem != null)
            {
                var classification = (Classification)cmbxSubClassificationClassification.SelectedItem;
                tbxSubClassificationCode.Text = $"{classification.Code}-{CodePrefixes.SubClassification}-{generateSubClassificationCode()}";
                cmbxSubClassificationMeasurementUnit.SelectedItem = classification.MeasurementUnit;
            }
        }
    }
}