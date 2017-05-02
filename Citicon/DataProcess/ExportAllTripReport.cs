using Citicon.Data;
using System;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportAllTripReport : ExportExcelBase
    {
        public ExportAllTripReport(TripReport tripReport)
        {
            TripReport = tripReport ?? throw new ArgumentNullException(nameof(tripReport));
            TemplatePath = ConfigurationManager.AppSettings["TripReport.All.Template"];
            SaveLocation = ConfigurationManager.AppSettings["TripReport.All.SaveLocation"];

            PrintOption = ExportExcelPrintOption.Workbook;
        }

        public TripReport TripReport { get; private set; }
        public string TemplatePath { get; private set; }
        public string SaveLocation { get; private set; }

        public override void Dispose()
        {
            TripReport = null;
            TemplatePath = null;
            base.Dispose();
        }

        public override void Execute()
        {
            if (File.Exists(TemplatePath))
            {
                Application = new Excel.Application();
                Workbooks = Application.Workbooks;
                Workbook = Workbooks.Open(TemplatePath);

                base.Execute();
            }
        }
    }
}
