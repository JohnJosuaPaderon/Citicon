using Citicon.Data;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{

    internal sealed class ExportDriverTripReport : ExportExcelBase
    {
        public ExportDriverTripReport(TripReport tripReport)
        {
            TripReport = tripReport ?? throw new ArgumentNullException(nameof(tripReport));
            TemplatePath = ConfigurationManager.AppSettings["TripReport.Driver.TemplatePath"];
            SaveLocation = ConfigurationManager.AppSettings["TripReport.Driver.SaveLocation"];
        }

        public TripReport TripReport { get; private set; }
        public string TemplatePath { get; private set; }
        public string SaveLocation { get; private set; }

        public override void Dispose()
        {
            TripReport = null;
            TemplatePath = null;
            SaveLocation = null;
            base.Dispose();
        }

        public override void Execute()
        {
            if (File.Exists(TemplatePath))
            {
                if (TripReport != null && TripReport.Drivers.Count == 1)
                {
                    PrintOption = ExportExcelPrintOption.Workbook;
                    Application = new Excel.Application();
                    Workbooks = Application.Workbooks;
                    Workbook = Workbooks.Open(TemplatePath);
                    Sheets = Workbook.Sheets;

                    Excel.Range range = null;

                    foreach (var driver in TripReport.Drivers)
                    {
                        if (driver != null)
                        {
                            Sheets.Copy(Missing.Value, Sheets[1]);
                            Worksheet = Sheets[Sheets.Count];
                            Worksheet.Name = driver.Driver.Id.ToString("000000");

                            var rowIndex = 4;

                            Worksheet.Cells[1, 1] = driver.Driver?.ToString();
                            Worksheet.Cells[2, 1] = TripReport.DeliveryDateRange.ToString();

                            var alternate = false;
                            foreach (var tripDate in driver.TripDates)
                            {
                                var tripDateRowStartIndex = rowIndex;

                                range = Worksheet.Cells[tripDateRowStartIndex, 1];
                                range.Value = tripDate.DeliveryDate;
                                range.NumberFormat = "MMM. dd, yyyy";

                                foreach (var tripProject in tripDate.Projects)
                                {
                                    var tripProjectRowStartIndex = rowIndex;

                                    range = Worksheet.Cells[tripProjectRowStartIndex, 2];
                                    range.Value = tripProject.Project?.Name;

                                    range = Worksheet.Cells[tripProjectRowStartIndex, 3];
                                    range.Value = tripProject.Deliveries.DeliveryReceiptNumberAggregate;

                                    range = Worksheet.Cells[tripProjectRowStartIndex, 4];
                                    range.Value = tripProject.Deliveries.TransitMixer?.PhysicalNumber;

                                    range = Worksheet.Cells[tripProjectRowStartIndex, 5];
                                    range.Value = tripProject.Project?.Location;

                                    range = Worksheet.Cells[tripProjectRowStartIndex, 6];
                                    range.Value = tripProject.Deliveries.PricePerTrip;
                                    range.NumberFormat = "#,##0.00";

                                    range = Worksheet.Cells[tripProjectRowStartIndex, 7];
                                    range.Value = tripProject.Deliveries.TripCount;

                                    range = Worksheet.Cells[tripProjectRowStartIndex, 8];
                                    range.Value = tripProject.Deliveries.TotalAmount;
                                    range.NumberFormat = "#,##0.00";

                                    var tripProjectRowEndIndex = rowIndex;
                                    rowIndex++;
                                }

                                var tripDateRowEndIndex = rowIndex - 1;

                                if (alternate)
                                {
                                    range = Worksheet.Range[Worksheet.Cells[tripDateRowStartIndex, 1], Worksheet.Cells[tripDateRowEndIndex, 8]];
                                    range.Interior.Color = Supports.ExcelColorConverter("#FFEFEFEF");
                                }

                                alternate = !alternate;
                            }
                        }
                    }

                    if (!Directory.Exists(SaveLocation))
                    {
                        Directory.CreateDirectory(SaveLocation);
                    }

                    Application.DisplayAlerts = false;
                    Sheets[1].Delete();
                    Application.DisplayAlerts = true;

                    Workbook.SaveAs(Path.Combine(SaveLocation, string.Format("{0:yyyyMMddhhmm}.xlsx", DateTime.Now)));
                    base.Execute();
                } 
            }
        }
    }
}
