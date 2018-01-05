﻿using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.Dialogs;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms.Controls
{
    public partial class AddEditEmployeeControl : UserControl
    {
        public AddEditEmployeeControl()
        {
            InitializeComponent();
            BranchManager = new BranchManager();
            CompanyManager = new CompanyManager();
        }

        private BranchManager BranchManager;
        private CompanyManager CompanyManager;

        private Employee _Employee;
        private EmployeePayrollAddition _EmployeePayrollAddition;
        private EmployeePayrollDeduction _EmployeePayrollDeduction;

        public Employee Employee
        {
            get { return _Employee; }
            set
            {
                _Employee = value;
                UpdateUI(value);
            }
        }

        public EmployeePayrollAddition EmployeePayrollAddition
        {
            get { return _EmployeePayrollAddition; }
            set
            {
                _EmployeePayrollAddition = value;
                UpdateUI(value);
            }
        }

        public EmployeePayrollDeduction EmployeePayrollDeduction
        {
            get { return _EmployeePayrollDeduction; }
            set
            {
                _EmployeePayrollDeduction = value;
                UpdateUI(value);
            }
        }

        public DataDialogMode Mode { get; set; }

        public event EventHandler FormCancelRequested;

        private void SetDateTime(DateTime value, DateTimePicker target)
        {
            if (value >= target.MinDate && value <= target.MaxDate)
            {
                target.Value = value;
            }
            else
            {
                target.Value = DateTime.Now;
            }
        }

        private void SetDateTime(DateTime? value, DateTimePicker target)
        {
            if (value >= target.MinDate && value <= target.MaxDate)
            {
                target.Value = value ?? DateTime.Now;
            }
            else
            {
                target.Value = DateTime.Now;
            }
        }

        private void UpdateUI(Employee employee)
        {
            LastNameTextBox.Text = employee?.LastName;
            FirstNameTextBox.Text = employee?.FirstName;
            MiddleNameTextBox.Text = employee?.MiddleName;
            SetDateTime(employee?.BirthDate, BirthDateTimePicker);
            CivilStatusComboBox.SelectedItem = employee?.CivilStatus ?? CivilStatus.Single;
            TinTextBox.Text = employee?.TIN;
            PositionComboBox.SelectedItem = employee?.Position;
            SetDateTime(employee?.EmploymentDate, EmploymentDateTimePicker);
            EmploymentStatusComboBox.SelectedItem = employee?.EmploymentStatus;
            BranchComboBox.SelectedItem = employee?.Branch;
            CompanyComboBox.SelectedItem = employee?.Company;
            PayrollTypeComboBox.SelectedItem = employee?.PayrollType;
            AddressTextBox.Text = employee?.Address;
            TelephoneNumberTextBox.Text = employee?.TelephoneNumber;
            MobileNumberTextBox.Text = employee?.MobileNumber;
            EmailAddressTextBox.Text = employee?.EmailAddress;
            EmergencyContactPersonTextBox.Text = employee?.EmergencyContactPerson;
            EmergencyContactPersonNumberTextBox.Text = employee?.EmergencyContactPersonNumber;
            SssNumberTextBox.Text = employee?.SSSNumber;
            SetDateTime(employee?.R1ADate, R1ADateTimePicker);
            PagIbigTextBox.Text = employee?.PagIbigNumber;
            PhilHealthNumberTextBox.Text = employee?.PhilHealthNumber;
            SetDateTime(employee?.PhilHealthRegistrationDate, PhilHealthRegistrationDateTimePicker);
            PagIbigRtnTextBox.Text = employee?.PagIbigRTN;
            SetDateTime(employee?.PagIbigRegistrationDate, PagIbigRtnRegistrationDateTimePicker);
            PagIbigRtnDependentNumberNumericUpDown.Value = employee?.PagIbigRTNDependentNumber ?? 0;
            VacationLeaveNumericUpDown.Value = employee?.VacationLeave ?? 0;
            SickLeaveNumericUpDown.Value = employee?.SickLeave ?? 0;
            AbsencesNumericUpDown.Value = employee?.Absences ?? 0;
        }

        private void UpdateUI(EmployeePayrollAddition payrollAddition)
        {
            BasicPayNumericUpDown.Value = 0;
            DailyRateNumericUpDown.Value = 0;
            AllowanceNumericUpDown.Value = 0;
            OtAllowanceNumericUpDown.Value = 0;

            if (payrollAddition != null)
            {
                BasicPayNumericUpDown.Value = payrollAddition.BasicPay;
                DailyRateNumericUpDown.Value = payrollAddition.DailyRate;
                AllowanceNumericUpDown.Value = payrollAddition.Allowance;
                OtAllowanceNumericUpDown.Value = payrollAddition.OvertimeAllowance;
            }
        }

        private void UpdateUI(EmployeePayrollDeduction payrollDeduction)
        {
            SssDeductionNumericUpDown.Value = 0;
            SssErDeductionNumericUpDown.Value = 0;
            SssEcDeductionNumericUpDown.Value = 0;
            WithHoldingTaxNumericUpDown.Value = 0;
            PagIbigDeductionNumericUpDown.Value = 0;
            PhilHealthDeductionNumericUpDown.Value = 0;

            if (payrollDeduction != null)
            {
                SssDeductionNumericUpDown.Value = payrollDeduction.Sss;
                SssEcDeductionNumericUpDown.Value = payrollDeduction.SssEc;
                SssErDeductionNumericUpDown.Value = payrollDeduction.SssEr;
                WithHoldingTaxNumericUpDown.Value = payrollDeduction.WithholdingTax;
                PagIbigDeductionNumericUpDown.Value = payrollDeduction.PagibigLoan;
                PhilHealthDeductionNumericUpDown.Value = payrollDeduction.PhilHealth;
            }
        }

        private void RequestFormCancel()
        {
            FormCancelRequested?.Invoke(this, EventArgs.Empty);
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            RequestFormCancel();
        }

        private async Task InsertAsync()
        {
            try
            {
                if (await EmployeeManager.EmployeeExistsAsync(Employee.FirstName, Employee.MiddleName, Employee.LastName))
                {
                    MessageBox.Show("Employee already exists!");
                }
                else
                {
                    await EmployeeManager.InsertFullDetailsAsync(Employee, EmployeePayrollAddition, EmployeePayrollDeduction);
                    MessageBox.Show("Employee has been saved successfully!");
                    RequestFormCancel();
                }
            }
            catch (Exception ex)
            {
                HandleException("Failed to add employee.", ex);
            }
        }

        private async Task UpdateAsync()
        {
            try
            {
                await EmployeeManager.UpdateFullDetailsAsync(Employee, EmployeePayrollAddition, EmployeePayrollDeduction);
                MessageBox.Show("Employee's information has been saved successfully!");
                RequestFormCancel();
            }
            catch (Exception ex)
            {
                HandleException("Failed to edit employee's information.", ex);
            }
        }

        private void HandleException(Exception exception)
        {
            MessageBox.Show(exception.Message);
        }

        private void HandleException(string message, Exception exception)
        {
            MessageBox.Show($"{message}{Environment.NewLine}{exception.Message}");
        }

        private void PrepareData()
        {
            Employee.Absences = AbsencesNumericUpDown.Value;
            Employee.Address = AddressTextBox.Text;
            Employee.BirthDate = BirthDateTimePicker.Value;
            Employee.Branch = BranchComboBox.SelectedItem as Branch;
            Employee.CivilStatus = (CivilStatus)CivilStatusComboBox.SelectedItem;
            Employee.Company = CompanyComboBox.SelectedItem as Company;
            Employee.EmailAddress = EmailAddressTextBox.Text;
            Employee.EmergencyContactPerson = EmergencyContactPersonTextBox.Text;
            Employee.EmergencyContactPersonNumber = EmergencyContactPersonNumberTextBox.Text;
            Employee.EmploymentDate = EmploymentDateTimePicker.Value;
            Employee.EmploymentStatus = (EmploymentStatus)EmploymentStatusComboBox.SelectedItem;
            Employee.FirstName = FirstNameTextBox.Text;
            Employee.JobPosition = PositionComboBox.SelectedItem as JobPosition;
            Employee.LastName = LastNameTextBox.Text;
            Employee.MiddleName = MiddleNameTextBox.Text;
            Employee.MobileNumber = MobileNumberTextBox.Text;
            Employee.PagIbigNumber = PagIbigTextBox.Text;
            Employee.PagIbigRegistrationDate = PagIbigRtnRegistrationDateTimePicker.Value;
            Employee.PagIbigRTN = PagIbigRtnTextBox.Text;
            Employee.PagIbigRTNDependentNumber = Convert.ToUInt32(PagIbigRtnDependentNumberNumericUpDown.Value);
            Employee.PayrollType = (PayrollType)PayrollTypeComboBox.SelectedItem;
            Employee.PhilHealthNumber = PhilHealthNumberTextBox.Text;
            Employee.PhilHealthRegistrationDate = PhilHealthRegistrationDateTimePicker.Value;
            Employee.Position = PositionComboBox.SelectedItem as JobPosition;
            Employee.R1ADate = R1ADateTimePicker.Value;
            Employee.SickLeave = SickLeaveNumericUpDown.Value;
            Employee.SSSNumber = SssNumberTextBox.Text;
            Employee.TelephoneNumber = TelephoneNumberTextBox.Text;
            Employee.TIN = TinTextBox.Text;
            Employee.VacationLeave = VacationLeaveNumericUpDown.Value;
            EmployeePayrollAddition.BasicPay = BasicPayNumericUpDown.Value;
            EmployeePayrollAddition.DailyRate = DailyRateNumericUpDown.Value;
            EmployeePayrollAddition.Allowance = AllowanceNumericUpDown.Value;
            EmployeePayrollAddition.OvertimeAllowance = OtAllowanceNumericUpDown.Value;
            EmployeePayrollDeduction.Sss = SssDeductionNumericUpDown.Value;
            EmployeePayrollDeduction.SssEc = SssEcDeductionNumericUpDown.Value;
            EmployeePayrollDeduction.SssEr = SssErDeductionNumericUpDown.Value;
            EmployeePayrollDeduction.PagibigLoan = PagIbigDeductionNumericUpDown.Value;
            EmployeePayrollDeduction.PhilHealth = PhilHealthDeductionNumericUpDown.Value;
            EmployeePayrollDeduction.WithholdingTax = WithHoldingTaxNumericUpDown.Value;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            if (Employee == null)
            {
                MessageBox.Show("No employee.");
            }

            if (ValidateData())
            {
                PrepareData();

                switch (Mode)
                {
                    case DataDialogMode.None:
                        MessageBox.Show("Nothing to do.");
                        break;
                    case DataDialogMode.Add:
                        await InsertAsync();
                        break;
                    case DataDialogMode.Edit:
                        await UpdateAsync();
                        break;
                } 
            }

        }

        private bool ValidateData()
        {
            void DisplayFailedMessage(string message)
            {
                MessageBox.Show(message);
            }

            if (CivilStatusComboBox.SelectedItem == null)
            {
                DisplayFailedMessage("Invalid civil status.");
                return false;
            }

            if (EmploymentStatusComboBox.SelectedItem == null)
            {
                DisplayFailedMessage("Invalid employment status.");
                return false;
            }

            if (PayrollTypeComboBox.SelectedItem == null)
            {
                DisplayFailedMessage("Invalid payroll type.");
                return false;
            }

            return true;
        }

        private async Task LoadBranchListAsync()
        {
            BranchComboBox.Items.Clear();

            try
            {
                var branches = await BranchManager.GetListAsync();

                if (branches != null && branches.Any())
                {
                    BranchComboBox.Items.AddRange(branches);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCivilStatusList()
        {
            CivilStatusComboBox.Items.Clear();

            CivilStatusComboBox.Items.Add(CivilStatus.Single);
            CivilStatusComboBox.Items.Add(CivilStatus.Married);
            CivilStatusComboBox.Items.Add(CivilStatus.Separated);
            CivilStatusComboBox.Items.Add(CivilStatus.Widow);
        }

        private async Task LoadPositionListAsync()
        {
            PositionComboBox.Items.Clear();

            try
            {
                var positions = await JobPositionManager.GetListAsync();

                if (positions != null && positions.Any())
                {
                    PositionComboBox.Items.AddRange(positions.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadEmploymentStatusList()
        {
            EmploymentStatusComboBox.Items.Clear();

            EmploymentStatusComboBox.Items.Add(EmploymentStatus.Active);
            EmploymentStatusComboBox.Items.Add(EmploymentStatus.Resigned);
            EmploymentStatusComboBox.Items.Add(EmploymentStatus.Retired);
        }

        private async Task LoadCompanyListAsync()
        {
            CompanyComboBox.Items.Clear();

            try
            {
                var companies = await CompanyManager.GetListAsync();

                if (companies != null && companies.Any())
                {
                    CompanyComboBox.Items.AddRange(companies);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPayrollTypeList()
        {
            PayrollTypeComboBox.Items.Clear();

            PayrollTypeComboBox.Items.Add(PayrollType.SemiMonthly);
            PayrollTypeComboBox.Items.Add(PayrollType.Weekly);
            PayrollTypeComboBox.Items.Add(PayrollType.Driver);
            PayrollTypeComboBox.Items.Add(PayrollType.SubContractual);
        }

        private async void AddEditEmployeeControl_Load(object sender, EventArgs e)
        {
            LoadCivilStatusList();
            await LoadPositionListAsync();
            LoadEmploymentStatusList();
            await LoadBranchListAsync();
            await LoadCompanyListAsync();
            LoadPayrollTypeList();
            UpdateUI(Employee);
        }

        private async void AddPositionButton_Click(object sender, EventArgs e)
        {
            AddEditEmployeePositionDialog.AddEmployeePosition();
            await LoadPositionListAsync();
        }
    }
}
