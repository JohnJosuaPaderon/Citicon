using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertPurchaseOrderProjectDesign : DataProcess
    {
        public InsertPurchaseOrderProjectDesign(PurchaseOrderProjectDesign purchaseOrderProjectDesign)
        {
            PurchaseOrderProjectDesign = purchaseOrderProjectDesign ?? throw new ArgumentNullException(nameof(purchaseOrderProjectDesign));
        }

        private PurchaseOrderProjectDesign PurchaseOrderProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertPurchaseOrderProjectDesign", connection, transaction);
            command.Parameters.AddWithValue("@_PurchaseOrderId", PurchaseOrderProjectDesign.PurchaseOrder.Id);
            command.Parameters.AddWithValue("@_ProjectDesignId", PurchaseOrderProjectDesign.ProjectDesign.Id);
            command.Parameters.AddWithValue("@_MaxVolume", PurchaseOrderProjectDesign.MaxVolume);

            return command;
        }

        public async Task<PurchaseOrderProjectDesign> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    PurchaseOrderProjectDesign = null;
                }

                return PurchaseOrderProjectDesign;
            }
        }

        public Task<PurchaseOrderProjectDesign> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
