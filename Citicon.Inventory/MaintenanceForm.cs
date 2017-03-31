using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
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
        SupplierManager supplierManager;
        VehicleManager vehicleManager;
        VehicleTypeManager vehicleTypeManager;

        Branch activeBranch;
        Classification activeClassification;
        Company activeCompany;
        MeasurementUnit activeMeasurementUnit;
        PaymentTerm activePaymentTerm;
        Supplier activeSupplier;
        Vehicle activeVehicle;
        VehicleType activeVehicleType;

        List<Branch> branches;
        List<Classification> classifications;
        List<Company> companies;
        List<MeasurementUnit> measurementUnits;
        List<PaymentTerm> paymentTerms;
        List<Supplier> suppliers;
        List<Vehicle> vehicles;
        List<VehicleType> vehicleTypes;

        int idxBranch;
        int idxClassification;
        int idxCompany;
        int idxMeasurementUnit;
        int idxPaymentTerm;
        int idxSupplier;
        int idxVehicle;
        int idxVehicleType;

        DataGridViewRow rowBranch;
        DataGridViewRow rowClassification;
        DataGridViewRow rowCompany;
        DataGridViewRow rowMeasurementUnit;
        DataGridViewRow rowPaymentTerm;
        DataGridViewRow rowSupplier;
        DataGridViewRow rowVehicle;
        DataGridViewRow rowVehicleType;

        public MaintenanceForm()
        {
            InitializeComponent();

            idxBranch = -1;
            idxCompany = -1;
            idxClassification = -1;

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
        private void BranchManager_Added(Branch e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvBranches.Rows)
            {
                Action<int> insert = (index) => { dgvBranches.Rows.Insert(index, e, e.Code); };
                var upper = (Branch)row.Cells[colBranch.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvBranches.Rows.Count ? (Branch)dgvBranches.Rows[lowerIndex].Cells[colBranch.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            activeBranch = null;
            DisplayBranch();
            EnableBranchFields(false);
        }
        private void ClassificationManager_Added(Classification e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvClassifications.Rows)
            {
                Action<int> insert = (index) => { dgvClassifications.Rows.Insert(index, e, e.Code, e.MeasurementUnit); };
                var upper = (Classification)row.Cells[colClassification.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvClassifications.Rows.Count ? (Classification)dgvClassifications.Rows[lowerIndex].Cells[colClassification.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            activeClassification = null;
            DisplayClassification();
            EnableClassificationFields(false);
        }
        private void CompanyManager_Added(Company e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvCompanies.Rows)
            {
                Action<int> insert = (index) => { dgvCompanies.Rows.Insert(index, e, e.Code); };
                var upper = (Company)row.Cells[colCompany.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvCompanies.Rows.Count ? (Company)dgvCompanies.Rows[lowerIndex].Cells[colCompany.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            activeCompany = null;
            DisplayCompany();
            EnableCompanyFields(false);
        }
        private void MeasurementUnitManager_Added(MeasurementUnit e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvMeasurementUnits.Rows)
            {
                Action<int> insert = (index) => { dgvMeasurementUnits.Rows.Insert(index, e, e.Symbol); };
                var upper = (MeasurementUnit)row.Cells[colMeasurementUnit.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvMeasurementUnits.Rows.Count ? (MeasurementUnit)dgvMeasurementUnits.Rows[lowerIndex].Cells[colMeasurementUnit.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            cmbxClassificationMeasurementUnit.Items.Clear();
            foreach (DataGridViewRow row in dgvMeasurementUnits.Rows)
                cmbxClassificationMeasurementUnit.Items.Add((MeasurementUnit)row.Cells[colClassificationMeasurementUnit.Name].Value);
            activeMeasurementUnit = null;
            DisplayMeasurementUnit();
            EnableMeasurementUnitFields(false);
        }
        private void PaymentTermManager_Added(PaymentTerm e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvPaymentTerms.Rows)
            {
                Action<int> insert = (index) => { dgvPaymentTerms.Rows.Insert(index, e, e.DayCount); };
                var upper = (PaymentTerm)row.Cells[colPaymentTerm.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvPaymentTerms.Rows.Count ? (PaymentTerm)dgvPaymentTerms.Rows[lowerIndex].Cells[colPaymentTerm.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            activePaymentTerm = null;
            DisplayPaymentTerm();
            EnablePaymentTermFields(false);
        }
        private void SupplierManager_Added(Supplier e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvSuppliers.Rows)
            {
                Action<int> insert = (index) => { dgvSuppliers.Rows.Insert(index, e, e.Code, e.Address, e.ContactNumber); };
                var upper = (Supplier)row.Cells[colSupplier.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvSuppliers.Rows.Count ? (Supplier)dgvSuppliers.Rows[lowerIndex].Cells[colSupplier.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            activeSupplier = null;
            DisplaySupplier();
            EnableSupplierFields(false);
        }
        private void VehicleManager_Added(Vehicle e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvVehicles.Rows)
            {
                Action<int> insert = (index) => { dgvVehicles.Rows.Insert(index, e, e.Type); };
                var upper = (Vehicle)row.Cells[colVehicle.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvVehicles.Rows.Count ? (Vehicle)dgvVehicles.Rows[lowerIndex].Cells[colVehicle.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.ToString(), e.ToString()) == -1 && string.Compare(lower.ToString(), e.ToString()) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            activeVehicle = null;
            DisplayVehicle();
            EnableVehicleFields(false);
        }
        private void VehicleTypeManager_Added(VehicleType e)
        {
            Notify("Successfully added!");
            foreach (DataGridViewRow row in dgvVehicleTypes.Rows)
            {
                Action<int> insert = (index) => { dgvVehicleTypes.Rows.Insert(index, e, e.Code); };
                var upper = (VehicleType)row.Cells[colVehicleType.Name].Value;
                var lowerIndex = row.Index + 1;
                var lower = lowerIndex < dgvVehicleTypes.Rows.Count ? (VehicleType)dgvVehicleTypes.Rows[lowerIndex].Cells[colVehicleType.Name].Value : null;
                if (lower != null)
                {
                    if (string.Compare(upper.Description, e.Description) == -1 && string.Compare(lower.Description, e.Description) == 1)
                    {
                        insert(lowerIndex);
                        break;
                    }
                }
                else
                {
                    insert(row.Index + 1);
                    break;
                }
            }
            cmbxVehicleVehicleType.Items.Clear();
            foreach (DataGridViewRow row in dgvVehicleTypes.Rows)
                cmbxVehicleVehicleType.Items.Add((VehicleType)row.Cells[colVehicleType.Name].Value);
            activeVehicleType = null;
            DisplayVehicleType();
            EnableVehicleTypeFields(false);
        }
        #endregion

        #region DATA ADDED UNSUCCESSFUL
        private void BranchManager_AddedUnsuccessful(Branch e)
        {
            DisplayError("Adding failed!");
        }
        private void ClassificationManager_AddedUnsuccessful(Classification e)
        {
            DisplayError("Adding failed!");
        }
        private void CompanyManager_AddedUnsuccessful(Company e)
        {
            DisplayError("Adding failed!");
        }
        private void MeasurementUnitManager_AddedUnsuccessful(MeasurementUnit e)
        {
            DisplayError("Adding failed!");
        }
        private void PaymentTermManager_AddedUnsuccessful(PaymentTerm e)
        {
            DisplayError("Adding failed!");
        }
        private void SupplierManager_AddedUnsuccessful(Supplier e)
        {
            DisplayError("Adding failed!");
        }
        private void VehicleManager_AddedUnsuccessful(Vehicle e)
        {
            DisplayError("Adding failed!");
        }
        private void VehicleTypeManager_AddedUnsuccessful(VehicleType e)
        {
            DisplayError("Adding failed!");
        }
        #endregion

        #region DATA REMOVED
        private void BranchManager_Removed(Branch e)
        {
            Notify("Successfully removed!");
            dgvBranches.Rows.Remove(rowBranch);
            rowBranch = null;
            idxBranch = -1;
            activeBranch = null;
        }
        private void ClassificationManager_Removed(Classification e)
        {
            Notify("Successfully removed!");
            dgvClassifications.Rows.Remove(rowClassification);
            rowClassification = null;
            idxClassification = -1;
            activeClassification = null;
        }
        private void CompanyManager_Removed(Company e)
        {
            Notify("Successfully removed!");
            dgvCompanies.Rows.Remove(rowCompany);
            rowCompany = null;
            idxCompany = -1;
            activeCompany = null;
        }
        private void MeasurementUnitManager_Removed(MeasurementUnit e)
        {
            Notify("Successfully removed!");
            dgvMeasurementUnits.Rows.Remove(rowMeasurementUnit);
            rowMeasurementUnit = null;
            idxMeasurementUnit = -1;
            activeMeasurementUnit = null;
        }
        private void PaymentTermManager_Removed(PaymentTerm e)
        {
            Notify("Successfully removed!");
            dgvPaymentTerms.Rows.Remove(rowPaymentTerm);
            rowPaymentTerm = null;
            idxPaymentTerm = -1;
            activePaymentTerm = null;
        }
        private void SupplierManager_Removed(Supplier e)
        {
            Notify("Successfully removed!");
            dgvSuppliers.Rows.Remove(rowSupplier);
            rowSupplier = null;
            idxSupplier = -1;
            activeSupplier = null;
        }
        private void VehicleManager_Removed(Vehicle e)
        {
            Notify("Successfully removed!");
            dgvVehicles.Rows.Remove(rowVehicle);
            rowVehicle = null;
            idxVehicle = -1;
            activeVehicle = null;
        }
        private void VehicleTypeManager_Removed(VehicleType e)
        {
            Notify("Successfully removed!");
            dgvVehicleTypes.Rows.Remove(rowVehicleType);
            rowVehicleType = null;
            idxVehicleType = -1;
            activeVehicleType = null;
        }
        #endregion

        #region DATA REMOVED UNSUCCESSFUL
        private void BranchManager_RemovedUnsuccessful(Branch e)
        {
            DisplayError("Removing failed!");
        }
        private void ClassificationManager_RemovedUnsuccessful(Classification e)
        {
            DisplayError("Removing failed!");
        }
        private void CompanyManager_RemovedUnsuccessful(Company e)
        {
            DisplayError("Removing failed!");
        }
        private void MeasurementUnitManager_RemovedUnsuccessful(MeasurementUnit e)
        {
            DisplayError("Removing failed!");
        }
        private void PaymentTermManager_RemovedUnsuccessful(PaymentTerm e)
        {
            DisplayError("Removing failed!");
        }
        private void SupplierManager_RemovedUnsuccessful(Supplier e)
        {
            DisplayError("Removing failed!");
        }
        private void VehicleManager_RemovedUnsuccessful(Vehicle e)
        {
            DisplayError("Removing failed!");
        }
        private void VehicleTypeManager_RemovedUnsuccessful(VehicleType e)
        {
            DisplayError("Removing failed!");
        }
        #endregion

        #region DATA UPDATED
        private void BranchManager_Updated(Branch e)
        {
            Notify("Successfully updated!");
            rowBranch.Cells[colBranch.Name].Value = e;
            rowBranch.Cells[colBranchCode.Name].Value = e.Code;
            activeBranch = null;
            DisplayBranch();
            EnableBranchFields(false);
        }
        private void ClassificationManager_Updated(Classification e)
        {
            Notify("Successfully updated!");
            rowClassification.Cells[colClassification.Name].Value = e;
            rowClassification.Cells[colClassificationCode.Name].Value = e.Code;
            rowClassification.Cells[colClassificationMeasurementUnit.Name].Value = e.MeasurementUnit;
            activeClassification = null;
            DisplayClassification();
            EnableBranchFields(false);
        }
        private void CompanyManager_Updated(Company e)
        {
            Notify("Successfully updated!");
            rowCompany.Cells[colCompany.Name].Value = e;
            rowCompany.Cells[colCompanyCode.Name].Value = e.Code;
            activeCompany = null;
            DisplayCompany();
            EnableCompanyFields(false);
        }
        private void MeasurementUnitManager_Updated(MeasurementUnit e)
        {
            Notify("Successfully updated!");
            rowMeasurementUnit.Cells[colMeasurementUnit.Name].Value = e;
            rowMeasurementUnit.Cells[colMeasurementUnitSymbol.Name].Value = e.Symbol;
            activeMeasurementUnit = null;
            DisplayMeasurementUnit();
            EnableMeasurementUnitFields(false);
        }
        private void PaymentTermManager_Updated(PaymentTerm e)
        {
            Notify("Successfully updated!");
            rowPaymentTerm.Cells[colPaymentTerm.Name].Value = e;
            rowPaymentTerm.Cells[colPaymentTermDayCount.Name].Value = e.DayCount;
            activePaymentTerm = null;
            DisplayPaymentTerm();
            EnablePaymentTermFields(false);
        }
        private void SupplierManager_Updated(Supplier e)
        {
            Notify("Successfully updated!");
            rowSupplier.Cells[colSupplier.Name].Value = e;
            rowSupplier.Cells[colSupplierAddress.Name].Value = e.Address;
            rowSupplier.Cells[colSupplierCode.Name].Value = e.Code;
            rowSupplier.Cells[colSupplierContactNumber.Name].Value = e.ContactNumber;
            activeSupplier = null;
            DisplaySupplier();
            EnableSupplierFields(false);
        }
        private void VehicleManager_Updated(Vehicle e)
        {
            Notify("Successfully updated!");
            rowVehicle.Cells[colVehicle.Name].Value = e;
            rowVehicle.Cells[colVehicleVehicleType.Name].Value = e.Type;
            activeVehicle = null;
            DisplayVehicle();
            EnableVehicleFields(false);
        }
        private void VehicleTypeManager_Updated(VehicleType e)
        {
            Notify("Successfully updated!");
            rowVehicleType.Cells[colVehicleType.Name].Value = e;
            rowVehicleType.Cells[colVehicleTypeCode.Name].Value = e.Code;
            activeVehicleType = null;
            DisplayVehicleType();
            EnableVehicleTypeFields(false);
        }
        #endregion

        #region DATA UPDATED UNSUCCESSFUL
        private void BranchManager_UpdatedUnsuccessful(Branch e)
        {
            DisplayError("Updating failed!");
        }
        private void ClassificationManager_UpdatedUnsuccessful(Classification e)
        {
            DisplayError("Updating failed!");
        }
        private void CompanyManager_UpdatedUnsuccessful(Company e)
        {
            DisplayError("Updating failed!");
        }
        private void MeasurementUnitManager_UpdatedUnsuccessful(MeasurementUnit e)
        {
            DisplayError("Updating failed!");
        }
        private void PaymentTermManager_UpdatedUnsuccessful(PaymentTerm e)
        {
            DisplayError("Updating failed!");
        }
        private void SupplierManager_UpdatedUnsuccessful(Supplier e)
        {
            DisplayError("Updating failed!");
        }
        private void VehicleManager_UpdatedUnsuccessful(Vehicle e)
        {
            DisplayError("Updating failed!");
        }
        private void VehicleTypeManager_UpdatedUnsuccessful(VehicleType e)
        {
            DisplayError("Updating failed!");
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
        private void ClassificationManager_NewItemGenerated(Classification e)
        {
            Invoke(new Action(() =>
            {
                dgvClassifications.Rows.Add(e, e.Code, e.MeasurementUnit);
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
            }));
        }
        #endregion

        #region DATA LOADING
        private async Task LoadBranches()
        {
            dgvBranches.Rows.Clear();
            activeBranch = null;
            branches = (await branchManager.GetListAsync())?.ToList();
        }
        private async Task LoadCompanies()
        {
            dgvCompanies.Rows.Clear();
            activeCompany = null;
            companies = (await companyManager.GetListAsync())?.ToList();
        }
        private async Task LoadClassifications()
        {
            dgvClassifications.Rows.Clear();
            activeClassification = null;
            classifications = (await classificationManager.GetListAsync())?.ToList();
        }
        private async Task LoadMeasurementUnits()
        {
            dgvMeasurementUnits.Rows.Clear();
            cmbxClassificationMeasurementUnit.Items.Clear();
            measurementUnits = (await measurementUnitManager.GetListAsync())?.ToList();
        }
        private async Task LoadPaymentTerms()
        {
            dgvPaymentTerms.Rows.Clear();
            activePaymentTerm = null;
            paymentTerms = (await paymentTermManager.GetListAsync())?.ToList();
        }
        private async Task LoadSuppliers()
        {
            dgvSuppliers.Rows.Clear();
            activeSupplier = null;
            suppliers = (await supplierManager.GetListAsync())?.ToList();

            if (suppliers != null)
            {
                foreach (var e in suppliers)
                {
                    dgvSuppliers.Rows.Add(e, e.Code, e.Address, e.ContactNumber);
                }
            }
        }
        private async Task LoadVehicles()
        {
            dgvVehicles.Rows.Clear();
            activeVehicle = null;
            vehicles = (await vehicleManager.GetListAsync())?.ToList();
        }
        private async Task LoadVehicleTypes()
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
            if (User.CurrentUser.Inventory_OutgoingStocksOnly)
            {
                BtnUserSettings_Click(sender, EventArgs.Empty);
                Close();
            }
            else
            {
                await LoadBranches();
                await LoadCompanies();
                await LoadSuppliers();
                await LoadPaymentTerms();
                await LoadMeasurementUnits();
                await LoadVehicleTypes();
                await LoadClassifications();
                await LoadVehicles();
            }
        }
        private void DeselectRows(DataGridView dgv)
        {
            foreach (DataGridViewRow item in dgv.Rows)
                item.Selected = false;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region DISPLAY MESSAGE
        private void Notify(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayError(string message)
        {
            MessageBox.Show(message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private DialogResult Ask(string message)
        {
            return MessageBox.Show(message, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        #region DISPLAY DATA
        private void DisplayBranch()
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
                tbxBranchCode.Text = branchManager.GenerateCode();
            }
        }
        private void DisplayCompany()
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
                tbxCompanyCode.Text = companyManager.GenerateCode();
            }
        }
        private void DisplayClassification()
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
                tbxClassificationCode.Text = classificationManager.GenerateCode();
            }
        }
        private void DisplayMeasurementUnit()
        {
            tbxMeasurementUnitDescription.Text = string.Empty;
            tbxMeasurementUnitSymbol.Text = string.Empty;
            if (activeMeasurementUnit != null)
            {
                tbxMeasurementUnitDescription.Text = activeMeasurementUnit.Description;
                tbxMeasurementUnitSymbol.Text = activeMeasurementUnit.Symbol;
            }
        }
        private void DisplayPaymentTerm()
        {
            tbxPaymentTermDescription.Text = string.Empty;
            nudPaymentTermDayCount.Value = 0;
            if (activePaymentTerm != null)
            {
                tbxPaymentTermDescription.Text = activePaymentTerm.Description;
                nudPaymentTermDayCount.Value = activePaymentTerm.DayCount;
            }
        }
        private void DisplaySupplier()
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
                tbxSupplierCode.Text = supplierManager.GenerateCode();
            }
        }
        private void DisplayVehicle()
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
        private void DisplayVehicleType()
        {
            tbxVehicleTypeCode.Text = string.Empty;
            tbxVehicleTypeDescription.Text = string.Empty;
            if (activeVehicleType != null)
            {
                tbxVehicleTypeCode.Text = activeVehicleType.Code;
                tbxVehicleTypeDescription.Text = activeVehicleType.Description;
            }
            else tbxVehicleTypeCode.Text = vehicleTypeManager.GenerateCode();
        }
        #endregion

        #region ENABLE DATA FIELDS
        private void EnableBranchFields(bool enabled)
        {
            tbxBranchCode.Enabled = enabled;
            tbxBranchDescription.Enabled = enabled;
        }
        private void EnableCompanyFields(bool enabled)
        {
            tbxCompanyCode.Enabled = enabled;
            tbxCompanyDescription.Enabled = enabled;
        }
        private void EnableClassificationFields(bool enabled)
        {
            tbxClassificationCode.Enabled = enabled;
            tbxClassificationDescription.Enabled = enabled;
            cmbxClassificationMeasurementUnit.Enabled = enabled;
        }
        private void EnableMeasurementUnitFields(bool enabled)
        {
            tbxMeasurementUnitDescription.Enabled = enabled;
            tbxMeasurementUnitSymbol.Enabled = enabled;
        }
        private void EnablePaymentTermFields(bool enabled)
        {
            tbxPaymentTermDescription.Enabled = enabled;
            nudPaymentTermDayCount.Enabled = enabled;
        }
        private void EnableSupplierFields(bool enabled)
        {
            tbxSupplierAddress.Enabled = enabled;
            tbxSupplierCode.Enabled = enabled;
            tbxSupplierContactNumber.Enabled = enabled;
            tbxSupplierDescription.Enabled = enabled;
        }
        private void EnableVehicleFields(bool enabled)
        {
            tbxVehiclePhysicalNumber.Enabled = enabled;
            tbxVehiclePlateNumber.Enabled = enabled;
            cmbxVehicleVehicleType.Enabled = enabled;
        }
        private void EnableVehicleTypeFields(bool enabled)
        {
            tbxVehicleTypeCode.Enabled = enabled;
            tbxVehicleTypeDescription.Enabled = enabled;
        }
        #endregion

        #region DATA HAS CHANGES
        private bool BranchHasChanges()
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
        private bool CompanyHasChanges()
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
        private bool ClassificationHasChanges()
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
        private bool MeasurementUnitHasChanges()
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
        private bool PaymentTermHasChanges()
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
        private bool SupplierHasChanges()
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
        private bool VehicleHasChanges()
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
        private bool VehicleTypeHasChanges()
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
        private void CheckBranchChanges()
        {
            if (activeBranch != null)
            {
                if (BranchHasChanges())
                {
                    if (Ask("Changes in branch details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SaveBranch();
                    else activeBranch = null;
                }
                else activeBranch = null;
            }
            DisplayBranch();
            EnableBranchFields(false);
        }
        private void CheckCompanyChanges()
        {
            if (activeCompany != null)
            {
                if (CompanyHasChanges())
                {
                    if (Ask("Changes in company details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SaveCompany();
                    else activeCompany = null;
                }
                else activeCompany = null;
            }
            DisplayCompany();
            EnableCompanyFields(false);
        }
        private void CheckClassificationChanges()
        {
            if (activeClassification != null)
            {
                if (ClassificationHasChanges())
                {
                    if (Ask("Changes in classification details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SaveClassification();
                    activeClassification = null;
                }
                activeClassification = null;
            }
            DisplayClassification();
            EnableClassificationFields(false);
        }
        private void CheckMeasurementUnitChanges()
        {
            if (activeMeasurementUnit != null)
            {
                if (MeasurementUnitHasChanges())
                {
                    if (Ask("Changes in measurement unit details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SaveMeasurementUnit();
                    else activeMeasurementUnit = null;
                }
                else activeMeasurementUnit = null;
            }
            DisplayMeasurementUnit();
            EnableMeasurementUnitFields(false);
        }
        private void CheckPaymentTermChanges()
        {
            if (activePaymentTerm != null)
            {
                if (PaymentTermHasChanges())
                {
                    if (Ask("Changes in payment term details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SavePaymentTerm();
                    else activePaymentTerm = null;
                }
                else activePaymentTerm = null;
            }
            DisplayPaymentTerm();
            EnablePaymentTermFields(false);
        }
        private void CheckSupplierChanges()
        {
            if (activeSupplier != null)
            {
                if (SupplierHasChanges())
                {
                    if (Ask("Changes in supplier details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SaveSupplier();
                    else activeSupplier = null;
                }
                else activeSupplier = null;
            }
            DisplaySupplier();
            EnableSupplierFields(false);
        }
        private void CheckVehicleChanges()
        {
            if (activeVehicle != null)
            {
                if (VehicleHasChanges())
                {
                    if (Ask("Changes in vehicle details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SaveVehicle();
                    else activeVehicle = null;
                }
                else activeVehicle = null;
            }
            DisplayVehicle();
            EnableVehicleFields(false);
        }
        private void CheckVehicleTypeChanges()
        {
            if (activeVehicleType != null)
            {
                if (VehicleTypeHasChanges())
                {
                    if (Ask("Changes in vehicle type details has been detected, do you want to save this first?") == DialogResult.Yes)
                        SaveVehicleType();
                    else activeVehicleType = null;
                }
                else activeVehicleType = null;
            }
            DisplayVehicleType();
            EnableVehicleTypeFields(false);
        }
        #endregion

        #region INSERT ACTIVE DATA TO DISPLAY
        private void InsertActiveBranch()
        {
            if (idxBranch < 0) idxBranch = dgvBranches.Rows.Count - 1;
            dgvBranches.Rows.Insert(idxBranch, activeBranch, activeBranch.Code);
            activeBranch = null;
            rowBranch = null;
            idxBranch = -1;
            DisplayBranch();
            EnableBranchFields(false);
        }
        private void InsertActiveCompany()
        {
            if (idxCompany < 0) idxCompany = dgvCompanies.Rows.Count - 1;
            dgvCompanies.Rows.Insert(idxCompany, activeCompany, activeCompany.Code);
            activeCompany = null;
            rowCompany = null;
            idxCompany = -1;
            DisplayCompany();
            EnableCompanyFields(false);
        }
        private void InsertActiveClassification()
        {
            if (idxClassification < 0) idxClassification = dgvClassifications.Rows.Count - 1;
            dgvClassifications.Rows.Insert(idxClassification, activeClassification, activeClassification.Code, activeClassification.MeasurementUnit);
            activeClassification = null;
            rowClassification = null;
            idxClassification = -1;
            DisplayClassification();
            EnableClassificationFields(false);
        }
        private void InsertActiveMeasurementUnit()
        {
            if (idxMeasurementUnit < 0) idxMeasurementUnit = dgvMeasurementUnits.Rows.Count - 1;
            dgvMeasurementUnits.Rows.Insert(idxMeasurementUnit, activeMeasurementUnit, activeMeasurementUnit.Symbol);
            activeMeasurementUnit = null;
            rowMeasurementUnit = null;
            idxMeasurementUnit = -1;
            DisplayMeasurementUnit();
            EnableMeasurementUnitFields(false);
        }
        private void InsertActivePaymentTerm()
        {
            if (idxPaymentTerm < 0) idxPaymentTerm = dgvPaymentTerms.Rows.Count - 1;
            dgvPaymentTerms.Rows.Insert(idxPaymentTerm, activePaymentTerm, activePaymentTerm.DayCount);
            activePaymentTerm = null;
            rowPaymentTerm = null;
            idxPaymentTerm = -1;
            DisplayPaymentTerm();
            EnablePaymentTermFields(false);
        }
        private void InsertActiveSupplier()
        {
            if (idxSupplier < 0) idxSupplier = dgvSuppliers.Rows.Count - 1;
            dgvSuppliers.Rows.Insert(idxSupplier, activeSupplier, activeSupplier.Code, activeSupplier.Address, activeSupplier.ContactNumber);
            activeSupplier = null;
            rowSupplier = null;
            idxSupplier = -1;
            DisplaySupplier();
            EnableSupplierFields(false);
        }
        private void InsertActiveVehicle()
        {
            if (idxVehicle < 0) idxVehicle = dgvVehicles.Rows.Count - 1;
            dgvVehicles.Rows.Insert(idxVehicle, activeVehicle, activeVehicle.Type);
            activeVehicle = null;
            rowVehicle = null;
            idxVehicle = -1;
            DisplayVehicle();
            EnableVehicleFields(false);
        }
        private void InsertActiveVehicleType()
        {
            if (idxVehicleType < 0) idxVehicleType = dgvVehicleTypes.Rows.Count - 1;
            dgvVehicleTypes.Rows.Insert(idxVehicleType, activeVehicleType, activeVehicleType.Code);
            activeVehicleType = null;
            rowVehicleType = null;
            idxVehicleType = -1;
            DisplayVehicleType();
            EnableVehicleTypeFields(false);
        }
        #endregion

        #region DATA VALIDATION
        private bool BranchValidation()
        {
            var code = tbxBranchCode.Text.Trim();
            var description = tbxBranchDescription.Text.Trim();
            if (code == string.Empty)
            {
                DisplayError("Branch code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                DisplayError("Branch name must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvBranches.Rows)
            {
                if (item.Index != idxBranch)
                {
                    var branch = (Branch)item.Cells[colBranch.Name].Value;
                    if (code == branch.Code)
                    {
                        DisplayError("Branch Code already in use!");
                        return false;
                    }
                    if (description == branch.Description)
                    {
                        DisplayError("Branch name already exists!");
                        return false;
                    }
                }
            }
            return true;
        }
        private bool CompanyValidation()
        {
            var code = tbxCompanyCode.Text.Trim();
            var description = tbxCompanyDescription.Text.Trim();
            if (code == string.Empty)
            {
                DisplayError("Company code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                DisplayError("Company description must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvCompanies.Rows)
            {
                if (item.Index != idxCompany)
                {
                    var company = (Company)item.Cells[colCompany.Name].Value;
                    if (code == company.Code)
                    {
                        DisplayError("Company code already in use!");
                        return false;
                    }
                    if (description == company.Description)
                    {
                        DisplayError("Company name already exists!");
                        return false;
                    }
                }
            }
            return true;
        }
        private bool ClassificationValidation()
        {
            var code = tbxClassificationCode.Text.Trim();
            var description = tbxClassificationDescription.Text.Trim();
            var measurementUnit = (MeasurementUnit)cmbxClassificationMeasurementUnit.SelectedItem;
            if (code == string.Empty)
            {
                DisplayError("Classification code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                DisplayError("Classification name must be valid!");
                return false;
            }
            if (measurementUnit == null)
            {
                DisplayError("Measurement unit for classification must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvClassifications.Rows)
            {
                if (item.Index != idxClassification)
                {
                    var classification = (Classification)item.Cells[colClassification.Name].Value;
                    if (code == classification.Code)
                    {
                        DisplayError("Classification code already in use!");
                        return false;
                    }
                    if (description == classification.Description)
                    {
                        DisplayError("Classification name already exists!");
                        return false;
                    }
                }
            }
            return true;
        }
        private bool MeasurementUnitValidation()
        {
            var description = tbxMeasurementUnitDescription.Text.Trim();
            var symbol = tbxMeasurementUnitSymbol.Text.Trim();
            if (description == string.Empty)
            {
                DisplayError("Measurement unit name must be valid!");
                return false;
            }
            if (symbol == string.Empty)
            {
                DisplayError("Measurement unit symbol must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvMeasurementUnits.Rows)
            {
                if (item.Index != idxMeasurementUnit)
                {
                    var measurementUnit = (MeasurementUnit)item.Cells[colMeasurementUnit.Name].Value;
                    if (description == measurementUnit.Description)
                    {
                        DisplayError("Measurement unit name already exists!");
                        return false;
                    }
                    if (symbol == measurementUnit.Symbol)
                    {
                        DisplayError("Measurement unit symbol already in use!");
                        return false;
                    }
                }
            }
            return true;
        }
        private bool PaymentTermValidation()
        {
            var description = tbxPaymentTermDescription.Text.Trim();
            var dayCount = (uint)nudPaymentTermDayCount.Value;
            if (description == string.Empty)
            {
                DisplayError("Payment term name must be valid!");
                return false;
            }
            //if (dayCount == 0)
            //{
            //    displayError("Count of days must not be zero!");
            //    return false;
            //}
            foreach (DataGridViewRow item in dgvPaymentTerms.Rows)
            {
                if (item.Index != idxPaymentTerm)
                {
                    var paymentTerm = (PaymentTerm)item.Cells[colPaymentTerm.Name].Value;
                    if (description == paymentTerm.Description)
                    {
                        DisplayError("Payment term name already exists!");
                        return false;
                    }
                    //if (dayCount == paymentTerm.DayCount)
                    //{
                    //    displayError("Count of days already exists!");
                    //    return false;
                    //}
                }
            }
            return true;
        }
        private bool SupplierValidation()
        {
            var description = tbxSupplierDescription.Text.Trim();
            var code = tbxSupplierCode.Text.Trim();
            if (description == string.Empty)
            {
                DisplayError("Supplier name must be valid!");
                return false;
            }
            if (code == string.Empty)
            {
                DisplayError("Supplier code must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvSuppliers.Rows)
            {
                if (item.Index != idxSupplier)
                {
                    var supplier = (Supplier)item.Cells[colSupplier.Name].Value;
                    if (description == supplier.Description)
                    {
                        DisplayError("Supplier name already exists!");
                        return false;
                    }
                    if (code == supplier.Code)
                    {
                        DisplayError("Supplier code already in use!");
                        return false;
                    }
                }
            }
            return true;
        }
        private bool VehicleValidation()
        {
            var physicalNumber = tbxVehiclePhysicalNumber.Text.Trim();
            var plateNumber = tbxVehiclePlateNumber.Text.Trim();
            if (physicalNumber == string.Empty)
            {
                DisplayError("Vehicle's physical no. must be valid!");
                return false;
            }
            if (plateNumber == string.Empty)
            {
                DisplayError("Vehicle's plate no. must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvVehicles.Rows)
            {
                if (item.Index != idxVehicle)
                {
                    var vehicle = (Vehicle)item.Cells[colVehicle.Name].Value;
                    if (plateNumber == vehicle.PlateNumber)
                    {
                        DisplayError("Plate no. already in use!");
                        return false;
                    }
                }
            }
            return true;
        }
        private bool VehicleTypeValidation()
        {
            var code = tbxVehicleTypeCode.Text.Trim();
            var description = tbxVehicleTypeDescription.Text.Trim();
            if (code == string.Empty)
            {
                DisplayError("Vehicle type code must be valid!");
                return false;
            }
            if (description == string.Empty)
            {
                DisplayError("Vehicle type name must be valid!");
                return false;
            }
            foreach (DataGridViewRow item in dgvVehicleTypes.Rows)
            {
                if (item.Index != idxVehicleType)
                {
                    var vehicleType = (VehicleType)item.Cells[colVehicleType.Name].Value;
                    if (code == vehicleType.Code)
                    {
                        DisplayError("Code already in use!");
                        return false;
                    }
                    if (description == vehicleType.Description)
                    {
                        DisplayError("Vehicle type name already exists!");
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region SAVE DATA
        private void SaveBranch()
        {
            if (BranchValidation())
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
                    if (BranchHasChanges())
                    {
                        activeBranch.Code = code;
                        activeBranch.Description = description;
                        branchManager.Update(activeBranch);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        private void SaveCompany()
        {
            if (CompanyValidation())
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
                    if (CompanyHasChanges())
                    {
                        activeCompany.Code = code;
                        activeCompany.Description = description;
                        companyManager.Update(activeCompany);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        private void SaveClassification()
        {
            if (ClassificationValidation())
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
                    if (ClassificationHasChanges())
                    {
                        activeClassification.Code = code;
                        activeClassification.Description = description;
                        activeClassification.MeasurementUnit = measurementUnit;
                        classificationManager.Update(activeClassification);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        private void SaveMeasurementUnit()
        {
            if (MeasurementUnitValidation())
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
                    if (MeasurementUnitHasChanges())
                    {
                        activeMeasurementUnit.Description = description;
                        activeMeasurementUnit.Symbol = symbol;
                        measurementUnitManager.Update(activeMeasurementUnit);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        private void SavePaymentTerm()
        {
            if (PaymentTermValidation())
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
                    if (PaymentTermHasChanges())
                    {
                        activePaymentTerm.DayCount = dayCount;
                        activePaymentTerm.Description = description;
                        paymentTermManager.Update(activePaymentTerm);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        private void SaveSupplier()
        {
            if (SupplierValidation())
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
                    if (SupplierHasChanges())
                    {
                        activeSupplier.Address = address;
                        activeSupplier.Code = code;
                        activeSupplier.ContactNumber = contactNumber;
                        activeSupplier.Description = description;
                        supplierManager.Update(activeSupplier);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        private void SaveVehicle()
        {
            if (VehicleValidation())
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
                    if (VehicleHasChanges())
                    {
                        activeVehicle.PhysicalNumber = physicalNumber;
                        activeVehicle.PlateNumber = plateNumber;
                        activeVehicle.Type = vehicleType;
                        vehicleManager.Update(activeVehicle);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        private void SaveVehicleType()
        {
            if (VehicleTypeValidation())
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
                    if (VehicleTypeHasChanges())
                    {
                        activeVehicleType.Code = code;
                        activeVehicleType.Description = description;
                        vehicleTypeManager.Update(activeVehicleType);
                    }
                    else DisplayError("No changes detected!");
                }
            }
        }
        #endregion

        #region DATA GRID VIEW DATA SELECTION CHANGED
        private void DgvBranches_SelectionChanged(object sender, EventArgs e)
        {
            EnableBranchFields(false);
        }
        private void DgvCompanies_SelectionChanged(object sender, EventArgs e)
        {
            EnableCompanyFields(false);
        }
        private void DgvClassifications_SelectionChanged(object sender, EventArgs e)
        {
            EnableClassificationFields(false);
        }
        private void DgvMeasurementUnits_SelectionChanged(object sender, EventArgs e)
        {
            EnableMeasurementUnitFields(false);
        }
        private void DgvPaymentTerms_SelectionChanged(object sender, EventArgs e)
        {
            EnablePaymentTermFields(false);
        }
        private void DgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            EnableSupplierFields(false);
        }
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            EnableVehicleFields(false);
        }
        private void DgvVehicleTypes_SelectionChanged(object sender, EventArgs e)
        {
            EnableVehicleTypeFields(false);
        }
        #endregion

        #region BUTTON NEW DATA CLICK
        private void BtnNewBranches_Click(object sender, EventArgs e)
        {
            CheckBranchChanges();
            activeBranch = null;
            DisplayBranch();
            EnableBranchFields(true);
        }
        private void BtnNewCompany_Click(object sender, EventArgs e)
        {
            CheckCompanyChanges();
            activeCompany = null;
            DisplayCompany();
            EnableCompanyFields(true);
        }
        private void BtnNewClassification_Click(object sender, EventArgs e)
        {
            CheckClassificationChanges();
            activeClassification = null;
            DisplayClassification();
            EnableClassificationFields(true);
        }
        private void BtnNewMeasurementUnit_Click(object sender, EventArgs e)
        {
            CheckMeasurementUnitChanges();
            activeMeasurementUnit = null;
            DisplayMeasurementUnit();
            EnableMeasurementUnitFields(true);
        }
        private void BtnNewSupplier_Click(object sender, EventArgs e)
        {
            CheckSupplierChanges();
            activeSupplier = null;
            DisplaySupplier();
            EnableSupplierFields(true);
        }
        private void BtnNewVehicle_Click(object sender, EventArgs e)
        {
            CheckVehicleChanges();
            activeVehicle = null;
            DisplayVehicle();
            EnableVehicleFields(true);
        }
        private void BtnNewVehicleType_Click(object sender, EventArgs e)
        {
            CheckVehicleTypeChanges();
            activeVehicleType = null;
            DisplayVehicleType();
            EnableVehicleTypeFields(true);
        }
        private void BtnNewPaymentTerm_Click(object sender, EventArgs e)
        {
            CheckPaymentTermChanges();
            activePaymentTerm = null;
            DisplayPaymentTerm();
            EnablePaymentTermFields(true);
        }
        #endregion

        #region BUTTON EDIT DATA CLICK
        private void BtnEditBranch_Click(object sender, EventArgs e)
        {
            if (dgvBranches.SelectedRows.Count == 1)
            {
                CheckBranchChanges();
                rowBranch = dgvBranches.SelectedRows[0];
                idxBranch = rowBranch.Index;
                activeBranch = (Branch)rowBranch.Cells[colBranch.Name].Value;
                DisplayBranch();
                EnableBranchFields(true);
            }
        }
        private void BtnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvCompanies.SelectedRows.Count == 1)
            {
                CheckCompanyChanges();
                rowCompany = dgvCompanies.SelectedRows[0];
                idxCompany = rowCompany.Index;
                activeCompany = (Company)rowCompany.Cells[colCompany.Name].Value;
                DisplayCompany();
                EnableCompanyFields(true);
            }
        }
        private void BtnEditClassification_Click(object sender, EventArgs e)
        {
            if (dgvClassifications.SelectedRows.Count == 1)
            {
                CheckClassificationChanges();
                rowClassification = dgvClassifications.SelectedRows[0];
                idxClassification = rowClassification.Index;
                activeClassification = (Classification)rowClassification.Cells[colClassification.Name].Value;
                DisplayClassification();
                EnableClassificationFields(true);
            }
        }
        private void BtnEditMeasurementUnit_Click(object sender, EventArgs e)
        {
            if (dgvMeasurementUnits.SelectedRows.Count == 1)
            {
                CheckMeasurementUnitChanges();
                rowMeasurementUnit = dgvMeasurementUnits.SelectedRows[0];
                idxMeasurementUnit = rowMeasurementUnit.Index;
                activeMeasurementUnit = (MeasurementUnit)rowMeasurementUnit.Cells[colMeasurementUnit.Name].Value;
                DisplayMeasurementUnit();
                EnableMeasurementUnitFields(true);
            }
        }
        private void BtnEditSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 1)
            {
                CheckSupplierChanges();
                rowSupplier = dgvSuppliers.SelectedRows[0];
                idxSupplier = rowSupplier.Index;
                activeSupplier = (Supplier)rowSupplier.Cells[colSupplier.Name].Value;
                DisplaySupplier();
                EnableSupplierFields(true);
            }
        }
        private void BtnEditVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 1)
            {
                CheckVehicleChanges();
                rowVehicle = dgvVehicles.SelectedRows[0];
                idxVehicle = rowVehicle.Index;
                activeVehicle = (Vehicle)rowVehicle.Cells[colVehicle.Name].Value;
                DisplayVehicle();
                EnableVehicleFields(true);
            }
        }
        private void BtnEditVehicleType_Click(object sender, EventArgs e)
        {
            if (dgvVehicleTypes.SelectedRows.Count == 1)
            {
                CheckVehicleTypeChanges();
                rowVehicleType = dgvVehicleTypes.SelectedRows[0];
                idxVehicleType = rowVehicleType.Index;
                activeVehicleType = (VehicleType)rowVehicleType.Cells[colVehicleType.Name].Value;
                DisplayVehicleType();
                EnableVehicleTypeFields(true);
            }
        }
        private void BtnEditPaymentTerm_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTerms.SelectedRows.Count == 1)
            {
                CheckPaymentTermChanges();
                rowPaymentTerm = dgvPaymentTerms.SelectedRows[0];
                idxPaymentTerm = rowPaymentTerm.Index;
                activePaymentTerm = (PaymentTerm)rowPaymentTerm.Cells[colPaymentTerm.Name].Value;
                DisplayPaymentTerm();
                EnablePaymentTermFields(true);
            }
        }
        #endregion

        #region BUTTON CANCEL DATA CLICK
        private void BtnCancelBranch_Click(object sender, EventArgs e)
        {
            CheckBranchChanges();
        }
        private void BtnCancelCompany_Click(object sender, EventArgs e)
        {
            CheckCompanyChanges();
        }
        private void BtnCancelClassification_Click(object sender, EventArgs e)
        {
            CheckClassificationChanges();
        }
        private void BtnCancelMeasurementUnit_Click(object sender, EventArgs e)
        {
            CheckMeasurementUnitChanges();
        }
        private void BtnCancelSupplier_Click(object sender, EventArgs e)
        {
            CheckSupplierChanges();
        }
        private void BtnCancelVehicle_Click(object sender, EventArgs e)
        {
            CheckVehicleChanges();
        }
        private void BtnCancelVehicleType_Click(object sender, EventArgs e)
        {
            CheckVehicleTypeChanges();
        }
        private void BtnCancelPaymentTerm_Click(object sender, EventArgs e)
        {
            CheckPaymentTermChanges();
        }
        #endregion

        #region BUTTON SAVE DATA CLICK
        private void BtnSaveBranch_Click(object sender, EventArgs e)
        {
            SaveBranch();
        }
        private void BtnSaveCompany_Click(object sender, EventArgs e)
        {
            SaveCompany();
        }
        private void BtnSaveClassification_Click(object sender, EventArgs e)
        {
            SaveClassification();
        }
        private void BtnSaveMeasurementUnit_Click(object sender, EventArgs e)
        {
            SaveMeasurementUnit();
        }
        private void BtnSaveSupplier_Click(object sender, EventArgs e)
        {
            SaveSupplier();
        }
        private void BtnSaveVehicle_Click(object sender, EventArgs e)
        {
            SaveVehicle();
        }
        private void BtnSaveVehicleType_Click(object sender, EventArgs e)
        {
            SaveVehicleType();
        }
        private void BtnSavePaymentTerm_Click(object sender, EventArgs e)
        {
            SavePaymentTerm();
        }
        #endregion

        #region BUTTON REMOVE DATA CLICK
        private void BtnRemoveBranch_Click(object sender, EventArgs e)
        {
            if (dgvBranches.SelectedRows.Count == 1)
            {
                CheckBranchChanges();
                rowBranch = dgvBranches.SelectedRows[0];
                idxBranch = rowBranch.Index;
                activeBranch = (Branch)rowBranch.Cells[colBranch.Name].Value;
                if (Ask($"Are you sure, you want to remove {activeBranch} branch?") == DialogResult.Yes)
                {
                    branchManager.Remove(activeBranch);
                }
                activeBranch = null;
            }

        }
        private void BtnRemoveCompany_Click(object sender, EventArgs e)
        {
            if (dgvCompanies.SelectedRows.Count == 1)
            {
                CheckCompanyChanges();
                rowCompany = dgvCompanies.SelectedRows[0];
                idxCompany = rowCompany.Index;
                activeCompany = (Company)rowCompany.Cells[colCompany.Name].Value;
                if (Ask($"Are you sure, you want to remove {activeCompany}?") == DialogResult.Yes)
                {
                    companyManager.Remove(activeCompany);
                }
                activeCompany = null;
            }
        }
        private void BtnRemoveClassification_Click(object sender, EventArgs e)
        {
            if (dgvClassifications.SelectedRows.Count == 1)
            {
                CheckClassificationChanges();
                rowClassification = dgvClassifications.SelectedRows[0];
                idxClassification = rowClassification.Index;
                activeClassification = (Classification)rowClassification.Cells[colClassification.Name].Value;
                if (Ask($"Are you sure, you want to remove {activeClassification}?") == DialogResult.Yes)
                {
                    classificationManager.Remove(activeClassification);
                }
                activeClassification = null;
            }
        }
        private void BtnRemoveMeasurementUnit_Click(object sender, EventArgs e)
        {
            if (dgvMeasurementUnits.SelectedRows.Count == 1)
            {
                CheckMeasurementUnitChanges();
                rowMeasurementUnit = dgvMeasurementUnits.SelectedRows[0];
                idxMeasurementUnit = rowMeasurementUnit.Index;
                activeMeasurementUnit = (MeasurementUnit)rowMeasurementUnit.Cells[colMeasurementUnit.Name].Value;
                if (Ask($"Are you sure, you want to remove {activeMeasurementUnit}?") == DialogResult.Yes)
                {
                    measurementUnitManager.Remove(activeMeasurementUnit);
                }
                activeMeasurementUnit = null;
            }
        }
        private void BtnRemoveSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count == 1)
            {
                CheckSupplierChanges();
                rowSupplier = dgvSuppliers.SelectedRows[0];
                idxSupplier = rowSupplier.Index;
                activeSupplier = (Supplier)rowSupplier.Cells[colSupplier.Name].Value;
                if (Ask($"Are you sure, you want to remove {activeSupplier}?") == DialogResult.Yes)
                {
                    supplierManager.Remove(activeSupplier);
                }
                activeSupplier = null;
            }
        }
        private void BtnRemoveVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 1)
            {
                CheckVehicleChanges();
                rowVehicle = dgvVehicles.SelectedRows[0];
                idxVehicle = rowVehicle.Index;
                activeVehicle = (Vehicle)rowVehicle.Cells[colVehicle.Name].Value;
                if (Ask($"Are you sure, you want to remove {activeVehicle}?") == DialogResult.Yes)
                {
                    vehicleManager.Remove(activeVehicle);
                }
                activeVehicle = null;
            }
        }
        private void BtnRemoveVehicleType_Click(object sender, EventArgs e)
        {
            if (dgvVehicleTypes.SelectedRows.Count == 1)
            {
                CheckVehicleTypeChanges();
                rowVehicleType = dgvVehicleTypes.SelectedRows[0];
                idxVehicleType = rowVehicleType.Index;
                activeVehicleType = (VehicleType)rowVehicleType.Cells[colVehicleType.Name].Value;
                if (Ask($"Are you sure, you want to remove {activeVehicleType}?") == DialogResult.Yes)
                {
                    vehicleTypeManager.Remove(activeVehicleType);
                }
                activeVehicleType = null;
            }
        }
        private void BtnRemovePaymentTerm_Click(object sender, EventArgs e)
        {
            if (dgvPaymentTerms.SelectedRows.Count == 1)
            {
                CheckPaymentTermChanges();
                rowPaymentTerm = dgvPaymentTerms.SelectedRows[0];
                idxPaymentTerm = rowPaymentTerm.Index;
                activePaymentTerm = (PaymentTerm)rowPaymentTerm.Cells[colPaymentTerm.Name].Value;
                if (Ask($"Are you sure, you want to remove {activePaymentTerm}?") == DialogResult.Yes)
                {
                    paymentTermManager.Remove(activePaymentTerm);
                }
                activePaymentTerm = null;
            }
        }

        #endregion

        private void BtnUserSettings_Click(object sender, EventArgs e)
        {
            UserSettingsForm form = new UserSettingsForm();
            form.ShowDialog();
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

        private void TpVehicles_Click(object sender, EventArgs e)
        {

        }
    }
}