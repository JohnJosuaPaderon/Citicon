using Citicon.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.Reports
{
    internal sealed class ExportPayroll
    {
        public ExportPayroll(Payroll payroll)
        {
            if (payroll == null)
            {
                throw new ArgumentNullException(nameof(payroll));
            }

            Payroll = payroll;
            Configuration = new SemiMonthlyPayrollExportConfiguration();
        }

        private SemiMonthlyPayrollExportConfiguration Configuration { get; set; }
        private Excel.Application Application;
        private Excel.Workbooks Workbooks;
        private Excel.Workbook Workbook;
        private Excel.Sheets Sheets;
        private Excel.Worksheet Worksheet;
        private int CurrentRowIndex;
        public Payroll Payroll { get; private set; }

        public void Export()
        {
            var application = new Excel.Application();
            Workbooks = application.Workbooks;
            Workbook = Workbooks.Open(Configuration.TemplateFile);
            Sheets = Workbook.Sheets;
            Worksheet = Sheets[1];
            var fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            var file = Path.Combine(Configuration.SaveDirectory, string.Concat(fileName, ".xlsx"));

            try
            {
                SetCellValue(Configuration.BranchCell, Payroll.Branch?.Description);
                SetCellValue(Configuration.PayrollRangeCell, Payroll.DateRange?.ToString());

                var rowMargin = Configuration.PayrollItemsRowMargin;

                for (int i = 1; i <= Payroll.Items.Count; i++)
                {
                    CurrentRowIndex = rowMargin + i;
                    var payrollItem = Payroll.Items[i - 1];
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Counter, i);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Employee, payrollItem.Employee?.ToString());
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.VLSL, payrollItem.VLSL);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Rate, payrollItem.DailyRate);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Basic_Pay, payrollItem.BasicPay);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Regular_Working_Hours, payrollItem.RegularWorkingHours);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Regular_Overtime_Pay);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.ND_OT_Hours, payrollItem.NightDifferentialHours);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.NT_125_Percent);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Sunday_Hours, payrollItem.SundayHours);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Sunday_Pay);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Hours, payrollItem.SpecialHolidayHours);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Pay);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Overtime_Hours, payrollItem.SpecialHolidayOvertimeHours);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Overtime_Pay);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Overtime_Allowance, 0);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Allowance, 0);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Gross_Pay);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.With_Holding_Tax, payrollItem.WithHoldingTax);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS, 0);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS_Loan, 0);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Pagibig_Loan, 0);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Cash_Advance, 0);
                    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Sun_Cell_Bill, 0);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Total_Deduction);
                    SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Net_Pay);
                }

                Workbook.SaveAs(file);
                Workbook.PrintOutEx();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Clean();

                //if (File.Exists(file))
                //{
                //    var startInfo = new ProcessStartInfo();
                //    startInfo.FileName = file;
                //    startInfo.Verb = "print";
                //    startInfo.CreateNoWindow = false;
                //    startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                //    Process.Start(startInfo);
                //}
            }
        }

        private void SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex columnIndex)
        {
            Excel.Range cell = Worksheet.Cells[CurrentRowIndex, Configuration.ColumnIndex(columnIndex)];
            cell.NumberFormatLocal = "_(* #,##0.00_);_(* (#,##0.00);_(* \" - \"??_);_(@_)";
            cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            cell.Formula = Configuration.Formula(columnIndex, CurrentRowIndex);
        }

        private void SetCellValue(ExcelCell cell, object value)
        {
            Excel.Range range = Worksheet.Cells[cell.RowIndex, cell.ColumnIndex];
            range.NumberFormatLocal = "_(* #,##0.00_);_(* (#,##0.00);_(* \" - \"??_);_(@_)";
            range.Value = value;
        }

        private void SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex columnIndex, object value)
        {
            Worksheet.Cells[CurrentRowIndex, Configuration.ColumnIndex(columnIndex)] = value;
        }

        public void Clean()
        {
            Configuration = null;
            Payroll = null;

            if (Worksheet != null)
            {
                Marshal.ReleaseComObject(Worksheet);
                Worksheet = null;
            }

            if (Sheets != null)
            {
                Marshal.ReleaseComObject(Sheets);
                Sheets = null;
            }

            if (Workbook != null)
            {
                Workbook.Close();
                Marshal.ReleaseComObject(Workbook);
                Workbook = null;
            }

            if (Workbooks != null)
            {
                Workbooks.Close();
                Marshal.ReleaseComObject(Workbooks);
                Workbooks = null;
            }

            if (Application != null)
            {
                Application.Quit();
                Marshal.ReleaseComObject(Application);
                Application = null;
            }
        }
    }
}
