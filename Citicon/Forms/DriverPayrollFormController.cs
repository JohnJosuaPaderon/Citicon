using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.DataLinks;
using Citicon.WindowsForm;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    internal sealed class DriverPayrollFormController : FormControllerBase<DriverPayrollForm>
    {
        public DriverPayrollFormController(DriverPayrollForm form) : base(form)
        {
            _Branches = new ComboBoxItemSource<Branch>(_Form.BranchComboBox);
            _PayrollEmployees = new DataGridViewItemSource<DriverPayrollEmployee>(_Form.DriverPayrollEmployeeDataGridView, AddRow, SelectedItemChanged, "DriverPayrollEmployeeColumn", RefreshRow);
            _WithholdingTaxHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.WithholdingTaxTextBox, accept: AcceptWithholdingTax);
            _SssHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssTextBox, accept: AcceptSss);
            _SssEcHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssEcTextBox, accept: AcceptSssEc);
            _SssErHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssErTextBox, accept: AcceptSssEr);
            _PagibigHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.PagibigTextBox, accept: AcceptPagibig);
            _PhilHealthHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.PhilHealthTextBox, accept: AcceptPhilHealth);
        }

        public void ChangeCutOff()
        {
            WeeklyCutOffForm.Change(Payroll.CutOff);
        }

        private readonly ComboBoxItemSource<Branch> _Branches;
        private readonly DataGridViewItemSource<DriverPayrollEmployee> _PayrollEmployees;
        private readonly TextBoxHelper<decimal> _WithholdingTaxHelper;
        private readonly TextBoxHelper<decimal> _SssHelper;
        private readonly TextBoxHelper<decimal> _SssEcHelper;
        private readonly TextBoxHelper<decimal> _SssErHelper;
        private readonly TextBoxHelper<decimal> _PagibigHelper;
        private readonly TextBoxHelper<decimal> _PhilHealthHelper;

        public DriverPayroll Payroll { get; private set; }

        private async Task LoadBranchesAsync()
        {
            _Branches.Clear();
            var branches = await (new BranchManager()).GetListAsync();

            if (branches != null && branches.Any())
            {
                foreach (var branch in branches)
                {
                    _Branches.Add(branch);
                }
            }
        }

        public async Task InitializeAsync()
        {
            if (Payroll == null)
            {
                Payroll = new DriverPayroll();
            }

            await LoadBranchesAsync();
        }

        public async Task GenerateAsync()
        {

        }

        private DataGridViewRow AddRow(DriverPayrollEmployee payrollEmployee)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .AddTextBoxCell(payrollEmployee)
                .AddTextBoxCell(payrollEmployee.Employee)
                .AddTextBoxCell(payrollEmployee.ShopRate)
                .AddTextBoxCell(payrollEmployee.GrossPay)
                .AddTextBoxCell(payrollEmployee.TotalDeduction)
                .AddTextBoxCell(payrollEmployee.NetPay);
        }

        private void SelectedItemChanged(DriverPayrollEmployee payrollEmployee)
        {
            _Form.EmployeeNameTextBox.Text = string.Empty;
            _Form.DepartmentTextBox.Text = string.Empty;
            _Form.PositionTextBox.Text = string.Empty;
            _Form.WorkDaysTextBox.Text = string.Empty;
            _Form.HolidaysTextBox.Text = string.Empty;
            _Form.WithholdingTaxTextBox.Text = string.Empty;
            _Form.SssTextBox.Text = string.Empty;
            _Form.SssEcTextBox.Text = string.Empty;
            _Form.SssErTextBox.Text = string.Empty;
            _Form.PagibigTextBox.Text = string.Empty;
            _Form.PhilHealthTextBox.Text = string.Empty;
            _Form.ShopRateTextBox.Text = string.Empty;

            if (payrollEmployee != null)
            {
                _Form.EmployeeNameTextBox.Text = payrollEmployee.Employee?.ToString();
                _Form.DepartmentTextBox.Text = payrollEmployee.Employee?.Position?.Department?.ToString();
                _Form.PositionTextBox.Text = payrollEmployee.Employee?.Position?.ToString();
                _Form.WorkDaysTextBox.Text = payrollEmployee.WorkDays.ToString();
                _Form.HolidaysTextBox.Text = payrollEmployee.Holidays.ToString();
                _Form.SssTextBox.Text = payrollEmployee.Sss.ToString(Resources.Formats.Currency);
                _Form.SssEcTextBox.Text = payrollEmployee.SssEc.ToString(Resources.Formats.Currency);
                _Form.SssErTextBox.Text = payrollEmployee.SssEr.ToString(Resources.Formats.Currency);
                _Form.PagibigTextBox.Text = payrollEmployee.Pagibig.ToString(Resources.Formats.Currency);
                _Form.PhilHealthTextBox.Text = payrollEmployee.PhilHealth.ToString(Resources.Formats.Currency);
                _Form.ShopRateTextBox.Text = payrollEmployee.ShopRate.ToString(Resources.Formats.Currency);
            }
        }

        private void RefreshRow(DataGridViewRow row, DriverPayrollEmployee payrollEmployee)
        {
            row.Cells["DriverPayrollEmployeeColumn"].Value = payrollEmployee;
            row.Cells["DriverPayrollEmployee_EmployeeColumn"].Value = payrollEmployee.Employee;
            row.Cells["DriverPayrollEmployee_ShopRateColumn"].Value = payrollEmployee.ShopRate;
            row.Cells["DriverPayrollEmployee_GrossPayColumn"].Value = payrollEmployee.GrossPay;
            row.Cells["DriverPayrollEmployee_TotalDeductionColumn"].Value = payrollEmployee.TotalDeduction;
            row.Cells["DriverPayrollEmployee_NetPayColumn"].Value = payrollEmployee.NetPay;
        }

        private void AcceptWithholdingTax(decimal withholdingTax)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.WithholdingTax = withholdingTax;
                _PayrollEmployees.RefreshSelected();
            }
        }

        private void AcceptSss(decimal sss)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.Sss = sss;
                _PayrollEmployees.RefreshSelected();
            }
        }

        private void AcceptSssEc(decimal sssEc)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.SssEc = sssEc;
                _PayrollEmployees.RefreshSelected();
            }
        }

        private void AcceptSssEr(decimal sssEr)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.SssEr = sssEr;
                _PayrollEmployees.RefreshSelected();
            }
        }

        private void AcceptPagibig(decimal pagibig)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.Pagibig = pagibig;
                _PayrollEmployees.RefreshSelected();
            }
        }

        private void AcceptPhilHealth(decimal philHealth)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.PhilHealth = philHealth;
                _PayrollEmployees.RefreshSelected();
            }
        }
    }
}
