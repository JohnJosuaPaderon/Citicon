using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportAllDriverTripReport : ExportExcelBase
    {
        public ExportAllDriverTripReport(TripReport tripReport)
        {
            _TripReport = tripReport;
            _Template = ConfigurationManager.AppSettings.GetString("TripReport.All.Template");
            _SaveDirectory = ConfigurationManager.AppSettings.GetString("TripReport.All.SaveDirectory");
        }

        private readonly TripReport _TripReport;
        private readonly string _Template;
        private readonly string _SaveDirectory;

        public override void Execute()
        {
            if (File.Exists(_Template))
            {
                if (_TripReport != null && _TripReport.Drivers.Count > 0)
                {
                    PrintOption = ExportExcelPrintOption.None;
                    Application = new Excel.Application();
                    Workbooks = Application.Workbooks;
                    Workbook = Workbooks.Open(_Template);
                    Sheets = Workbook.Sheets;
                    Worksheet = Sheets[1];

                    Worksheet.Cells[1, 1] = _TripReport.DeliveryDateRange.ToString();

                    var rowIndex = 3;
                    var range = default(Excel.Range);

                    foreach (var driver in _TripReport.Drivers)
                    {
                        range = Worksheet.Range[Worksheet.Cells[rowIndex, 1], Worksheet.Cells[rowIndex, 8]];
                        range.Merge();
                        range.Value = driver.Driver.ToString();
                        range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;

                        rowIndex++;

                        foreach (var tripDate in driver.TripDates)
                        {
                            foreach (var tripProject in tripDate.Projects)
                            {
                                range = Worksheet.Cells[rowIndex, 1];
                                range.Value = tripDate.DeliveryDate;

                                range = Worksheet.Cells[rowIndex, 2];
                                range.Value = tripProject.Project?.Name;

                                range = Worksheet.Cells[rowIndex, 3];
                                range.Value = tripProject.Deliveries.DeliveryReceiptNumberAggregate;

                                range = Worksheet.Cells[rowIndex, 4];
                                range.Value = tripProject.Deliveries.TransitMixer?.PhysicalNumber;

                                range = Worksheet.Cells[rowIndex, 5];
                                range.Value = tripProject.Project?.Location;

                                range = Worksheet.Cells[rowIndex, 6];
                                range.Value = tripProject.Deliveries.PricePerTrip;
                                range.NumberFormat = "#,##0.00";

                                range = Worksheet.Cells[rowIndex, 7];
                                range.Value = tripProject.Deliveries.TripCount;

                                range = Worksheet.Cells[rowIndex, 8];
                                range.Value = tripProject.Deliveries.TotalAmount;
                                range.NumberFormat = "#,##0.00";
                                
                                rowIndex++;
                            }
                        }
                    }
                }

                Directory.CreateDirectory(_SaveDirectory);
                var filePath = Path.Combine(_SaveDirectory, $"{DateTime.Now.ToString("yyyyMMdd-HHmm")}.xlsx");
                Workbook.SaveAs(filePath);
                base.Execute();
            }
        }
    }
}
