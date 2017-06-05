using Citicon.Data;
using Citicon.Forms.Dialogs;
using System;
using System.Windows.Forms;

namespace Citicon.Forms.Controls
{
    public partial class AddEditEmployeeControl : UserControl
    {
        public AddEditEmployeeControl()
        {
            InitializeComponent();
        }

        private Employee _Employee;

        public Employee Employee
        {
            get { return _Employee; }
            set
            {
                _Employee = value;
                UpdateUI(value);
            }
        }

        public DataDialogMode Mode { get; set; }

        public event EventHandler FormCancelRequested;

        private void UpdateUI(Employee employee)
        {
            LastNameTextBox.Text = employee?.LastName;
            FirstNameTextBox.Text = employee?.FirstName;
            MiddleNameTextBox.Text = employee?.MiddleName;
            BirthDateTimePicker.Value = employee?.BirthDate ?? DateTime.Now;
            CivilStatusComboBox.SelectedItem = employee?.CivilStatus ?? CivilStatus.Single;
            TinTextBox.Text = employee?.TIN;
            PositionComboBox.SelectedItem = employee?.Position;
            EmploymentDateTimePicker.Value = employee?.EmploymentDate ?? DateTime.Now;
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
            R1ADateTimePicker.Value = employee?.R1ADate ?? DateTime.Now;
            PagIbigTextBox.Text = employee?.PagIbigNumber;
            PhilHealthNumberTextBox.Text = employee?.PhilHealthNumber;
            PhilHealthRegistrationDateTimePicker.Value = employee?.PhilHealthRegistrationDate ?? DateTime.Now;
            PagIbigRtnTextBox.Text = employee?.PagIbigRTN;
            PagIbigRtnRegistrationDateTimePicker.Value = employee?.PagIbigRTNRegistrationDate ?? DateTime.Now;
            PagIbigRtnDependentNumberNumericUpDown.Value = employee?.PagIbigRTNDependentNumber ?? 0;
            VacationLeaveNumericUpDown.Value = employee?.VacationLeave ?? 0;
            SickLeaveNumericUpDown.Value = employee?.SickLeave ?? 0;
            AbsencesNumericUpDown.Value = employee?.Absences ?? 0;
            BasicPayNumericUpDown.Value = employee?.BasicPay ?? 0;
            DailyRateNumericUpDown.Value = employee?.DailyRate ?? 0;
            AllowanceNumericUpDown.Value = employee?.Allowance ?? 0;
            OtAllowanceNumericUpDown.Value = employee?.OTAllowance ?? 0;
            SssDeductionNumericUpDown.Value = employee?.SSSDeduction ?? 0;
            SssErDeductionNumericUpDown.Value = employee?.SSSERDeduction ?? 0;
            SssEcDeductionNumericUpDown.Value = employee?.SSSECDeduction ?? 0;
            WithHoldingTaxNumericUpDown.Value = employee?.WithHoldingTax ?? 0;
            PagIbigDeductionNumericUpDown.Value = employee?.PagIbigDeduction ?? 0;
            PhilHealthDeductionNumericUpDown.Value = employee?.PhilHealthDeduction ?? 0;
        }

        private void CancelFormButton_Click(object sender, EventArgs e)
        {
            FormCancelRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
