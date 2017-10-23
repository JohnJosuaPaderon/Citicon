using Citicon.Data;
using System;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    public sealed class ExportTimeLogReport : ExportExcelBase
    {
        public ExportTimeLogReport(TimeLogReport data)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));
            PrintOption = ExportExcelPrintOption.None;
            SaveDirectory = ConfigurationManager.AppSettings["TimeLogReport.SaveDirectory"];
            TemplatePath = ConfigurationManager.AppSettings["TimeLogReport.TemplatePath"];
        }

        private TimeLogReport Data { get; }
        private string SaveDirectory { get; set; }
        private string TemplatePath { get; set; }
        public string FilePath { get; private set; }

        public override void Execute()
        {

            if (File.Exists(TemplatePath))
            {
                Application = new Excel.Application();
                Workbooks = Application.Workbooks;
                Workbook = Workbooks.Open(TemplatePath);
                Sheets = Workbook.Sheets;
                Worksheet = Sheets[1];

                Worksheet.Cells[1, 2] = Data.TimeLogRange.ToString();
                Excel.Range range = null;
                var currentRow = 1;

                foreach (var employeeTimeLogList in Data.EmployeeTimeLogLists)
                {
                    currentRow++;
                    var blockStart = currentRow;
                    range = Worksheet.Range[Worksheet.Cells[currentRow, 1], Worksheet.Cells[currentRow, 3]];
                    range.Merge();
                    range.Value = employeeTimeLogList.Owner?.ToString();

                    foreach (var timeLog in employeeTimeLogList.TimeLogs)
                    {
                        currentRow++;
                        range = Worksheet.Cells[currentRow, 1];
                        range.NumberFormat = "MMM dd, yyyy";
                        range.Value = timeLog.Login;

                        range = Worksheet.Cells[currentRow, 2];
                        //range.NumberFormat = "[hh]:mm";
                        range.Value = timeLog.Login;


                        range = Worksheet.Cells[currentRow, 3];
                        range.NumberFormat = "MMM dd, yyyy";
                        range.Value = timeLog.Logout;


                        range = Worksheet.Cells[currentRow, 4];
                        //range.NumberFormat = "[hh]:mm";
                        range.Value = timeLog.Logout;

                        //range = Worksheet.Cells[currentRow, 3];
                        //range.NumberFormat = "hh:mm:ss AM/PM";
                        //range.Value = timeLog.Logout;
                    }

                    var blockEnd = currentRow;

                    range = Worksheet.Range[Worksheet.Cells[blockStart, 1], Worksheet.Cells[blockEnd, 4]];
                    range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
                    range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
                }

                if (!Directory.Exists(SaveDirectory))
                {
                    Directory.CreateDirectory(SaveDirectory);
                }

                FilePath = Path.Combine(SaveDirectory, string.Format("{0:yyMMdd-hhmmss}.xlsx", DateTime.Now));

                Workbook.SaveAs(FilePath);
                base.Execute();
            }
        }
    }
}
