using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportOutgoingStockReport : ExportExcelBase
    {
        public ExportOutgoingStockReport(IEnumerable<OutgoingStock> outgoingStocks)
        {
            _OutgoingStocks = outgoingStocks;
            _Template = ConfigurationManager.AppSettings.GetString("OutgoingStockReport.Template");
            _SaveDirectory = ConfigurationManager.AppSettings.GetString("OutgoingStockReport.SaveDirectory");
            _FilePath = Path.Combine(_SaveDirectory, $"{DateTime.Now.ToString("yyyy.MM.dd_hh.mm")}.xlsx");
        }

        private readonly IEnumerable<OutgoingStock> _OutgoingStocks;
        private readonly string _Template;
        private readonly string _SaveDirectory;
        private readonly string _FilePath;

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

                foreach (var outgoingStock in _OutgoingStocks)
                {
                    if (outgoingStock != null)
                    {
                        Append(outgoingStock, row);
                        row++;
                    }
                }

                Directory.CreateDirectory(_SaveDirectory);
                Workbook.SaveAs(_FilePath);
            }

            base.Execute();
        }

        private void Append(OutgoingStock outgoingStock, int row)
        {
            Worksheet.Cells[row, 1] = outgoingStock.IssuanceSlipNumber;
            Worksheet.Cells[row, 2] = outgoingStock.Item?.Code;
            Worksheet.Cells[row, 3] = outgoingStock.Item?.Description;
            Worksheet.Cells[row, 4] = outgoingStock.Quantity;
            Worksheet.Cells[row, 5] = outgoingStock.MeasurementUnit?.Symbol;
            Worksheet.Cells[row, 6] = outgoingStock.UnitCost;
            Worksheet.Cells[row, 7] = outgoingStock.Supplier?.Description;
            Worksheet.Cells[row, 8] = outgoingStock.Vehicle?.PhysicalNumber;
            Worksheet.Cells[row, 9] = outgoingStock.TransactionDate;
        }
    }
}
