using Citicon.Data;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportChequeVoucher : ExportExcelBase
    {
        public ExportChequeVoucher(ChequeVoucher chequeVoucher)
        {
            ChequeVoucher = chequeVoucher ?? throw new ArgumentNullException(nameof(chequeVoucher));
            Template = ConfigurationManager.AppSettings["ChequeVoucher.Template"];
            SaveDirectory = ConfigurationManager.AppSettings["ChequeVoucher.SaveDirectory"];
            RowCounter = 10;
            uint.TryParse(ConfigurationManager.AppSettings["ChequeVoucher.PrintCopies"], out uint printCopies);

            PrintCopies = printCopies > 0 ? printCopies : 1;
        }

        private ChequeVoucher ChequeVoucher;
        private Excel.Range Range;
        private string Template { get; set; }
        private string SaveDirectory { get; set; }
        private int RowCounter;

        private void ExportVariable()
        {
            if (!string.IsNullOrWhiteSpace(ChequeVoucher.VariableCostRemarks))
            {
                Range = Worksheet.Range[Worksheet.Cells[RowCounter, 1], Worksheet.Cells[RowCounter, 4]];
                Range.Merge();
                Range.Value = ChequeVoucher.VariableCostRemarks;
                RowCounter++;
            }

            if (ChequeVoucher.MRISRemarks.Count > 0)
            {
                Range = Worksheet.Range[Worksheet.Cells[RowCounter, 1], Worksheet.Cells[RowCounter, 4]];
                Range.Merge();
                Range.Value = "MRIS";

                foreach (var item in ChequeVoucher.MRISRemarks)
                {
                    RowCounter++;

                    Range = Worksheet.Cells[RowCounter, 1];
                    Range.Value = item.Key;

                    Range = Worksheet.Range[Worksheet.Cells[RowCounter, 2], Worksheet.Cells[RowCounter, 4]];
                    Range.Merge();
                    Range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                    Range.NumberFormat = "#,##0.00";
                    Range.Value = item.Value;
                }
            }

            AppendAccountSummaryHeader();
            AppendAccountSummary();
        }

        private void AppendAccountSummaryHeader()
        {
            RowCounter += 2;
            Range = Worksheet.Range[Worksheet.Cells[RowCounter, 1], Worksheet.Cells[RowCounter, 2]];
            Range.Merge();
            Range.Font.Bold = true;
            Range.Value = "ACCOUNTS";

            Range = Worksheet.Range[Worksheet.Cells[RowCounter, 3], Worksheet.Cells[RowCounter, 4]];
            Range.Merge();
            Range.Font.Bold = true;
            Range.Value = "AMOUNT";
        }

        private void ExportExpense()
        {
            if (!string.IsNullOrWhiteSpace(ChequeVoucher.ExpenseRemarks))
            {
                Range = Worksheet.Range[Worksheet.Cells[RowCounter, 1], Worksheet.Cells[RowCounter, 4]];
                Range.Merge();
                Range.Font.Bold = true;
                Range.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                Range.Value = ChequeVoucher.ExpenseRemarks;
            }

            AppendAccountSummaryHeader();
            AppendAccountSummary();
        }

        private void AppendAccountSummary()
        {
            foreach (var payable in ChequeVoucher.Payables)
            {
                RowCounter++;
                Range = Worksheet.Range[Worksheet.Cells[RowCounter, 1], Worksheet.Cells[RowCounter, 2]];
                Range.Merge();
                Range.Value = $"{payable.Company?.Description} - {payable.Branch?.Description?.Substring(0, 3)}. - {payable.Description}";

                Range = Worksheet.Cells[RowCounter, 3];
                Range.NumberFormat = "#,##0.00;(#,##0.00)";
                Range.Value = payable.Value;
            }
        }

        private void ExportInitial()
        {
            SetCellValue(GetLocation("Date"), ChequeVoucher.TransactionDate);
            SetCellValue(GetLocation("ChequeVoucherNumber"), ChequeVoucher.ChequeVoucherNumber);
            SetCellValue(GetLocation("Payee"), ChequeVoucher.Payee?.ToString());
            SetCellValue(GetLocation("AmountInWord"), Sorschia.Supports.CurrencyToWords(ChequeVoucher.GrandTotal));
            SetCellValue(GetLocation("Amount"), ChequeVoucher.GrandTotal);
            SetCellValue(GetLocation("RecordedBy"), GetDefault("RecordedBy"));
            SetCellValue(GetLocation("PreparedBy"), GetDefault("PreparedBy"));
            SetCellValue(GetLocation("CheckedBy"), GetDefault("CheckedBy"));
            SetCellValue(GetLocation("ApprovedBy"), GetDefault("ApprovedBy"));
        }

        private void SetCellValue(Point excelPoint, object value)
        {
            Worksheet.Cells[excelPoint.X, excelPoint.Y] = value;
        }

        private string ConfigPrefix(string value)
        {
            return string.Format("ChequeVoucherReport.{0}", value);
        }

        private string ConfigPrefix_Location(string value)
        {
            return ConfigPrefix(string.Format("Location[{0}]", value));
        }

        private string ConfigPrefix_MaxCount(string value)
        {
            return ConfigPrefix(string.Format("MaxCount[{0}]", value));
        }

        private string ConfigPrefix_Default(string value)
        {
            return ConfigPrefix(string.Format("Default[{0}]", value));
        }

        private string GetDefault(string key)
        {
            var result = ConfigurationManager.AppSettings[ConfigPrefix_Default(key)];
            return result ?? string.Empty;
        }

        private Point GetLocation(string key)
        {
            var locationRaw = ConfigurationManager.AppSettings[ConfigPrefix_Location(key)];

            if (!string.IsNullOrWhiteSpace(locationRaw) && locationRaw.Contains(","))
            {
                var splittedLocationRaw = locationRaw.Split(',');

                if (splittedLocationRaw.Length == 2)
                {
                    int.TryParse(splittedLocationRaw[0], out int x);
                    int.TryParse(splittedLocationRaw[1], out int y);

                    return new Point(x, y);
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

        private int GetMaxCount(string key)
        {
            int.TryParse(ConfigurationManager.AppSettings[ConfigPrefix_MaxCount(key)], out int result);

            return result;
        }

        public override void Execute()
        {
            PrintOption = ExportExcelPrintOption.Workbook;

            Application = new Excel.Application();
            Workbooks = Application.Workbooks;
            Workbook = Workbooks.Open(Template);
            Sheets = Workbook.Sheets;
            Worksheet = Sheets[1];

            ExportInitial();

            if (ChequeVoucher.VariableCost)
            {
                ExportVariable();
            }
            else
            {
                ExportExpense();
            }

            if (!Directory.Exists(SaveDirectory))
            {
                Directory.CreateDirectory(SaveDirectory);
            }

            var filePath = Path.Combine(SaveDirectory, string.Format("{0}_{1:yyMMdd-hhmmss}.xlsx", ChequeVoucher.ChequeVoucherNumber, DateTime.Now));
            Workbook.SaveAs(filePath);
            base.Execute();
        }
    }
}
