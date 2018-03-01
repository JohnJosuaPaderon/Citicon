using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportWeeklyPaySlip : ExportExcelBase
    {
        private const string CONFIG_PREFIX = "PaySlip.Weekly";

        public ExportWeeklyPaySlip(WeeklyPayroll payroll, IEnumerable<WeeklyPayrollEmployee> payrollEmployees)
        {
            _Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
            _PayrollEmployees = new WeeklyPayrollEmployeeCollection(payrollEmployees);
            _TemplatePath = GetStringFromConfig("TemplatePath");
            _SaveDirectory = GetStringFromConfig("SaveDirectory");
            _BranchCell = GetCellFromConfig("Branch");
            _EmployeeCell = GetCellFromConfig("Employee");
            _BasicPayCell = GetCellFromConfig("BasicPay");
            _OvertimePayCell = GetCellFromConfig("OvertimePay");
            _NightDifferentialPayCell = GetCellFromConfig("NightDifferentialPay");
            _SundayPayCell = GetCellFromConfig("SundayPay");
            _HolidayPayCell = GetCellFromConfig("HolidayPay");
            _HolidayOvertimePayCell = GetCellFromConfig("HolidayOvertimePay");
            _AllowanceCell = GetCellFromConfig("Allowance");
            _OvertimeAllowanceCell = GetCellFromConfig("OvertimeAllowance");
            _WithholdingTaxCell = GetCellFromConfig("WithholdingTax");
            _SssCell = GetCellFromConfig("Sss");
            _SssEcCell = GetCellFromConfig("SssEc");
            _SssErCell = GetCellFromConfig("SssEr");
            _PagibigCell = GetCellFromConfig("Pagibig");
            _PhilHealthCell = GetCellFromConfig("PhilHealth");
            _CashAdvanceCell = GetCellFromConfig("CashAdvance");
            _OthersCell = GetCellFromConfig("Others");
            _GrossPayCell = GetCellFromConfig("GrossPay");
            _TotalDeductionCell = GetCellFromConfig("TotalDeduction");
            _NetPayCell = GetCellFromConfig("NetPay");
            _ItemPerPageRow = GetInt32FromConfig("ItemPerPageRow");
            _ItemPerPageColumn = GetInt32FromConfig("ItemPerPageColumn");
            _PageRowSkipped = GetInt32FromConfig("PageRowSkipped");
            _ItemTotalRow = GetInt32FromConfig("ItemTotalRow");
            _ItemTotalColumn = GetInt32FromConfig("ItemTotalColumn");
            _TopLeftCell = GetCellFromConfig("TopLeft");
            _BottomRightCell = GetCellFromConfig("BottomRight");
        }

        private readonly WeeklyPayroll _Payroll;
        private readonly WeeklyPayrollEmployeeCollection _PayrollEmployees;
        private readonly string _TemplatePath;
        private readonly string _SaveDirectory;
        private readonly ExcelCell _BranchCell;
        private readonly ExcelCell _EmployeeCell;
        private readonly ExcelCell _BasicPayCell;
        private readonly ExcelCell _OvertimePayCell;
        private readonly ExcelCell _NightDifferentialPayCell;
        private readonly ExcelCell _SundayPayCell;
        private readonly ExcelCell _HolidayPayCell;
        private readonly ExcelCell _HolidayOvertimePayCell;
        private readonly ExcelCell _AllowanceCell;
        private readonly ExcelCell _OvertimeAllowanceCell;
        private readonly ExcelCell _WithholdingTaxCell;
        private readonly ExcelCell _SssCell;
        private readonly ExcelCell _SssEcCell;
        private readonly ExcelCell _SssErCell;
        private readonly ExcelCell _PagibigCell;
        private readonly ExcelCell _PhilHealthCell;
        private readonly ExcelCell _CashAdvanceCell;
        private readonly ExcelCell _OthersCell;
        private readonly ExcelCell _GrossPayCell;
        private readonly ExcelCell _TotalDeductionCell;
        private readonly ExcelCell _NetPayCell;
        private readonly ExcelCell _TopLeftCell;
        private readonly ExcelCell _BottomRightCell;
        private readonly int _PageRowSkipped;
        private readonly int _ItemPerPageRow;
        private readonly int _ItemPerPageColumn;
        private readonly int _ItemTotalRow;
        private readonly int _ItemTotalColumn;

        private string GetStringFromConfig(string key)
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
                throw new FileNotFoundException("Semi-Monthly Pay Slip not found.", _TemplatePath);
            }
        }

        private void Write()
        {
            var pageRowItemCount = 0;
            var pageColumnItemCount = 0;

            foreach (var payrollEmployee in _PayrollEmployees)
            {
                pageColumnItemCount++;

                Write(payrollEmployee);
                var sourceRange = GetRange(_TopLeftCell, _BottomRightCell);

                if (pageColumnItemCount >= _ItemPerPageColumn)
                {
                    pageRowItemCount++;
                    pageColumnItemCount = 0;
                    AddRowPadding(_ItemTotalRow);
                    AddColumnPadding(-(_ItemPerPageColumn * _ItemTotalColumn));
                }

                if (pageRowItemCount >= _ItemPerPageRow)
                {
                    pageRowItemCount = 0;
                    AddRowPadding(_PageRowSkipped);
                }

                AddColumnPadding(_ItemTotalColumn);
                var destinationRange = GetRange(_TopLeftCell, _BottomRightCell);
                sourceRange.Copy(destinationRange);
            }
        }

        private void AddRowPadding(int rowPadding)
        {
            AddRowPadding(_BranchCell, rowPadding);
            AddRowPadding(_EmployeeCell, rowPadding);
            AddRowPadding(_BasicPayCell, rowPadding);
            AddRowPadding(_OvertimePayCell, rowPadding);
            AddRowPadding(_NightDifferentialPayCell, rowPadding);
            AddRowPadding(_SundayPayCell, rowPadding);
            AddRowPadding(_HolidayPayCell, rowPadding);
            AddRowPadding(_HolidayOvertimePayCell, rowPadding);
            AddRowPadding(_AllowanceCell, rowPadding);
            AddRowPadding(_OvertimeAllowanceCell, rowPadding);
            AddRowPadding(_WithholdingTaxCell, rowPadding);
            AddRowPadding(_SssCell, rowPadding);
            AddRowPadding(_SssEcCell, rowPadding);
            AddRowPadding(_SssErCell, rowPadding);
            AddRowPadding(_PagibigCell, rowPadding);
            AddRowPadding(_PhilHealthCell, rowPadding);
            AddRowPadding(_CashAdvanceCell, rowPadding);
            AddRowPadding(_OthersCell, rowPadding);
            AddRowPadding(_GrossPayCell, rowPadding);
            AddRowPadding(_TotalDeductionCell, rowPadding);
            AddRowPadding(_NetPayCell, rowPadding);
            AddRowPadding(_TopLeftCell, rowPadding);
            AddRowPadding(_BottomRightCell, rowPadding);
        }

        private void AddColumnPadding(int columnPadding)
        {
            AddColumnPadding(_BranchCell, columnPadding);
            AddColumnPadding(_EmployeeCell, columnPadding);
            AddColumnPadding(_BasicPayCell, columnPadding);
            AddColumnPadding(_OvertimePayCell, columnPadding);
            AddColumnPadding(_NightDifferentialPayCell, columnPadding);
            AddColumnPadding(_SundayPayCell, columnPadding);
            AddColumnPadding(_HolidayPayCell, columnPadding);
            AddColumnPadding(_HolidayOvertimePayCell, columnPadding);
            AddColumnPadding(_AllowanceCell, columnPadding);
            AddColumnPadding(_OvertimeAllowanceCell, columnPadding);
            AddColumnPadding(_WithholdingTaxCell, columnPadding);
            AddColumnPadding(_SssCell, columnPadding);
            AddColumnPadding(_SssEcCell, columnPadding);
            AddColumnPadding(_SssErCell, columnPadding);
            AddColumnPadding(_PagibigCell, columnPadding);
            AddColumnPadding(_PhilHealthCell, columnPadding);
            AddColumnPadding(_CashAdvanceCell, columnPadding);
            AddColumnPadding(_OthersCell, columnPadding);
            AddColumnPadding(_GrossPayCell, columnPadding);
            AddColumnPadding(_TotalDeductionCell, columnPadding);
            AddColumnPadding(_NetPayCell, columnPadding);
            AddColumnPadding(_TopLeftCell, columnPadding);
            AddColumnPadding(_BottomRightCell, columnPadding);
        }

        private void AddColumnPadding(ExcelCell cell, int columnPadding)
        {
            cell.ColumnIndex += columnPadding;
        }

        private void AddRowPadding(ExcelCell cell, int rowPadding)
        {
            cell.RowIndex += rowPadding;
        }

        private void Write(WeeklyPayrollEmployee payrollEmployee)
        {
            Write(_BranchCell, _Payroll.Branch?.Description);
            Write(_EmployeeCell, payrollEmployee.Employee?.FullName);
            Write(_BasicPayCell, payrollEmployee.BasicPay);
            Write(_OvertimePayCell, payrollEmployee.RegularOvertimePay);
            Write(_NightDifferentialPayCell, payrollEmployee.NightDifferentialPay);
            Write(_SundayPayCell, payrollEmployee.SundayPay);
            Write(_HolidayPayCell, payrollEmployee.SpecialHolidayPay);
            Write(_HolidayOvertimePayCell, payrollEmployee.SpecialHolidayOvertimePay);
            Write(_AllowanceCell, payrollEmployee.Allowance);
            Write(_OvertimeAllowanceCell, payrollEmployee.OvertimeAllowance);
            Write(_WithholdingTaxCell, payrollEmployee.WithholdingTax);
            Write(_SssCell, payrollEmployee.Sss);
            Write(_SssEcCell, payrollEmployee.SssEc);
            Write(_SssErCell, payrollEmployee.SssEr);
            Write(_PagibigCell, payrollEmployee.Pagibig);
            Write(_PhilHealthCell, payrollEmployee.PhilHealth);
            Write(_CashAdvanceCell, payrollEmployee.CashAdvance);
            Write(_OthersCell, payrollEmployee.Others);
            Write(_GrossPayCell, payrollEmployee.GrossPay);
            Write(_TotalDeductionCell, payrollEmployee.TotalDeduction);
            Write(_NetPayCell, payrollEmployee.NetPay);
        }

        private void Write(ExcelCell cell, object value)
        {
            Excel.Range range = GetRange(cell);
            range.Value = value;
        }

        private Excel.Range GetRange(ExcelCell cell)
        {
            var result = Worksheet.Cells[cell.RowIndex, cell.ColumnIndex];
            return result;
        }

        private Excel.Range GetRange(ExcelCell from, ExcelCell to)
        {
            var result = Worksheet.Range[GetRange(from), GetRange(to)];
            return result;
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
            Write();
            Save();
        }
    }
}
