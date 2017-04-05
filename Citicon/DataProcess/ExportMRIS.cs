using Citicon.Data;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportMRIS : ExportExcelBase
    {
        public ExportMRIS(MRISReport mris)
        {
            MRIS = mris;
            MRISReportTemplate = ConfigurationManager.AppSettings["MrisReportTemplateV2"];
            MRISReportDirectory = ConfigurationManager.AppSettings["MrisReportDirectoryV2"];
        }

        private MRISReport MRIS { get; set; }
        private string MRISReportTemplate { get; set; }
        private string MRISReportDirectory { get; set; }

        public override void Dispose()
        {
            MRIS = null;
            MRISReportTemplate = null;
            MRISReportDirectory = null;
            base.Dispose();
        }

        private string InjectMap(string value)
        {
            return string.Format("MRISReport.{0}", value);
        }

        private string InjectMap_Location(string value)
        {
            return InjectMap(string.Format("Location[{0}]", value));
        }

        private string InjectMap_MaxCount(string value)
        {
            return InjectMap(string.Format("MaxCount[{0}]", value));
        }

        private string InjectMap_ColumnIndex(string value)
        {
            return InjectMap(string.Format("ColumnIndex[{0}]", value));
        }

        private string InjectMap_RowIndex(string value)
        {
            return InjectMap(string.Format("RowIndex[{0}]", value));
        }

        private int GetColumnIndex(string key)
        {
            int.TryParse(ConfigurationManager.AppSettings[InjectMap_ColumnIndex(key)], out int result);

            return result > 0 ? result : 1;
        }

        private int GetRowIndex(string key)
        {
            int.TryParse(ConfigurationManager.AppSettings[InjectMap_RowIndex(key)], out int result);

            return result > 0 ? result : 1;
        }

        private int GetMaxCount(string key)
        {
            int.TryParse(ConfigurationManager.AppSettings[InjectMap_MaxCount(key)], out int result);
            return result;
        }

        private Point GetLocation(string key)
        {
            var locationRaw = ConfigurationManager.AppSettings[InjectMap_Location(key)];

            if (!string.IsNullOrWhiteSpace(locationRaw) && locationRaw.Contains(","))
            {
                var splitted = locationRaw.Split(',');

                if (splitted.Length == 2)
                {
                    int.TryParse(splitted[0], out int row);
                    int.TryParse(splitted[1], out int column);

                    return new Point(row, column);
                }
                else
                {
                    return new Point(1, 1);
                }
            }
            else
            {
                return new Point(1, 1);
            }
        }

        private void SetCellValue(Point location, object value)
        {
            Worksheet.Cells[location.X, location.Y] = value;
        }

        public override void Execute()
        {
            PrintOption = ExportExcelPrintOption.Workbook;

            Application = new Excel.Application();
            Workbooks = Application.Workbooks;
            Workbook = Workbooks.Open(MRISReportTemplate);
            Sheets = Workbook.Sheets;
            Worksheet = Sheets[1];

            SetCellValue(GetLocation("Payee"), MRIS.Supplier?.ToString());
            SetCellValue(GetLocation("Date"), MRIS.DeliveryDate);
            SetCellValue(GetLocation("MRISNumber"), MRIS.MRISNumber);
            SetCellValue(GetLocation("Usage"), MRIS.Usage);
            SetCellValue(GetLocation("ReceivedBy"), MRIS.ReceivedStoredBy);
            SetCellValue(GetLocation("InspectedBy"), MRIS.InspectedAcceptedBy);
            SetCellValue(GetLocation("ApprovedBy"), MRIS.ApprovedBy);

            var rowStart = GetRowIndex("ItemStart");
            var usedRow = 0;
            var maxCount = GetMaxCount("Item");
            var counterColumnIndex = GetColumnIndex("Counter");
            var sidrColumnIndex = GetColumnIndex("SIDR");
            var codeColumnIndex = GetColumnIndex("Code");
            var descriptionColumnIndex = GetColumnIndex("Description");
            var measurementUnitColumnIndex = GetColumnIndex("MeasurementUnit");
            var stockValueColumnIndex = GetColumnIndex("StockValue");
            var unitPriceColumnIndex = GetColumnIndex("UnitPrice");
            var amountColumnIndex = GetColumnIndex("Amount");

            decimal totalQuantity = 0;
            decimal totalVAT = 0;
            decimal grandTotal = 0;

            int rowIndex = usedRow + rowStart;

            foreach (var item in MRIS.Stocks)
            {
                rowIndex = rowStart + usedRow;

                if (usedRow >= maxCount)
                {
                    break;
                }

                totalQuantity += item.AddedStockValue;
                grandTotal += item.TotalAmount;
                totalVAT += item.TotalVAT;

                SetCellValue(new Point(rowIndex, counterColumnIndex), usedRow + 1);
                SetCellValue(new Point(rowIndex, sidrColumnIndex), item.SIDR);
                SetCellValue(new Point(rowIndex, codeColumnIndex), item.Item?.Code);
                SetCellValue(new Point(rowIndex, descriptionColumnIndex), item.ReportDescription);
                SetCellValue(new Point(rowIndex, measurementUnitColumnIndex), item.Item?.MeasurementUnit?.Symbol);
                SetCellValue(new Point(rowIndex, stockValueColumnIndex), item.AddedStockValue);
                SetCellValue(new Point(rowIndex, unitPriceColumnIndex), item.UnitPrice);
                SetCellValue(new Point(rowIndex, amountColumnIndex), item.TotalAmount);

                usedRow++;
            }

            rowIndex++;

            Excel.Range totalQuantityRange = Worksheet.Cells[rowIndex, stockValueColumnIndex];
            totalQuantityRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
            totalQuantityRange.Value = totalQuantity;

            Excel.Range grandTotalRange = Worksheet.Cells[rowIndex, amountColumnIndex];
            grandTotalRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
            grandTotalRange.Value = grandTotal;

            rowIndex += 2;

            Worksheet.Cells[rowIndex, unitPriceColumnIndex] = "VAT";
            Worksheet.Cells[rowIndex, amountColumnIndex] = totalVAT;

            rowIndex++;

            Worksheet.Cells[rowIndex, unitPriceColumnIndex] = "Net Amount";
            Worksheet.Cells[rowIndex, amountColumnIndex] = grandTotal - totalVAT;

            rowIndex++;

            Worksheet.Cells[rowIndex, unitPriceColumnIndex] = "Total Amount Due";
            Worksheet.Cells[rowIndex, amountColumnIndex] = grandTotal;

            if (!Directory.Exists(MRISReportDirectory))
            {
                Directory.CreateDirectory(MRISReportDirectory);
            }

            var fileName = Path.Combine(MRISReportDirectory, string.Format("{0}-{1:yyMMdd_HHmmss}.xlsx", MRIS.MRISNumber, DateTime.Now));

            Workbook.SaveAs(fileName);

            base.Execute();
        }
    }
}
