using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetChequeSummaryItemIEnumerable : DataProcess
    {
        public GetChequeSummaryItemIEnumerable(bool filterByRangeDate, DateTimeRange rangeDate, bool filterBySupplier, Supplier supplier)
        {
            FilterByRangeDate = filterByRangeDate;
            FilterBySupplier = filterBySupplier;
            RangeDate = rangeDate;
            Supplier = supplier;
            SupplierManager = new SupplierManager();
            BankAccountManager = new BankAccountManager();
        }

        private bool FilterByRangeDate;
        private DateTimeRange RangeDate;
        private bool FilterBySupplier;
        private Supplier Supplier;
        private SupplierManager SupplierManager;
        private BankAccountManager BankAccountManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetFilteredChequeSummary", connection);
            command.Parameters.AddWithValue("@_FilterByRangeDate", FilterByRangeDate);
            command.Parameters.AddWithValue("@_RangeStart", RangeDate.Start);
            command.Parameters.AddWithValue("@_RangeEnd", RangeDate.End);
            command.Parameters.AddWithValue("@_FilterBySupplierId", FilterBySupplier);
            command.Parameters.AddWithValue("@_SupplierId", Supplier?.Id);

            return command;
        }

        private async Task<ChequeSummaryItem> FromReaderAsync(DbDataReader reader)
        {
            return new ChequeSummaryItem()
            {
                ChequeDate = reader.GetDateTime("ChequeDate"),
                ChequeNumbber = reader.GetString("ChequeNumber"),
                Supplier = await SupplierManager.GetByIdAsync(reader.GetUInt64("SupplierId")),
                TotalAmount = reader.GetDecimal("TotalAmount"),
                BankAccount = await BankAccountManager.GetByIdAsync(reader.GetUInt64("BankAccountId"))
            };
        }

        public Task<IEnumerable<ChequeSummaryItem>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return ProcessUtility.HandleReadingIEnumerableAsync(command, FromReaderAsync);
            }
        }

        public Task<IEnumerable<ChequeSummaryItem>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
