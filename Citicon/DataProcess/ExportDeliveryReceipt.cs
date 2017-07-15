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

                Worksheet.Cells[8, 2] = Delivery.Project?.Client?.CompanyName;
                Worksheet.Cells[8, 6] = Delivery.DeliveryDate;
                Worksheet.Cells[11, 6] = Delivery.Load;
                Worksheet.Cells[11, 8] = Delivery.TransitMixer?.PhysicalNumber;
                Worksheet.Cells[13, 2] = Delivery.Project?.Name;
                Worksheet.Cells[14, 6] = Delivery.Driver?.ToString();
                Worksheet.Cells[16, 1] = Delivery.Project?.Location;
                Worksheet.Cells[20, 2] = Delivery.ProjectDesign?.Strength?.ToString();
                Worksheet.Cells[20, 4] = Delivery.ProjectDesign?.Psi.ToString("###0");
                Worksheet.Cells[23, 4] = Delivery.ProjectDesign?.Aggregate?.ToString();
                Worksheet.Cells[23, 8] = Delivery.MaxSlump;
                Worksheet.Cells[28, 3] = Delivery.ProjectDesign?.MixType.ToString();
                Worksheet.Cells[31, 2] = Delivery.Admixture;
                Worksheet.Cells[31, 4] = Delivery.AdmixtureQuantity;
                Worksheet.Cells[36, 1] = Delivery.PlantLeave;

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
