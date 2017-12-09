using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportStockReport : ExportExcelBase
    {
        public ExportStockReport(IEnumerable<Stock> stocks)
        {
            _Stocks = stocks;
            _Template = ConfigurationManager.AppSettings.GetString("StocksReport.Template");
            _SaveDirectory = ConfigurationManager.AppSettings.GetString("StocksReport.SaveDirectory");
            _FilePath = Path.Combine(_SaveDirectory, $"{DateTime.Now.ToString("yyyy.MM.dd_hh.mm")}.xlsx");
        }

        private readonly string _Template;
        private readonly string _SaveDirectory;
        private readonly string _FilePath;
        private readonly IEnumerable<Stock> _Stocks;

        public override void Execute()
        {
            if (File.Exists(_Template))
            {
                Application = new Excel.Application();
                Workbooks = Application.Workbooks;
                Workbook = Workbooks.Open(_Template);
                Sheets = Workbook.Sheets;
                Worksheet = Sheets[1];

                var row = 2;

                foreach (var stock in _Stocks)
                {
                    if (stock != null)
                    {
                        Append(stock, row);
                        row++;
                    }
                }

                if (!Directory.Exists(_SaveDirectory))
                {
                    Directory.CreateDirectory(_SaveDirectory);
                }

                Workbook.SaveAs(_FilePath);
            }

            base.Execute();
        }

        private void Append(Stock stock, int row)
        {
            Worksheet.Cells[row, 1] = stock.Item?.Description;
            Worksheet.Cells[row, 2] = stock.Item?.Code;
            Worksheet.Cells[row, 3] = stock.DeliveryDate;
            Worksheet.Cells[row, 4] = stock.SiNumber;
            Worksheet.Cells[row, 5] = stock.DrNumber;
            Worksheet.Cells[row, 6] = stock.MrisNumber;
            Worksheet.Cells[row, 7] = stock.AddedStockValue;
            Worksheet.Cells[row, 8] = stock.UnitPrice;
            Worksheet.Cells[row, 9] = stock.PaymentTerm?.Description;
            Worksheet.Cells[row, 10] = stock.Branch?.Description;
            Worksheet.Cells[row, 11] = stock.Company?.Description;
            Worksheet.Cells[row, 12] = stock.Supplier?.Description;
        }
    }
}
