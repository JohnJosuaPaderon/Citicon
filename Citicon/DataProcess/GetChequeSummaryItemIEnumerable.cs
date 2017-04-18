using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetChequeSummaryItemIEnumerable : DataProcessBase
    {
        public GetChequeSummaryItemIEnumerable(
            bool filterByRangeDate, DateTimeRange rangeDate,
            bool filterBySupplier, Supplier supplier, 
            bool filterByBranch, Branch branch, 
            bool filterByCompany, Company company, 
            bool filterByTransactionDateRange, DateTimeRange transactionDateRange)
        {
            FilterByRangeDate = filterByRangeDate;
            FilterBySupplier = filterBySupplier;
            RangeDate = rangeDate;
            Supplier = supplier;
            FilterByBranch = filterByBranch;
            Branch = branch;
            FilterByCompany = filterByCompany;
            Company = company;
            FilterByTransactionDateRange = filterByTransactionDateRange;
            TransactionDateRange = transactionDateRange;
            SupplierManager = new SupplierManager();
            BankAccountManager = new BankAccountManager();
            CompanyManager = new CompanyManager();
        }

        private bool FilterByRangeDate;
        private DateTimeRange RangeDate;
        private bool FilterBySupplier;
        private Supplier Supplier;
        private bool FilterByBranch;
        private Branch Branch;
        private bool FilterByCompany;
        private Company Company;
        private bool FilterByTransactionDateRange;
        private DateTimeRange TransactionDateRange;
        private SupplierManager SupplierManager;
        private BankAccountManager BankAccountManager;
        private CompanyManager CompanyManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetFilteredChequeSummary", connection);
            command.Parameters.AddWithValue("@_FilterByRangeDate", FilterByRangeDate);
            command.Parameters.AddWithValue("@_RangeStart", RangeDate?.Start);
            command.Parameters.AddWithValue("@_RangeEnd", RangeDate?.End);
            command.Parameters.AddWithValue("@_FilterBySupplierId", FilterBySupplier);
            command.Parameters.AddWithValue("@_SupplierId", Supplier?.Id);
            command.Parameters.AddWithValue("@_FilterByBranchId", FilterByBranch);
            command.Parameters.AddWithValue("@_BranchId", Branch?.Id);
            command.Parameters.AddWithValue("@_FilterByCompanyId", FilterByCompany);
            command.Parameters.AddWithValue("@_CompanyId", Company?.Id);
            command.Parameters.AddWithValue("@_FilterByTransactionDateRange", FilterByTransactionDateRange);
            command.Parameters.AddWithValue("@_TransactionDateRangeStart", TransactionDateRange.Start);
            command.Parameters.AddWithValue("@_TransactionDateRangeEnd", TransactionDateRange.End);

            return command;
        }

        public override void Dispose()
        {
            RangeDate = null;
            Supplier = null;
            Branch = null;
            Company = null;
            TransactionDateRange = null;
            SupplierManager = null;
            BankAccountManager = null;
            CompanyManager = null;
            base.Dispose();
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
                TransactionDate = reader.GetDateTime("TransactionDate"),
                Company = await CompanyManager.GetByIdAsync(reader.GetUInt64("CompanyId"))
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
