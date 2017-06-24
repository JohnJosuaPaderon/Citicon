using Citicon.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportChequeReport : ExportExcelBase
    {
        public ExportChequeReport(IEnumerable<ChequeSummaryItem> chequeSummaryItems)
        {
            ChequeSummaryItems = chequeSummaryItems;
            PrintOption = ExportExcelPrintOption.None;
            Template = ConfigurationManager.AppSettings["ChequeReport.Template"];
            SaveLocation = ConfigurationManager.AppSettings["ChequeReport.SaveLocation"];
        }

        private string Template { get; }
        private string SaveLocation { get; }
        private string FilePath { get; set; }

        private void ValidateSaveLocation()
        {
            if (!Directory.Exists(SaveLocation))
            {
                Directory.CreateDirectory(SaveLocation);
            }
        }

        private IEnumerable<ChequeSummaryItem> ChequeSummaryItems { get; }

        public override void Execute()
        {
            if (File.Exists(Template))
            {
                Application = new Excel.Application();
                Workbooks = Application.Workbooks;
                Workbook = Workbooks.Open(Template);
                Sheets = Workbook.Sheets;
                Worksheet = Sheets[1];

                var row = 1;

                foreach (var item in ChequeSummaryItems)
                {
                    if (item != null)
                    {
                        row++;
                        Append(item, row);
                    }
                }

                FilePath = Path.Combine(SaveLocation, string.Format("{0}.xlsx", DateTime.Now.ToString("yyMMddhhmmss")));
                ValidateSaveLocation();
                Workbook.SaveAs(FilePath);

                base.Execute();
            }
        }

        private void Append(ChequeSummaryItem item, int row)
        {
            Worksheet.Cells[row, 1] = item.ChequeNumbber;
            Worksheet.Cells[row, 2] = item.ChequeDate;
            Worksheet.Cells[row, 3] = item.TransactionDate;
            Worksheet.Cells[row, 4] = item.Supplier?.Description;
            Worksheet.Cells[row, 5] = item.BankAccount?.Bank?.Description;
            Worksheet.Cells[row, 6] = item.BankAccount?.Description;
            Worksheet.Cells[row, 7] = item.TotalAmount;
        }
    }
}
