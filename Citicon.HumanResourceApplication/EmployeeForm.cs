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
            BasicPayTextBox.Text = value?.BasicPay.ToString(MonetaryFormat);
            DailyRateTextBox.Text = value?.DailyRate.ToString(MonetaryFormat);
            AllowanceTextBox.Text = value?.Allowance.ToString(MonetaryFormat);
            OtAllowanceTextBox.Text = value?.OTAllowance.ToString(MonetaryFormat);
            SssDeductionTextBox.Text = value?.SSSDeduction.ToString(MonetaryFormat);
            SssErDeductionTextBox.Text = value?.SSSERDeduction.ToString(MonetaryFormat);
            SssEcDeductionTextBox.Text = value?.SSSECDeduction.ToString(MonetaryFormat);
            WithHoldingTaxTextBox.Text = value?.WithHoldingTax.ToString(MonetaryFormat);
            PagIbigDeductionTextBox.Text = value?.PagIbigDeduction.ToString(MonetaryFormat);
            PhilHealthDeductionTextBox.Text = value?.PhilHealthDeduction.ToString(MonetaryFormat);
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
                var form = AddEditEmployeeForm.EditEmployee(CurrentEmployee);
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
