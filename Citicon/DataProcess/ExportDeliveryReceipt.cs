using Citicon.Data;
using System;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportDeliveryReceipt : ExportExcelBase
    {
        static ExportDeliveryReceipt()
        {
            ResolveTemplate();
            ResolveSaveLocation();
        }

        public ExportDeliveryReceipt(Delivery delivery)
        {
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
            PrintOption = ExportExcelPrintOption.Workbook;
        }

        public static string Template { get; private set; }
        public static string SaveLocation { get; private set; }

        private static void ResolveTemplate()
        {
            if (string.IsNullOrWhiteSpace(Template))
            {
                Template = ConfigurationManager.AppSettings["DeliveryReceipt.Template"];
            }
        }

        private static void ResolveSaveLocation()
        {
            if (string.IsNullOrWhiteSpace(SaveLocation))
            {
                SaveLocation = ConfigurationManager.AppSettings["DeliveryReceipt.SaveLocation"];
            }
        }

        public Delivery Delivery { get; private set; }
        public string FilePath { get; private set; }

        public override void Execute()
        {
            if (File.Exists(Template))
            {
                Application = new Excel.Application();
                Workbooks = Application.Workbooks;
                Workbook = Workbooks.Open(Template);
                Sheets = Workbook.Sheets;
                Worksheet = Sheets[1];

                Worksheet.Cells[9, 2] = Delivery.Project?.Client?.CompanyName;
                Worksheet.Cells[9, 6] = Delivery.DeliveryDate.ToString("MMMM d, yyyy");
                Worksheet.Cells[12, 6] = Delivery.Load;
                Worksheet.Cells[12, 8] = Delivery.TransitMixer?.PhysicalNumber;
                Worksheet.Cells[14, 2] = Delivery.Project?.Name;
                Worksheet.Cells[15, 6] = Delivery.Driver?.FullName2;
                Worksheet.Cells[17, 1] = Delivery.Project?.Location;
                Worksheet.Cells[21, 2] = Delivery.ProjectDesign?.Strength?.ToString();
                Worksheet.Cells[21, 4] = Delivery.ProjectDesign?.Psi.ToString("###0");
                Worksheet.Cells[22, 8] = Delivery.Volume.ToString("#,##0.0");
                Worksheet.Cells[23, 2] = Delivery.CumulativeVolume.ToString("#,##0.0");
                Worksheet.Cells[24, 4] = Delivery.ProjectDesign?.Aggregate?.ToString();
                Worksheet.Cells[24, 8] = Delivery.MaxSlump;
                Worksheet.Cells[32, 2] = Delivery.Admixture;
                Worksheet.Cells[32, 4] = Delivery.AdmixtureQuantity;
                Worksheet.Cells[37, 1] = Delivery.PlantLeave?.ToString("HHmm");

                if (!Directory.Exists(SaveLocation))
                {
                    Directory.CreateDirectory(SaveLocation);
                }

                FilePath = Path.Combine(SaveLocation, string.Format("{0}.xlsx", Delivery.DeliveryReceiptNumberDisplay));
                Workbook.SaveAs(FilePath);

                base.Execute();
            }
        }

        public override void Dispose()
        {
            Delivery = null;
            base.Dispose();
        }
    }
}
