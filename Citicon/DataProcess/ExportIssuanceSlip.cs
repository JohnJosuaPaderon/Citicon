using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportIssuanceSlip : ExportExcelBase
    {
        public ExportIssuanceSlip(IEnumerable<Transaction> transactions)
        {
            _Transactions = transactions;
            _Template = ConfigurationManager.AppSettings.GetString("IssuanceSlip.Template");
            _SaveDirectory = ConfigurationManager.AppSettings.GetString("IssuanceSlip.SaveDirectory");

            PrepareDependency();
            _FilePath = ConstructFilePath();
        }

        private readonly string _Template;
        private readonly string _SaveDirectory;
        private readonly string _FilePath;
        private readonly IEnumerable<Transaction> _Transactions;
        private string IssuanceSlipNumber;
        private DateTime TransactionDate;

        public override void Execute()
        {
            if (File.Exists(_Template))
            {
                Application = new Excel.Application();
                Workbooks = Application.Workbooks;
                Workbook = Workbooks.Open(_Template);
                Sheets = Workbook.Sheets;
                Worksheet = Sheets[1];
                WriteFields();
                WriteTransactions();

                if (!Directory.Exists(_SaveDirectory))
                {
                    Directory.CreateDirectory(_SaveDirectory);
                }

                Workbook.SaveAs(_FilePath);

                base.Execute();
            }
        }

        private void WriteFields()
        {
            Worksheet.Cells[2, 2] = TransactionDate;
            Worksheet.Cells[2, 6] = IssuanceSlipNumber;
        }

        private void WriteTransactions()
        {
            var max = 11;
            var counter = 0;
            var baseRow = 4;

            foreach (var transaction in _Transactions)
            {
                if (counter > max)
                {
                    break;
                }

                Worksheet.Cells[baseRow + counter, 1] = transaction.RemovedStockValue;
                Worksheet.Cells[baseRow + counter, 3] = transaction.Item?.Description;

                counter++;
            }
        }

        private string ConstructFilePath()
        {
            var filePath = Path.Combine(_SaveDirectory, $"{IssuanceSlipNumber}_{DateTime.Now.ToString("yyyyMMdd-hhmm")}.xlsx");
            return filePath;
        }

        private void PrepareDependency()
        {
            IssuanceSlipNumber = string.Empty;
            TransactionDate = default(DateTime);

            foreach (var transaction in _Transactions)
            {
                IssuanceSlipNumber = transaction.IssuanceSlipNumber;
                TransactionDate = transaction.TransactionDate;

                if (!string.IsNullOrWhiteSpace(IssuanceSlipNumber) && TransactionDate != default(DateTime))
                {
                    break;
                }
            }
        }
    }
}
