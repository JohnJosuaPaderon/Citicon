using Citicon.DataManager;
using Citicon.Payables.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetChequeVoucherNumberDetails : DataProcess, IDisposable
    {
        public GetChequeVoucherNumberDetails(string chequeVoucherNumber)
        {
            if (string.IsNullOrWhiteSpace(chequeVoucherNumber))
            {
                throw new ArgumentException("Value cannot be null or white space.", nameof(chequeVoucherNumber));
            }

            ChequeVoucherNumber = chequeVoucherNumber;
            BranchManager = new BranchManager();
            CompanyManager = new CompanyManager();
        }

        private string ChequeVoucherNumber;
        private BranchManager BranchManager;
        private CompanyManager CompanyManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetChequeVoucherNumberDetails", connection);
            command.Parameters.AddWithValue("@_ChequeVoucherNumber", ChequeVoucherNumber);

            return command;
        }

        public void Dispose()
        {
            ChequeVoucherNumber = null;
        }

        public Task<IEnumerable<Payable>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReaderAsync);
        }

        public Task<IEnumerable<Payable>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private async Task<Payable> FromReaderAsync(DbDataReader reader)
        {
            return new Payable()
            {
                Id = reader.GetUInt32("Id"),
                Description = reader.GetString("Description"),
                Branch = await BranchManager.GetByIdAsync(reader.GetUInt64("BranchId")),
                Company = await CompanyManager.GetByIdAsync(reader.GetUInt64("CompanyId")),
                ChequeVoucherNumber = ChequeVoucherNumber,
                Debit = reader.GetDecimal("Debit"),
                Credit = reader.GetDecimal("Credit")
            };
        }
    }
}
