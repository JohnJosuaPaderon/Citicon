using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
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
            notify("Successfully added!");
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
            displayBranch();
            enableBranchFields(false);
        }
        private void ClassificationManager_Added(Classification e)
        {
            notify("Successfully added!");
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
            displayClassification();
            enableClassificationFields(false);
        }
        private void CompanyManager_Added(Company e)
        {
            notify("Successfully added!");
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
            displayCompany();
            enableCompanyFields(false);
        }
        private void MeasurementUnitManager_Added(MeasurementUnit e)
        {
            notify("Successfully added!");
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
            displayMeasurementUnit();
            enableMeasurementUnitFields(false);
        }
        private void PaymentTermManager_Added(PaymentTerm e)
        {
            notify("Successfully added!");
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
            displayPaymentTerm();
            enablePaymentTermFields(false);
        }
        private void SupplierManager_Added(Supplier e)
        {
            notify("Successfully added!");
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
            displaySupplier();
            enableSupplierFields(false);
        }
        private void VehicleManager_Added(Vehicle e)
        {
            notify("Successfully added!");
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
            displayVehicle();
            enableVehicleFields(false);
        }
        private void VehicleTypeManager_Added(VehicleType e)
        {
            notify("Successfully added!");
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
            displayVehicleType();
            enableVehicleTypeFields(false);
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
            rowBranch.Cells[colBranch.Name].Value = e;
            rowBranch.Cells[colBranchCode.Name].Value = e.Code;
            activeBranch = null;
            displayBranch();
            enableBranchFields(false);
        }
        private void ClassificationManager_Updated(Classification e)
        {
            notify("Successfully updated!");
            rowClassification.Cells[colClassification.Name].Value = e;
            rowClassification.Cells[colClassificationCode.Name].Value = e.Code;
            rowClassification.Cells[colClassificationMeasurementUnit.Name].Value = e.MeasurementUnit;
            activeClassification = null;
            displayClassification();
            enableBranchFields(false);
        }
        private void CompanyManager_Updated(Company e)
        {
            notify("Successfully updated!");
            rowCompany.Cells[colCompany.Name].Value = e;
            rowCompany.Cells[colCompanyCode.Name].Value = e.Code;
            activeCompany = null;
            displayCompany();
            enableCompanyFields(false);
        }
        private void MeasurementUnitManager_Updated(MeasurementUnit e)
        {
            notify("Successfully updated!");
            rowMeasurementUnit.Cells[colMeasurementUnit.Name].Value = e;
            rowMeasurementUnit.Cells[colMeasurementUnitSymbol.Name].Value = e.Symbol;
            activeMeasurementUnit = null;
            displayMeasurementUnit();
            enableMeasurementUnitFields(false);
        }
        private void PaymentTermManager_Updated(PaymentTerm e)
        {
            notify("Successfully updated!");
            rowPaymentTerm.Cells[colPaymentTerm.Name].Value = e;
            rowPaymentTerm.Cells[colPaymentTermDayCount.Name].Value = e.DayCount;
            activePaymentTerm = null;
            displayPaymentTerm();
            enablePaymentTermFields(false);
        }
        private void SupplierManager_Updated(Supplier e)
        {
            notify("Successfully updated!");
            rowSupplier.Cells[colSupplier.Name].Value = e;
            rowSupplier.Cells[colSupplierAddress.Name].Value = e.Address;
            rowSupplier.Cells[colSupplierCode.Name].Value = e.Code;
            rowSupplier.Cells[colSupplierContactNumber.Name].Value = e.ContactNumber;
            activeSupplier = null;
            displaySupplier();
            enableSupplierFields(false);
        }
        private void VehicleManager_Updated(Vehicle e)
        {
            notify("Successfully updated!");
            rowVehicle.Cells[colVehicle.Name].Value = e;
            rowVehicle.Cells[colVehicleVehicleType.Name].Value = e.Type;
            activeVehicle = null;
            displayVehicle();
            enableVehicleFields(false);
        }
        private void VehicleTypeManager_Updated(VehicleType e)
        {
            notify("Successfully updated!");
            rowVehicleType.Cells[colVehicleType.Name].Value = e;
            rowVehicleType.Cells[colVehicleTypeCode.Name].Value = e.Code;
            activeVehicleType = null;
            displayVehicleType();
            enableVehicleTypeFields(false);
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
            activeClassification = null;
            classifications = (await classificationManager.GetListAsync())?.ToList();
        }
        private async Task loadMeasurementUnits()
        {
            dgvMeasurementUnits.Rows.Clear();
            cmbxClassificationMeasurementUnit.Items.Clear();
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
            if (User.CurrentUser.Inventory_OutgoingStocksOnly)
            {
                btnUserSettings_Click(sender, EventArgs.Empty);
                Close();
            }
            else
            {
                await loadBranches();
                await loadCompanies();
                await loadSuppliers();
                await loadPaymentTerms();
                await loadMeasurementUnits();
                await loadVehicleTypes();
                await loadClassifications();
                await loadVehicles();
            }
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
                tbxBranchCode.Text = branchManager.GenerateCode();
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
                tbxCompanyCode.Text = companyManager.GenerateCode();
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
                tbxClassificationCode.Text = classificationManager.GenerateCode();
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
                tbxSupplierCode.Text = supplierManager.GenerateCode();
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
            else tbxVehicleTypeCode.Text = vehicleTypeManager.GenerateCode();
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
                    else activeBranch = null;
                }
                else activeBranch = null;
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
                    else activeCompany = null;
                }
                else activeCompany = null;
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
                    activeClassification = null;
                }
                activeClassification = null;
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
                    else activeMeasurementUnit = null;
                }
                else activeMeasurementUnit = null;
            }
            displayMeasurementUnit();
            enableMeasurementUnitFields(false);
        }
        private void checkPaymentTermChanges()
        {
            if (activePaymentTerm != null)
            {
                if (paymentTermHasChanges())
                {
                    if (ask("Changes in payment term details has been detected, do you want to save this first?") == DialogResult.Yes)
                        savePaymentTerm();
                    else activePaymentTerm = null;
                }
                else activePaymentTerm = null;
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
                    else activeSupplier = null;
                }
                else activeSupplier = null;
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
                    else activeVehicle = null;
                }
                else activeVehicle = null;
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
                    else activeVehicleType = null;
                }
                else activeVehicleType = null;
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
                if (item.Index != idxBranch)
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
                if (item.Index != idxCompany)
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
                if (item.Index != idxClassification)
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
                if (item.Index != idxMeasurementUnit)
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
                        displayError("Payment term name already exists!");
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
                if (item.Index != idxSupplier)
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
                if (item.Index != idxVehicle)
                {
                    var vehicle = (Vehicle)item.Cells[colVehicle.Name].Value;
                    if (plateNumber == vehicle.PlateNumber)
                    {
                        displayError("Plate no. already in use!");
                        return false;
                    }
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
                if (item.Index != idxVehicleType)
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
                        paymentTermManager.Update(activePaymentTerm);
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
                enableVehicleTypeFields(true);
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

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            UserSettingsForm form = new UserSettingsForm();
            form.ShowDialog();
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

        private void tpVehicles_Click(object sender, EventArgs e)
        {

        }
    }
}