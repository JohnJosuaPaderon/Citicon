using Citicon.Data;
using System;
using System.Configuration;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportChequeVoucher : ExportExcelBase
    {
        public ExportChequeVoucher(ChequeVoucher chequeVoucher)
        {
            ChequeVoucher = chequeVoucher ?? throw new ArgumentNullException(nameof(chequeVoucher));
        }

        private ChequeVoucher ChequeVoucher;
        private string Template { get; set; }
        private string SaveDirectory { get; set; }

        private void ExportVariable()
        {

        }

        private void ExportExpense()
        {

        }

        private void ExportInitial()
        {
            SetCellValue(GetLocation("Date"), ChequeVoucher.TransactionDate);
            SetCellValue(GetLocation("ChequeVoucherNumber"), ChequeVoucher.ChequeVoucherNumber);
            SetCellValue(GetLocation("Payee"), ChequeVoucher.Payee?.ToString());
            SetCellValue(GetLocation("AmountInWord"), Sorschia.Supports.CurrencyToWords(ChequeVoucher.GrandTotal));
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

            if (ChequeVoucher.VariableCost)
            {
                ExportVariable();
            }
            else
            {
                ExportExpense();
            }

            base.Execute();
        }
    }
}
