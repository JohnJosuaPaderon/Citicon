using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.DataLinks;
using Citicon.WindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    internal sealed class SemiMonthlyPayrollFormController : FormControllerBase<SemiMonthlyPayrollForm>, IDisposable
    {
        public SemiMonthlyPayrollFormController(SemiMonthlyPayrollForm form) : base(form)
        {
            _Employees = new DataGridViewItemSource<SemiMonthlyPayrollEmployee>(_Form.SemiMonthlyPayrollEmployeesDataGridView, AddRow, SelectedItemChanged, _Form.LinkSemiMonthlyPayrollEmployeeColumn, Refresh);
            _Branches = new ComboBoxItemSource<Branch>(_Form.BranchComboBox);
            _AllowanceHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.AllowanceTextBox, accept: AcceptAllowance);
            _OvertimeAllowanceHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.OvertimeAllowanceTextBox, accept: AcceptOvertimeAllowance);
            _WithholdingTaxHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.WithholdingTaxTextBox, accept: AcceptWithholdingTax);
            _SssHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssTextBox, accept: AcceptSss);
            _SssEcHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssEcTextBox, accept: AcceptSssEc);
            _SssErHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssErTextBox, accept: AcceptSssEr);
            _PagibigHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.PagibigTextBox, accept: AcceptPagibig);
            _PhilHealthHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.PhilHealthTextBox, accept: AcceptPhilHealth);
        }

        private readonly DataGridViewItemSource<SemiMonthlyPayrollEmployee> _Employees;
        private readonly ComboBoxItemSource<Branch> _Branches;
        private readonly TextBoxHelper<decimal> _AllowanceHelper;
        private readonly TextBoxHelper<decimal> _OvertimeAllowanceHelper;
        private readonly TextBoxHelper<decimal> _WithholdingTaxHelper;
        private readonly TextBoxHelper<decimal> _SssHelper;
        private readonly TextBoxHelper<decimal> _SssEcHelper;
        private readonly TextBoxHelper<decimal> _SssErHelper;
        private readonly TextBoxHelper<decimal> _PagibigHelper;
        private readonly TextBoxHelper<decimal> _PhilHealthHelper;

        public SemiMonthlyPayroll Payroll { get; private set; }
        public IEnumerable<SemiMonthlyPayrollEmployee> Employees => _Employees;
        
        public async Task InitializeAsync()
        {
            if (Payroll == null)
            {
                Payroll = new SemiMonthlyPayroll();
            }

            _Employees.Clear();
            await LoadBranchesAsync();
        }

        public async Task GenerateAsync()
        {
            try
            {
                SetData();
                _Employees.Clear();
                var employees = await PayrollManager.GenerateSemiMonthlyPayrollEmployeeListAsync(Payroll);

                if (employees != null && employees.Any())
                {
                    _Employees.AddRange(employees);
                }
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
            }
        }

        private void SetData()
        {
            Payroll.Branch = _Branches.SelectedItem;
            Payroll.CutOff.Begin = _Form.CutOffBeginDateTimePicker.Value;
            Payroll.CutOff.End = _Form.CutOffEndDateTimePicker.Value;
            Payroll.RunDate = DateTime.Now;
        }

        private async Task LoadBranchesAsync()
        {
            var branches = await new BranchManager().GetListAsync();

            if (branches != null && branches.Any())
            {
                foreach (var branch in branches)
                {
                    _Branches.Add(branch);
                }
            }
        }

        private DataGridViewRow AddRow(SemiMonthlyPayrollEmployee employee)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .SetError(() => employee.IrregularWorkingHoursDetected)
                .AddTextBoxCell(employee)
                .AddTextBoxCell(employee.Employee)
                .AddTextBoxCell(employee.DailyRate)
                .AddTextBoxCell(employee.BasicPay)
                .AddTextBoxCell(employee.GrossPay)
                .AddTextBoxCell(employee.TotalDeduction)
                .AddTextBoxCell(employee.NetPay);
        }

        private void Refresh(DataGridViewRow row, SemiMonthlyPayrollEmployee employee)
        {
            row.Cells[_Form.LinkSemiMonthlyPayrollEmployeeGrossPayColumn].Value = employee.GrossPay;
            row.Cells[_Form.LinkSemiMonthlyPayrollEmployeeTotalDeductionColumn].Value = employee.TotalDeduction;
            row.Cells[_Form.LinkSemiMonthlyPayrollEmployeeNetPayColumn].Value = employee.NetPay;
        }

        private void SelectedItemChanged(SemiMonthlyPayrollEmployee employee)
        {
            _Form.EmployeeNameTextBox.Text = string.Empty;
            _Form.DepartmentTextBox.Text = string.Empty;
            _Form.PositionTextBox.Text = string.Empty;
            _Form.RegularWorkingHoursTextBox.Text = string.Empty;
            _Form.RegularOvertimeWorkingHoursTextBox.Text = string.Empty;
            _Form.SundayWorkingHoursTextBox.Text = string.Empty;
            _Form.NightDifferentialWorkingHoursTextBox.Text = string.Empty;
            _Form.SpecialHolidayWorkingHoursTextBox.Text = string.Empty;
            _Form.SpecialHolidayOvertimeWorkingHoursTextBox.Text = string.Empty;
            _Form.DailyRateTextBox.Text = string.Empty;
            _Form.BasicPayTextBox.Text = string.Empty;
            _Form.AllowanceTextBox.Text = string.Empty;
            _Form.OvertimeAllowanceTextBox.Text = string.Empty;
            _Form.WithholdingTaxTextBox.Text = string.Empty;
            _Form.SssTextBox.Text = string.Empty;
            _Form.SssEcTextBox.Text = string.Empty;
            _Form.SssErTextBox.Text = string.Empty;
            _Form.PagibigTextBox.Text = string.Empty;
            _Form.PhilHealthTextBox.Text = string.Empty;

            if (employee != null)
            {
                _Form.EmployeeNameTextBox.Text = employee.Employee?.ToString();
                _Form.DepartmentTextBox.Text = employee.Employee?.Position?.Department?.Name;
                _Form.PositionTextBox.Text = employee.Employee?.Position?.Name;
                _Form.RegularWorkingHoursTextBox.Text = employee.RegularWorkingHours.ToString();
                _Form.RegularOvertimeWorkingHoursTextBox.Text = employee.RegularOvertimeWorkingHours.ToString();
                _Form.SundayWorkingHoursTextBox.Text = employee.SundayWorkingHours.ToString();
                _Form.NightDifferentialWorkingHoursTextBox.Text = employee.NightDifferentialWorkingHours.ToString();
                _Form.SpecialHolidayWorkingHoursTextBox.Text = employee.SpecialHolidayWorkingHours.ToString();
                _Form.SpecialHolidayOvertimeWorkingHoursTextBox.Text = employee.SpecialHolidayOvertimeWorkingHours.ToString();
                _Form.DailyRateTextBox.Text = employee.DailyRate.ToString(Resources.Formats.Currency);
                _Form.BasicPayTextBox.Text = employee.BasicPay.ToString(Resources.Formats.Currency);
                _Form.AllowanceTextBox.Text = employee.Allowance.ToString(Resources.Formats.Currency);
                _Form.OvertimeAllowanceTextBox.Text = employee.OvertimeAllowance.ToString(Resources.Formats.Currency);
                _Form.WithholdingTaxTextBox.Text = employee.WithholdingTax.ToString(Resources.Formats.Currency);
                _Form.SssTextBox.Text = employee.Sss.ToString(Resources.Formats.Currency);
                _Form.SssEcTextBox.Text = employee.SssEc.ToString(Resources.Formats.Currency);
                _Form.SssErTextBox.Text = employee.SssEr.ToString(Resources.Formats.Currency);
                _Form.PagibigTextBox.Text = employee.Pagibig.ToString(Resources.Formats.Currency);
                _Form.PhilHealthTextBox.Text = employee.PhilHealth.ToString(Resources.Formats.Currency);
            }
        }

        private void AcceptAllowance(decimal allowance)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.Allowance = allowance;
                _Employees.RefreshSelected();
            }
        }

        private void AcceptOvertimeAllowance(decimal overtimeAllowance)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.OvertimeAllowance = overtimeAllowance;
                _Employees.RefreshSelected();
            }
        }

        private void AcceptWithholdingTax(decimal withholdingTax)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.WithholdingTax = withholdingTax;
                _Employees.RefreshSelected();
            }
        }

        private void AcceptSss(decimal sss)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.Sss = sss;
                _Employees.RefreshSelected();
            }
        }

        private void AcceptSssEc(decimal sssEc)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.SssEc = sssEc;
                _Employees.RefreshSelected();
            }
        }

        private void AcceptSssEr(decimal sssEr)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.SssEr = sssEr;
                _Employees.RefreshSelected();
            }
        }

        private void AcceptPagibig(decimal pagibig)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.Pagibig = pagibig;
                _Employees.RefreshSelected();
            }
        }

        private void AcceptPhilHealth(decimal philHealth)
        {
            var selected = _Employees.SelectedItem;
            if (selected != null)
            {
                selected.PhilHealth = philHealth;
                _Employees.RefreshSelected();
            }
        }

        public void Dispose()
        {
            _Employees.Dispose();
        }

        public async Task SavePrintAsync()
        {
            if (HasNoWorkingHoursIrregularities())
            {
                _MessageDisplay.Error("We've detected working hours irregularities. Saving is interrupted.");
                return;
            }

            SetData();
            var exists = default(bool);
            var allowContinue = default(bool);

            try
            {
                exists = await PayrollManager.ExistsAsync(Payroll);
            }
            catch (Exception ex)
            {
                _MessageDisplay.Exception(ex);
                return;
            }

            if (exists)
            {
                allowContinue = _MessageDisplay.Question($"Payroll already exists!{Environment.NewLine}Do you want to continue saving? Existing payroll will be overriden.", MessageBoxButtons.YesNo) == DialogResult.Yes;
            }
            else
            {
                allowContinue = true;
            }

            if (allowContinue)
            {
                try
                {
                    await PayrollManager.SaveSemiMonthlyAsync(Payroll, _Employees);
                    await PayrollManager.ExportSemiMonthlyAsync(Payroll, _Employees);
                    _MessageDisplay.Inform("Payroll successfully saved.");
                }
                catch (Exception ex)
                {
                    _MessageDisplay.Exception(ex);
                }
            }
        }

        private bool HasNoWorkingHoursIrregularities()
        {
            foreach (var payrollEmployee in _Employees)
            {
                if (payrollEmployee.IrregularWorkingHoursDetected)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
