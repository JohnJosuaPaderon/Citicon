using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportSemiMonthlyPayroll : ExportExcelBase
    {
        private const string CONFIG_PREFIX = "Payroll.SemiMonthly";

        public ExportSemiMonthlyPayroll(SemiMonthlyPayroll payroll, IEnumerable<SemiMonthlyPayrollEmployee> payrollEmployees)
        {
            _Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
            _PayrollEmployees = new SemiMonthlyPayrollEmployeeCollection(payrollEmployees);
            _TemplatePath = GetFromConfig("Template");
            _SaveDirectory = GetFromConfig("SaveDirectory");
            _RowIndexStart = GetInt32FromConfig("RowIndexStart");
            _CutOffCell = GetCellFromConfig("CutOff");
            _BranchCell = GetCellFromConfig("Branch");
            _NumberingColumn = GetColumnFromConfig("Numbering");
            _EmployeeColumn = GetColumnFromConfig("Employee");
            _VacationLeaveColumn = GetColumnFromConfig("VacationLeave");
            _SickLeaveColumn = GetColumnFromConfig("SickLeave");
            _DailyRateColumn = GetColumnFromConfig("DailyRate");
            _BasicPayColumn = GetColumnFromConfig("BasicPay");
            _AllowanceColumn = GetColumnFromConfig("Allowance");
            _OvertimeAllowanceColumn = GetColumnFromConfig("OvertimeAllowance");
            _WithholdingTaxColumn = GetColumnFromConfig("WithholdingTax");
            _SssColumn = GetColumnFromConfig("Sss");
            _SssErColumn = GetColumnFromConfig("SssEr");
            _SssEcColumn = GetColumnFromConfig("SssEc");
            _PagibigColumn = GetColumnFromConfig("Pagibig");
            _PhilHealthColumn = GetColumnFromConfig("PhilHealth");
            _CashAdvanceColumn = GetColumnFromConfig("CashAdvance");
            _SunCellBillColumn = GetColumnFromConfig("SunCellBill");
            _RegularWorkingHoursColumn = GetColumnFromConfig("RegularWorkingHours");
            _RegularOvertimeWorkingHoursColumn = GetColumnFromConfig("RegularOvertimeWorkingHours");
            _SundayWorkingHoursColumn = GetColumnFromConfig("SundayWorkingHours");
            _SpecialHolidayWorkingHoursColumn = GetColumnFromConfig("SpecialHolidayWorkingHours");
            _SpecialHolidayOvertimeWorkingHoursColumn = GetColumnFromConfig("SpecialHolidayOvertimeWorkingHours");
            _NightDifferentialWorkingHoursColumn = GetColumnFromConfig("NightDifferentialWorkingHours");
            _RegularOvertimePayColumn = GetColumnFromConfig("RegularOvertimePay");
            _SundayPayColumn = GetColumnFromConfig("SundayPay");
            _SpecialHolidayPayColumn = GetColumnFromConfig("SpecialHolidayPay");
            _SpecialHolidayOvertimePayColumn = GetColumnFromConfig("SpecialHolidayOvertimePay");
            _GrossPayColumn = GetColumnFromConfig("GrossPay");
            _TotalDeductionColumn = GetColumnFromConfig("TotalDeduction");
            _NetPayColumn = GetColumnFromConfig("NetPay");
            _NightDifferentialPayColumn = GetColumnFromConfig("NightDifferentialPay");
        }

        private readonly SemiMonthlyPayroll _Payroll;
        private readonly SemiMonthlyPayrollEmployeeCollection _PayrollEmployees;
        private readonly string _TemplatePath;
        private readonly string _SaveDirectory;
        private readonly int _RowIndexStart;
        private readonly ExcelCell _CutOffCell;
        private readonly ExcelCell _BranchCell;
        private readonly ExcelColumn _NumberingColumn;
        private readonly ExcelColumn _EmployeeColumn;
        private readonly ExcelColumn _VacationLeaveColumn;
        private readonly ExcelColumn _SickLeaveColumn;
        private readonly ExcelColumn _DailyRateColumn;
        private readonly ExcelColumn _BasicPayColumn;
        private readonly ExcelColumn _AllowanceColumn;
        private readonly ExcelColumn _OvertimeAllowanceColumn;
        private readonly ExcelColumn _WithholdingTaxColumn;
        private readonly ExcelColumn _SssColumn;
        private readonly ExcelColumn _SssErColumn;
        private readonly ExcelColumn _SssEcColumn;
        private readonly ExcelColumn _PagibigColumn;
        private readonly ExcelColumn _PhilHealthColumn;
        private readonly ExcelColumn _CashAdvanceColumn;
        private readonly ExcelColumn _SunCellBillColumn;
        private readonly ExcelColumn _RegularWorkingHoursColumn;
        private readonly ExcelColumn _RegularOvertimeWorkingHoursColumn;
        private readonly ExcelColumn _SundayWorkingHoursColumn;
        private readonly ExcelColumn _SpecialHolidayWorkingHoursColumn;
        private readonly ExcelColumn _SpecialHolidayOvertimeWorkingHoursColumn;
        private readonly ExcelColumn _NightDifferentialWorkingHoursColumn;
        private readonly ExcelColumn _RegularOvertimePayColumn;
        private readonly ExcelColumn _SundayPayColumn;
        private readonly ExcelColumn _SpecialHolidayPayColumn;
        private readonly ExcelColumn _SpecialHolidayOvertimePayColumn;
        private readonly ExcelColumn _GrossPayColumn;
        private readonly ExcelColumn _TotalDeductionColumn;
        private readonly ExcelColumn _NetPayColumn;
        private readonly ExcelColumn _NightDifferentialPayColumn;

        private ExcelColumn GetColumnFromConfig(string key)
        {
            return new ExcelColumn
            {
                Index = ConfigurationManager.AppSettings.GetInt32($"{CONFIG_PREFIX}.Column[{key}].Index"),
                Visible = ConfigurationManager.AppSettings.GetBoolean($"{CONFIG_PREFIX}.Column[{key}].Visible")
            };
        }

        private string GetFromConfig(string key)
        {
            return ConfigurationManager.AppSettings.GetString($"{CONFIG_PREFIX}.{key}");
        }

        private int GetInt32FromConfig(string key)
        {
            return ConfigurationManager.AppSettings.GetInt32($"{CONFIG_PREFIX}.{key}");
        }

        private ExcelCell GetCellFromConfig(string key)
        {
            return ExcelCellParser.Parse(ConfigurationManager.AppSettings.GetString($"{CONFIG_PREFIX}.Cell[{key}]"));
        }

        private void Initialize()
        {
            if (File.Exists(_TemplatePath))
            {
                Application = new Excel.Application();
                Workbooks = Application.Workbooks;
                Workbook = Workbooks.Open(_TemplatePath);
                Sheets = Workbook.Sheets;
                Worksheet = Sheets[1];
            }
            else
            {
                throw new FileNotFoundException("Semi-Monthly Payroll Template not found", nameof(_TemplatePath));
            }
        }

        private void Write(int rowIndex, ExcelColumn column, object value, string numberFormat = null)
        {
            if (column.Visible)
            {
                Excel.Range range = Worksheet.Cells[rowIndex, column.Index];
                range.Value = value;
                if (!string.IsNullOrWhiteSpace(numberFormat))
                {
                    range.NumberFormat = numberFormat;
                }
            }
        }

        private void Write(ExcelCell cell, object value)
        {
            Excel.Range range = Worksheet.Cells[cell.RowIndex, cell.ColumnIndex];
            range.Value = value;
        }

        private void DrawBorder(int startRow, int startColumn, int endRow, int endColumn, Excel.XlBordersIndex borderIndex, Excel.XlLineStyle lineStyle = Excel.XlLineStyle.xlContinuous)
        {
            Excel.Range range = Worksheet.Range[Worksheet.Cells[startRow, startColumn], Worksheet.Cells[endRow, endColumn]];
            var border = range.Borders[borderIndex];
            border.LineStyle = lineStyle;
        }

        private void WriteHeaders()
        {
            Write(_CutOffCell, _Payroll.CutOff.ToString());
            Write(_BranchCell, _Payroll.Branch?.Description);
        }

        private void WriteSummations(int row)
        {
            DrawBorder(row, _NumberingColumn.Index, row, _NetPayColumn.Index, Excel.XlBordersIndex.xlEdgeTop, Excel.XlLineStyle.xlDouble);
            Write(row, _EmployeeColumn, "TOTAL");
            Write(row, _DailyRateColumn, _PayrollEmployees.TotalDailyRate);
            Write(row, _BasicPayColumn, _PayrollEmployees.TotalBasicPay);
            Write(row, _AllowanceColumn, _PayrollEmployees.TotalAllowance);
            Write(row, _OvertimeAllowanceColumn, _PayrollEmployees.TotalOvertimeAllowance);
            Write(row, _WithholdingTaxColumn, _PayrollEmployees.TotalWithholdingTax);
            Write(row, _SssColumn, _PayrollEmployees.TotalSss);
            Write(row, _SssErColumn, _PayrollEmployees.TotalSssEr);
            Write(row, _SssEcColumn, _PayrollEmployees.TotalSssEc);
            Write(row, _PagibigColumn, _PayrollEmployees.TotalPagibig);
            Write(row, _PhilHealthColumn, _PayrollEmployees.TotalPhilHealth);
            Write(row, _CashAdvanceColumn, _PayrollEmployees.TotalCashAdvance);
            Write(row, _SunCellBillColumn, _PayrollEmployees.TotalSunCellBill);
            Write(row, _RegularOvertimePayColumn, _PayrollEmployees.TotalRegularOvertimePay);
            Write(row, _SundayPayColumn, _PayrollEmployees.TotalSundayPay);
            Write(row, _SpecialHolidayPayColumn, _PayrollEmployees.TotalSpecialHolidayPay);
            Write(row, _SpecialHolidayOvertimePayColumn, _PayrollEmployees.TotalSpecialHolidayOvertimePay);
            Write(row, _GrossPayColumn, _PayrollEmployees.TotalGrossPay);
            Write(row, _TotalDeductionColumn, _PayrollEmployees.TotalDeduction);
            Write(row, _NetPayColumn, _PayrollEmployees.TotalNetPay);
        }

        private void WritePayrollEmployees(ref int rowIndex)
        {
            var number = 1;
            foreach (var payrollEmployee in _PayrollEmployees)
            {
                Write(rowIndex, _NumberingColumn, number);
                Write(rowIndex, _EmployeeColumn, payrollEmployee.Employee?.ToString());
                Write(rowIndex, _VacationLeaveColumn, payrollEmployee.VacationLeave);
                Write(rowIndex, _SickLeaveColumn, payrollEmployee.SickLeave);
                WriteAdditions(payrollEmployee, rowIndex);
                WriteDeductions(rowIndex, payrollEmployee);
                WriteTimeLogHours(rowIndex, payrollEmployee);
                WriteCalculations(rowIndex, payrollEmployee);
                number++;
                rowIndex++;
            }
        }

        private void WriteCalculations(int rowIndex, SemiMonthlyPayrollEmployee payrollEmployee)
        {
            Write(rowIndex, _RegularOvertimePayColumn, payrollEmployee.RegularOvertimePay);
            Write(rowIndex, _SundayPayColumn, payrollEmployee.SundayPay);
            Write(rowIndex, _SpecialHolidayPayColumn, payrollEmployee.SpecialHolidayPay);
            Write(rowIndex, _SpecialHolidayOvertimePayColumn, payrollEmployee.SpecialHolidayOvertimePay);
            Write(rowIndex, _NightDifferentialPayColumn, payrollEmployee.NightDifferentialPay);
            Write(rowIndex, _GrossPayColumn, payrollEmployee.GrossPay);
            Write(rowIndex, _TotalDeductionColumn, payrollEmployee.TotalDeduction);
            Write(rowIndex, _NetPayColumn, payrollEmployee.NetPay);
        }

        private void WriteTimeLogHours(int rowIndex, SemiMonthlyPayrollEmployee payrollEmployee)
        {
            Write(rowIndex, _RegularWorkingHoursColumn, payrollEmployee.RegularWorkingHours);
            Write(rowIndex, _RegularOvertimeWorkingHoursColumn, payrollEmployee.RegularOvertimeWorkingHours);
            Write(rowIndex, _SundayWorkingHoursColumn, payrollEmployee.SundayWorkingHours);
            Write(rowIndex, _SpecialHolidayWorkingHoursColumn, payrollEmployee.SpecialHolidayWorkingHours);
            Write(rowIndex, _SpecialHolidayOvertimeWorkingHoursColumn, payrollEmployee.SpecialHolidayOvertimeWorkingHours);
            Write(rowIndex, _NightDifferentialWorkingHoursColumn, payrollEmployee.NightDifferentialWorkingHours);
        }

        private void WriteDeductions(int rowIndex, SemiMonthlyPayrollEmployee payrollEmployee)
        {
            Write(rowIndex, _WithholdingTaxColumn, payrollEmployee.WithholdingTax);
            Write(rowIndex, _SssColumn, payrollEmployee.Sss);
            Write(rowIndex, _SssErColumn, payrollEmployee.SssEr);
            Write(rowIndex, _SssEcColumn, payrollEmployee.SssEc);
            Write(rowIndex, _PagibigColumn, payrollEmployee.Pagibig);
            Write(rowIndex, _PhilHealthColumn, payrollEmployee.PhilHealth);
            Write(rowIndex, _CashAdvanceColumn, payrollEmployee.CashAdvance);
            Write(rowIndex, _SunCellBillColumn, payrollEmployee.SunCellBill);
        }

        private void WriteAdditions(SemiMonthlyPayrollEmployee payrollEmployee, int rowIndex)
        {
            Write(rowIndex, _DailyRateColumn, payrollEmployee.DailyRate);
            Write(rowIndex, _BasicPayColumn, payrollEmployee.BasicPay);
            Write(rowIndex, _AllowanceColumn, payrollEmployee.Allowance);
            Write(rowIndex, _OvertimeAllowanceColumn, payrollEmployee.OvertimeAllowance);
        }

        private void Save()
        {
            var file = Path.Combine(_SaveDirectory, $"{_Payroll.RunDate.ToString("yyyyMMdd_HHmm")}.xlsx");
            Directory.CreateDirectory(_SaveDirectory);

            Workbook.SaveAs(file);
        }

        public override void Execute()
        {
            Initialize();
            var rowIndex = _RowIndexStart;
            WriteHeaders();
            WritePayrollEmployees(ref rowIndex);
            WriteSummations(rowIndex);
            Save();
        }
    }
}
