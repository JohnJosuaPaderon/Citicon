using Citicon.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

                            var rowIndex = 4;

                            Worksheet.Cells[1, 1] = driver.Driver?.ToString();
                            Worksheet.Cells[2, 1] = TripReport.DeliveryDateRange.ToString();

                            foreach (var tripDate in driver.TripDates)
                            {
                                var tripDateRowStartIndex = rowIndex;

                                range = Worksheet.Cells[tripDateRowStartIndex, 0];
                                range.Value = tripDate.DeliveryDate;
                                range.NumberFormat = "M//d//yy";

                                foreach (var tripClient in tripDate.Projects)
                                {
                                    var tripClientRowStartIndex = rowIndex;

                                    foreach (var tripRoute in tripClient.Deliveries)
                                    {
                                        var tripRouteRowStartIndex = rowIndex;

                                        

                                        var tripRouteRowEndIndex = rowIndex;
                                    }

                                    var tripClientRowEndIndex = rowIndex;
                                }

                                var tripDateRowEndIndex = rowIndex;
                            }
                        }
                    }

                    Application.DisplayAlerts = false;
                    Sheets[1].Delete();
                    Application.DisplayAlerts = true;
                    base.Execute();
                } 
            }
        }
    }
}
