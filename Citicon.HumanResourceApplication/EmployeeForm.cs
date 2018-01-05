using Citicon.DataManager;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Citicon.Data;
using Citicon.Forms;

namespace Citicon.HumanResourceApplication
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private const string DateFormat = "MMMM dd, yyyy";
        private const string MonetaryFormat = "#,##0.00";
        private Employee _CurrentEmployee;
        private EmployeePayrollAddition _CurrentEmployeePayrollAddition;
        private EmployeePayrollDeduction _CurrentEmployeePayrollDeduction;
        private EmployeeLogin _CurrentEmployeeLogin;

        public Employee CurrentEmployee
        {
            get { return _CurrentEmployee; }
            set
            {
                if (_CurrentEmployee != value)
                {
                    _CurrentEmployee = value;
                    UpdateUI(value);
                }
            }
        }

        public EmployeePayrollAddition CurrentEmployeePayrollAddition
        {
            get { return _CurrentEmployeePayrollAddition; }
            set
            {
                if (_CurrentEmployeePayrollAddition != value)
                {
                    _CurrentEmployeePayrollAddition = value;
                    UpdateUI(value);
                }
            }
        }

        public EmployeePayrollDeduction CurrentEmployeePayrollDeduction
        {
            get { return _CurrentEmployeePayrollDeduction; }
            set
            {
                if (_CurrentEmployeePayrollDeduction != value)
                {
                    _CurrentEmployeePayrollDeduction = value;
                    UpdateUI(value);
                }
            }
        }

        public EmployeeLogin CurrentEmployeeLogin
        {
            get { return _CurrentEmployeeLogin; }
            set
            {
                if (_CurrentEmployeeLogin != value)
                {
                    _CurrentEmployeeLogin = value;
                    UpdateUI(value);
                }
            }
        }

        private void UpdateUI(EmployeeLogin value)
        {
            LoginCodeTextBox.Text = value?.LoginCode.ToString("000000");
        }

        private void UpdateUI(Employee value)
        {
            FullNameTextBox.Text = value?.ToString();
            BirthDateTextBox.Text = value?.BirthDate.ToString(DateFormat);
            CivilStatusTextBox.Text = value?.CivilStatus.ToString();
            TinTextBox.Text = value?.TIN;
            PositionTextBox.Text = value?.Position?.ToString();
            EmploymentDateTextBox.Text = value?.EmploymentDate.ToString(DateFormat);
            EmploymentStatusTextBox.Text = value?.EmploymentStatus.ToString();
            BranchTextBox.Text = value?.Branch?.ToString();
            CompanyTextBox.Text = value?.Company?.ToString();
            PayrollTypeTextBox.Text = value?.PayrollType.ToString();
            AddressTextBox.Text = value?.Address;
            TelephoneNumberTextBox.Text = value?.TelephoneNumber;
            MobileNumberTextBox.Text = value?.MobileNumber;
            EmailAddressTextBox.Text = value?.EmailAddress;
            EmergencyContactPersonTextBox.Text = value?.EmergencyContactPerson;
            EmergencyContactPersonNumberTextBox.Text = value?.EmergencyContactPersonNumber;
            SssNumberTextBox.Text = value?.SSSNumber;
            R1ADateTextBox.Text = value?.R1ADate.ToString(DateFormat);
            PhilHealthNumberTextBox.Text = value?.PhilHealthNumber;
            PhilHealthRegistrationDateTextBox.Text = value?.PhilHealthRegistrationDate.ToString(DateFormat);
            PagIbigNumberTextBox.Text = value?.PagIbigNumber;
            PagIbigRegistrationDateTextBox.Text = value?.PagIbigRegistrationDate.ToString(DateFormat);
            PagIbigRtnTextBox.Text = value?.PagIbigRTN;
            DependentsTextBox.Text = value?.PagIbigRTNDependentNumber.ToString("#,##0");
            VacationLeaveTextBox.Text = value?.VacationLeave.ToString(MonetaryFormat);
            SickLeaveTextBox.Text = value?.SickLeave.ToString(MonetaryFormat);
            AbsencesTextBox.Text = value?.Absences.ToString("#,##0");
        }

        private void UpdateUI(EmployeePayrollAddition payrollAddition)
        {
            BasicPayTextBox.Text = string.Empty;
            DailyRateTextBox.Text = string.Empty;
            AllowanceTextBox.Text = string.Empty;
            OtAllowanceTextBox.Text = string.Empty;

            if (payrollAddition != null)
            {
                BasicPayTextBox.Text = payrollAddition.BasicPay.ToString("#,##0.00");
                DailyRateTextBox.Text = payrollAddition.DailyRate.ToString("#,##0.00");
                AllowanceTextBox.Text = payrollAddition.Allowance.ToString("#,##0.00");
                OtAllowanceTextBox.Text = payrollAddition.OvertimeAllowance.ToString("#,##0.00");
            }
        }

        private void UpdateUI(EmployeePayrollDeduction payrollDeduction)
        {
            SssDeductionTextBox.Text = string.Empty;
            SssErDeductionTextBox.Text = string.Empty;
            SssEcDeductionTextBox.Text = string.Empty;
            WithHoldingTaxTextBox.Text = string.Empty;
            PagIbigDeductionTextBox.Text = string.Empty;
            PhilHealthDeductionTextBox.Text = string.Empty;

            if (payrollDeduction != null)
            {
                SssDeductionTextBox.Text = payrollDeduction.Sss.ToString("#,##0.00");
                SssEcDeductionTextBox.Text = payrollDeduction.SssEc.ToString("#,##0.00");
                SssErDeductionTextBox.Text = payrollDeduction.SssEr.ToString("#,##0.00");
                WithHoldingTaxTextBox.Text = payrollDeduction.WithholdingTax.ToString("#,##0.00");
                PagIbigDeductionTextBox.Text = payrollDeduction.PagibigLoan.ToString("#,##0.00");
                PhilHealthDeductionTextBox.Text = payrollDeduction.PhilHealth.ToString("#,##0.00");
            }
        }

        private async Task GetListAsync()
        {
            EmployeeDataGridView.Rows.Clear();

            try
            {
                var employees = await EmployeeManager.GetMinifiedListAsync();

                if (employees != null && employees.Any())
                {
                    foreach (var employee in employees)
                    {
                        AddToUI(employee);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToUI(Employee employee)
        {
            if (employee == null) return;
            EmployeeDataGridView.Rows.Add(CreateRow(employee));
        }

        private DataGridViewRow CreateRow(Employee employee)
        {
            var row = new DataGridViewRow()
            {
                Height = 30
            };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Branch });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.PayrollType });
            return row;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await GetListAsync();
        }

        private async void EmployeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.SelectedRows.Count == 1)
            {
                var tempEmployee = EmployeeDataGridView.SelectedRows[0].Cells[EmployeeColumn.Name].Value as Employee;
                CurrentEmployee = await EmployeeManager.GetByIdAsync(tempEmployee.Id);

                if (CurrentEmployee != null)
                {
                    CurrentEmployeeLogin = await EmployeeManager.RegisterEmployeeLoginAsync(CurrentEmployee);
                    CurrentEmployeePayrollAddition = await EmployeePayrollAdditionManager.GetCurrentByEmployeeAsync(CurrentEmployee);
                    CurrentEmployeePayrollDeduction = await EmployeePayrollDeductionManager.GetCurrentByEmployeeAsync(CurrentEmployee);
                }
            }
            else
            {
                CurrentEmployee = null;
            }
        }

        private async void AddNewButton_Click(object sender, EventArgs e)
        {
            var form = AddEditEmployeeForm.AddEmployee();
            form.ShowDialog();
            form = null;
            await GetListAsync();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            if (CurrentEmployee != null)
            {
                var form = AddEditEmployeeForm.EditEmployee(CurrentEmployee, CurrentEmployeePayrollAddition, CurrentEmployeePayrollDeduction);
                form.ShowDialog();
                form = null;
                await GetListAsync();
            }
        }

        private void SearchEmployeeTextBox_TextChanged(object sender, EventArgs e)
        {
            var key = SearchEmployeeTextBox.Text.Trim().ToLower();
            foreach (DataGridViewRow row in EmployeeDataGridView.Rows)
            {
                if (row.Cells[EmployeeColumn.Name].Value is Employee employee)
                {
                    if (employee.ToString().ToLower().Contains(key))
                    {
                        row.Selected = true;
                        EmployeeDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }
        }
    }
}
