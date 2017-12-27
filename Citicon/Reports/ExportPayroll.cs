using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.Reports
{
    internal sealed class ExportPayroll
    {
        public ExportPayroll(Payroll payroll)
        {
            Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
            PayrollGroupManager = new PayrollGroupManager();
            Configuration = new SemiMonthlyPayrollExportConfiguration();
        }

        private SemiMonthlyPayrollExportConfiguration Configuration { get; set; }
        private PayrollGroupManager PayrollGroupManager;
        private Excel.Application Application;
        private Excel.Workbooks Workbooks;
        private Excel.Workbook Workbook;
        private Excel.Sheets Sheets;
        private Excel.Worksheet Worksheet;
        private int CurrentRowIndex;
        public Payroll Payroll { get; private set; }
        private string SaveFile;
        private const string DefaultNumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \" - \"??_);_(@_)";

        private void Initialize()
        {
            var application = new Excel.Application();
            Workbooks = application.Workbooks;
            Workbook = Workbooks.Open(Configuration.TemplateFile);
            Sheets = Workbook.Sheets;
            Worksheet = Sheets[1];
            var fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            SaveFile = Path.Combine(Configuration.SaveDirectory, string.Concat(fileName, ".xlsx"));
        }

        private void SetCellValues(EmployeePayroll payrollItem)
        {
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Employee, payrollItem.Employee?.ToString());
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.VLSL, payrollItem.VLSL);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Rate, payrollItem.DailyRate);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Basic_Pay, payrollItem.BasicPay);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Regular_Working_Hours, payrollItem.RegularWorkingHours);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.ND_OT_Hours, payrollItem.NightDifferentialHours);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Sunday_Hours, payrollItem.SundayHours);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Hours, payrollItem.SpecialHolidayHours);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Overtime_Hours, payrollItem.SpecialHolidayOvertimeHours);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.With_Holding_Tax, payrollItem.WithholdingTax);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Overtime_Allowance, 0);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Allowance, 0);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS, 0);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS_Loan, 0);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Pagibig_Loan, 0);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Cash_Advance, 0);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Sun_Cell_Bill, 0);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS_EC, payrollItem.SSSEC);
            SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS_ER, payrollItem.SSSER);
        }

        private void SetCellFormulaValues()
        {
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Regular_Overtime_Pay);
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.NT_125_Percent);
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Sunday_Pay);
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Pay);
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Overtime_Pay);
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Gross_Pay);
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Total_Deduction);
            SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Net_Pay);
        }

        private void SetSumFormulas(int startRowIndex, int endRowIndex)
        {
            CurrentRowIndex++;
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Rate, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Basic_Pay, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Regular_Working_Hours, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Regular_Overtime_Pay, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.ND_OT_Hours, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.NT_125_Percent, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Sunday_Hours, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Sunday_Pay, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Hours, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Pay, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Overtime_Hours, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Special_Holiday_Overtime_Pay, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Allowance, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Overtime_Allowance, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Gross_Pay, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.With_Holding_Tax, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS_Loan, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Pagibig_Loan, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Cash_Advance, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Sun_Cell_Bill, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Total_Deduction, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.Net_Pay, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS_EC, startRowIndex, endRowIndex);
            SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex.SSS_ER, startRowIndex, endRowIndex);
        }

        private void SetSumFormula(SemiMonthlyPayrollExportConfigurationColumnIndex columnIndex, int startRowIndex, int endRowIndex)
        {
            SetCellValue(columnIndex, Configuration.SumFormula(columnIndex, startRowIndex, endRowIndex));
        }

        private void SetHeaders()
        {
            SetCellValue(Configuration.BranchCell, Payroll.Branch?.Description);
            SetCellValue(Configuration.PayrollRangeCell, Payroll.DateRange?.ToString());
        }

        public async Task ExportAsync()
        {
            await Task.Run(async() =>
            {
                Initialize();

                try
                {
                    SetHeaders();

                    var rowMargin = Configuration.PayrollItemsRowMargin;


                    var enumerable = await PayrollGroupManager.GetListAsync();
                    var list = enumerable.OrderBy(p => p.SortCode);

                    var groupItems = new Dictionary<PayrollGroup, List<EmployeePayroll>>();

                    foreach (var item in list)
                    {
                        groupItems.Add(item, new List<EmployeePayroll>());
                    }

                    //Payroll.Employees.Sort((x, y) => string.Compare(x.Employee.ToString(), y.Employee.ToString()));

                    foreach (var item in Payroll.Employees)
                    {
                        groupItems[item.Group].Add(item);
                    }

                    int employeeCounter = 1;

                    CurrentRowIndex = rowMargin;

                    foreach (var item in groupItems)
                    {
                        if (item.Value.Count > 0)
                        {
                            CurrentRowIndex++;
                            SetGroupHeader(item.Key);

                            foreach (var groupItem in groupItems[item.Key])
                            {
                                CurrentRowIndex++;
                                SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Counter, employeeCounter++, "#,##0");
                                SetCellValues(groupItem);
                                SetCellFormulaValues();
                            }
                        }
                    }

                    SetSumFormulas(rowMargin, CurrentRowIndex);

                    //for (int i = 1; i <= Payroll.Items.Count; i++)
                    //{
                    //    CurrentRowIndex = rowMargin + i;
                    //    SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex.Counter, i, "#,##0");
                    //    SetCellValues(Payroll.Items[i - 1]);
                    //    SetCellFormulaValues();
                    //}

                    Workbook.SaveAs(SaveFile);
                    Workbook.PrintOutEx();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Clean();
                }
            });
        }

        private void SetGroupHeader(PayrollGroup payrollGroup)
        {
            Excel.Range cell = Worksheet.Cells[CurrentRowIndex, Configuration.ColumnIndex(SemiMonthlyPayrollExportConfigurationColumnIndex.Employee)];
            cell.Value = payrollGroup.Description;
            cell.Font.Bold = true;
        }

        private void SetCellFormulaValue(SemiMonthlyPayrollExportConfigurationColumnIndex columnIndex)
        {
            Excel.Range cell = Worksheet.Cells[CurrentRowIndex, Configuration.ColumnIndex(columnIndex)];
            cell.Font.Color = Configuration.GetCellFontColor(columnIndex);
            cell.NumberFormatLocal = DefaultNumberFormat;
            cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            cell.Formula = Configuration.Formula(columnIndex, CurrentRowIndex);
        }

        private void SetCellValue(ExcelCell cell, object value)
        {
            Excel.Range range = Worksheet.Cells[cell.RowIndex, cell.ColumnIndex];
            range.NumberFormatLocal = DefaultNumberFormat;
            range.Value = value;
        }

        private void SetCellValue(SemiMonthlyPayrollExportConfigurationColumnIndex columnIndex, object value, string numberFormat = DefaultNumberFormat)
        {
            Excel.Range range = Worksheet.Cells[CurrentRowIndex, Configuration.ColumnIndex(columnIndex)];
            range.Font.Color = Configuration.GetCellFontColor(columnIndex);
            range.NumberFormatLocal = numberFormat;
            range.Value = value;
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
