using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertTransaction : DataProcessBase
    {
        public InsertTransaction(Transaction transaction)
        {
            _Transaction = transaction;
        }

        private readonly Transaction _Transaction;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertTransaction", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter("@_Id"));
            command.Parameters.AddWithValue("@_ItemId", _Transaction.Item?.Id);
            command.Parameters.AddWithValue("@_RemovedStockValue", _Transaction.RemovedStockValue);
            command.Parameters.AddWithValue("@_Purpose", _Transaction.Purpose);
            command.Parameters.AddWithValue("@_RequestedBy", _Transaction.RequestedBy);
            command.Parameters.AddWithValue("@_BranchId", _Transaction.Branch?.Id);
            command.Parameters.AddWithValue("@_CompanyId", _Transaction.Company?.Id);
            command.Parameters.AddWithValue("@_TransactionDate", _Transaction.TransactionDate);
            command.Parameters.AddWithValue("@_ReleasedBy", _Transaction.ReleasedBy);
            command.Parameters.AddWithValue("@_VehicleId", _Transaction.Truck?.Id);
            command.Parameters.AddWithValue("@_IssuanceSlipNumber", _Transaction.IssuanceSlipNumber);
            command.Parameters.AddWithValue("@_LatestPrice", _Transaction.LatestPrice);
            command.Parameters.AddWithValue("@_LatestPriceDate", _Transaction.LatestPriceDate);

            return command;
        }

        public Task<Transaction> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        public async Task<Transaction> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    _Transaction.Id = Convert.ToUInt64(command.Parameters["@_Id"].Value);
                    return _Transaction;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
