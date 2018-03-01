using Citicon.Data;
using Citicon.DataManager;
using Citicon.Forms.DataLinks;
using Citicon.WindowsForm;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citicon.Forms
{
    internal sealed class WeeklyPayrollFormController : FormControllerBase<WeeklyPayrollForm>
    {
        public WeeklyPayrollFormController(WeeklyPayrollForm form) : base(form)
        {
            _PayrollEmployees = new DataGridViewItemSource<WeeklyPayrollEmployee>(_Form.WeeklyPayrollEmployeesDataGridView, AddRow, SelectedItemChanged, _Form.LinkPayrollEmployeeColumn, RefreshRow);
            _Branches = new ComboBoxItemSource<Branch>(_Form.BranchComboBox);
            _AllowanceHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.AllowanceTextBox, accept: AcceptAllowance);
            _OvertimeAllowanceHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.OvertimeAllowanceTextBox, accept: AcceptOvertimeAllowance);
            _WithholdingTaxHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.WithholdingTaxTextBox, accept: AcceptWithholdingTax);
            _SssHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssTextBox, accept: AcceptSss);
            _SssEcHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssEcTextBox, accept: AcceptSssEc);
            _SssErHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.SssErTextBox, accept: AcceptSssEr);
            _PagibigHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.PagibigTextBox, accept: AcceptPagibig);
            _PhilHealthHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.PhilHealthTextBox, accept: AcceptPhilHealth);
            _CashAdvanceHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.CashAdvanceTextBox, accept: AcceptCashAdvance);
            _OthersHelper = TextBoxHelper<decimal>.CurrencyHelper(_Form.OthersTextBox, accept: AcceptOthers);
        }

        private readonly DataGridViewItemSource<WeeklyPayrollEmployee> _PayrollEmployees;
        private readonly ComboBoxItemSource<Branch> _Branches;
        private readonly TextBoxHelper<decimal> _AllowanceHelper;
        private readonly TextBoxHelper<decimal> _OvertimeAllowanceHelper;
        private readonly TextBoxHelper<decimal> _WithholdingTaxHelper;
        private readonly TextBoxHelper<decimal> _SssHelper;
        private readonly TextBoxHelper<decimal> _SssEcHelper;
        private readonly TextBoxHelper<decimal> _SssErHelper;
        private readonly TextBoxHelper<decimal> _PagibigHelper;
        private readonly TextBoxHelper<decimal> _PhilHealthHelper;
        private readonly TextBoxHelper<decimal> _CashAdvanceHelper;
        private readonly TextBoxHelper<decimal> _OthersHelper;
        public WeeklyPayroll Payroll { get; private set; }

        public async Task InitializeAsync()
        {
            await LoadBranchesAsync();

            if (Payroll == null)
            {
                Payroll = new WeeklyPayroll();
                Payroll.CutOff.Begin = DateTime.Now.AddDays(-6);
                Payroll.CutOff.End = DateTime.Now;
            }

            DisplayCutOff();
        }

        private void DisplayCutOff()
        {
            if (Payroll != null)
            {
                _Form.CutOffTextBox.Text = Payroll.CutOff?.ToString();
            }
        }
        

        public void ChangeCutOff()
        {
            var cutOff = WeeklyCutOffForm.Change(Payroll.CutOff);

            if (cutOff != null)
            {
                DisplayCutOff();
            }
        }

        private DataGridViewRow AddRow(WeeklyPayrollEmployee payrollEmployee)
        {
            return new DataGridViewRow()
                .SetHeight(30)
                .SetError(() => payrollEmployee.IrregularWorkingHoursDetected)
                .AddTextBoxCell(payrollEmployee)
                .AddTextBoxCell(payrollEmployee.Employee)
                .AddTextBoxCell(payrollEmployee.DailyRate)
                .AddTextBoxCell(payrollEmployee.BasicPay)
                .AddTextBoxCell(payrollEmployee.GrossPay)
                .AddTextBoxCell(payrollEmployee.TotalDeduction)
                .AddTextBoxCell(payrollEmployee.NetPay);
        }

        private void SelectedItemChanged(WeeklyPayrollEmployee payrollEmployee)
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
            _Form.CashAdvanceTextBox.Text = string.Empty;
            _Form.OthersTextBox.Text = string.Empty;

            if (payrollEmployee != null)
            {
                _Form.EmployeeNameTextBox.Text = payrollEmployee.Employee?.ToString();
                _Form.DepartmentTextBox.Text = payrollEmployee.Employee?.Position?.Department?.Name;
                _Form.PositionTextBox.Text = payrollEmployee.Employee?.Position?.Name;
                _Form.RegularWorkingHoursTextBox.Text = payrollEmployee.RegularWorkingHours.ToString();
                _Form.RegularOvertimeWorkingHoursTextBox.Text = payrollEmployee.RegularOvertimeWorkingHours.ToString();
                _Form.SundayWorkingHoursTextBox.Text = payrollEmployee.SundayWorkingHours.ToString();
                _Form.NightDifferentialWorkingHoursTextBox.Text = payrollEmployee.NightDifferentialWorkingHours.ToString();
                _Form.SpecialHolidayWorkingHoursTextBox.Text = payrollEmployee.SpecialHolidayWorkingHours.ToString();
                _Form.SpecialHolidayOvertimeWorkingHoursTextBox.Text = payrollEmployee.SpecialHolidayOvertimeWorkingHours.ToString();
                _Form.DailyRateTextBox.Text = payrollEmployee.DailyRate.ToString(Resources.Formats.Currency);
                _Form.BasicPayTextBox.Text = payrollEmployee.BasicPay.ToString(Resources.Formats.Currency);
                _Form.AllowanceTextBox.Text = payrollEmployee.Allowance.ToString(Resources.Formats.Currency);
                _Form.OvertimeAllowanceTextBox.Text = payrollEmployee.OvertimeAllowance.ToString(Resources.Formats.Currency);
                _Form.WithholdingTaxTextBox.Text = payrollEmployee.WithholdingTax.ToString(Resources.Formats.Currency);
                _Form.SssTextBox.Text = payrollEmployee.Sss.ToString(Resources.Formats.Currency);
                _Form.SssEcTextBox.Text = payrollEmployee.SssEc.ToString(Resources.Formats.Currency);
                _Form.SssErTextBox.Text = payrollEmployee.SssEr.ToString(Resources.Formats.Currency);
                _Form.PagibigTextBox.Text = payrollEmployee.Pagibig.ToString(Resources.Formats.Currency);
                _Form.PhilHealthTextBox.Text = payrollEmployee.PhilHealth.ToString(Resources.Formats.Currency);
                _Form.CashAdvanceTextBox.Text = payrollEmployee.CashAdvance.ToString(Resources.Formats.Currency);
                _Form.OthersTextBox.Text = payrollEmployee.Others.ToString(Resources.Formats.Currency);
            }
        }

        private void RefreshRow(DataGridViewRow row, WeeklyPayrollEmployee payrollEmployee)
        {
            row.Cells[_Form.LinkPayrollEmployeeGrossPayColumn].Value = payrollEmployee.GrossPay;
            row.Cells[_Form.LinkPayrollEmployeeTotalDeductionColumn].Value = payrollEmployee.TotalDeduction;
            row.Cells[_Form.LinkPayrollEmployeeNetPayColumn].Value = payrollEmployee.NetPay;
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

        private void AcceptAllowance(decimal allowance)
        {
            var selected = _PayrollEmployees.SelectedItem;
            if (selected != null)
            {
                selected.Allowance = allowance;
                _PayrollEmployees.RefreshSelected();
            }
        }

        private void AcceptOvertimeAllowance(decimal overtimeAllowance)
        {
            var selected = _PayrollEmployees.SelectedItem;
            if (selected != null)
            {
                selected.OvertimeAllowance = overtimeAllowance;
                _PayrollEmployees.RefreshSelected();
            }
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

        private void AcceptCashAdvance(decimal cashAdvance)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.CashAdvance = cashAdvance;
                _PayrollEmployees.RefreshSelected();
            }
        }

        private void AcceptOthers(decimal others)
        {
            var selected = _PayrollEmployees.SelectedItem;

            if (selected != null)
            {
                selected.Others = others;
                _PayrollEmployees.RefreshSelected();
            }
        }

        public async Task GenerateAsync()
        {
            try
            {
                SetData();
                _PayrollEmployees.Clear();
                var employees = await PayrollManager.GenerateWeeklyPayrollEmployeeListAsync(Payroll);

                if (employees != null && employees.Any())
                {
                    _PayrollEmployees.AddRange(employees);
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
            Payroll.RunDate = DateTime.Now;
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
                    await PayrollManager.SaveWeeklyAsync(Payroll, _PayrollEmployees);
                    await PayrollManager.ExportWeeklyAsync(Payroll, _PayrollEmployees);
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
            foreach (var payrollEmployee in _PayrollEmployees)
            {
                if (payrollEmployee.IrregularWorkingHoursDetected)
                {
                    return true;
                }
            }

            return false;
        }

        public async Task ViewTimeLogsAsync()
        {
            var selectedEmployee = _PayrollEmployees.SelectedItem;
            if (selectedEmployee != null)
            {
                var form = new EmployeeTimeLogForm(selectedEmployee.Employee, Payroll.CutOff);
                form.ShowDialog();

                if (form.HasChanges)
                {
                    _MessageDisplay.Inform("We've detected that you've made changes to the time-logs, we will refresh the employees.");
                    await GenerateAsync();

                }
            }
        }
    }
}
