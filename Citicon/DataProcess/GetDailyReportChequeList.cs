using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDailyReportChequeList : DataProcessBase
    {
        public GetDailyReportChequeList(DateTime transactionDate)
        {
            TransactionDate = transactionDate;
            SupplierManager = new SupplierManager();
            BankAccountManager = new BankAccountManager();
            CompanyManager = new CompanyManager();
        }

        private DateTime TransactionDate;
        private SupplierManager SupplierManager;
        private BankAccountManager BankAccountManager;
        private CompanyManager CompanyManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDailyReportChequeList", connection);
            command.Parameters.AddWithValue("@_TransactionDate", TransactionDate);

            return command;
        }

        public override void Dispose()
        {
            SupplierManager = null;
            BankAccountManager = null;
            CompanyManager = null;
            base.Dispose();
        }

        public Task<IEnumerable<ChequeSummaryItem>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<ChequeSummaryItem> FromReaderAsync(DbDataReader reader)
        {
            return new ChequeSummaryItem()
            {
                ChequeDate = reader.GetDateTime("ChequeDate"),
                ChequeNumbber = reader.GetString("ChequeNumber"),
                Supplier = await SupplierManager.GetByIdAsync(reader.GetUInt64("SupplierId")),
                TotalAmount = reader.GetDecimal("TotalAmount"),
                BankAccount = BankAccountManager.GetById(reader.GetUInt64("BankAccountId")),
                TransactionDate = TransactionDate,
                Company = await CompanyManager.GetByIdAsync(reader.GetUInt64("CompanyId"))
            };
        }
    }
}
