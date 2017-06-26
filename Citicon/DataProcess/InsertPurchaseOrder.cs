using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertPurchaseOrder : DataProcessBase
    {
        public InsertPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            PurchaseOrder = purchaseOrder ?? throw new ArgumentNullException(nameof(purchaseOrder));
        }

        private PurchaseOrder PurchaseOrder;
        private const string Parameter_Id = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertPurchaseOrder", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
            command.Parameters.AddWithValue("@_ProjectId", PurchaseOrder.Project?.Id);
            command.Parameters.AddWithValue("@_Number", PurchaseOrder.Number);
            command.Parameters.AddWithValue("@_MaximumCumulativePricePerCubicMeter", PurchaseOrder.MaximumCumulativePricePerCubicMeter);

            return command;
        }

        public async Task<PurchaseOrder> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    PurchaseOrder.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                }
                else
                {
                    PurchaseOrder = null;
                }

                return PurchaseOrder;
            }
        }

        public Task<PurchaseOrder> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
