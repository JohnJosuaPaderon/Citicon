using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveDeliveryConsumedCementSuppliedAmount : DataProcessBase
    {
        public SaveDeliveryConsumedCementSuppliedAmount(DeliveryConsumedCementSupplied deliveryConsumedCementSupplied)
        {
            DeliveryConsumedCementSupplied = deliveryConsumedCementSupplied ?? throw new ArgumentNullException(nameof(deliveryConsumedCementSupplied));
        }

        private DeliveryConsumedCementSupplied DeliveryConsumedCementSupplied;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand(nameof(SaveDeliveryConsumedCementSuppliedAmount), connection, transaction);
            command.Parameters.AddWithValue("@_CementSuppliedId", DeliveryConsumedCementSupplied.CementSupplied.Id);
            command.Parameters.AddWithValue("@_DeliveryId", DeliveryConsumedCementSupplied.Delivery.Id);
            command.Parameters.AddWithValue("@_Amount", DeliveryConsumedCementSupplied.Amount);

            return command;
        }

        public async Task<DeliveryConsumedCementSupplied> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() <= 0)
                {
                    DeliveryConsumedCementSupplied = null;
                }
            }

            return DeliveryConsumedCementSupplied;
        }

        public Task<DeliveryConsumedCementSupplied> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
