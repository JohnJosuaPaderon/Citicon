using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDeliveryConsumedCementSupplied : DataProcessBase
    {
        public GetDeliveryConsumedCementSupplied(Stock cementSupplied, Delivery delivery)
        {
            CementSupplied = cementSupplied ?? throw new ArgumentNullException(nameof(cementSupplied));
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        private Stock CementSupplied;
        private Delivery Delivery;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand(nameof(GetDeliveryConsumedCementSupplied), connection);
            command.Parameters.AddWithValue("@_CementSuppliedId", CementSupplied.Id);
            command.Parameters.AddWithValue("@_DeliveryId", Delivery.Id);

            return command;
        }

        private DeliveryConsumedCementSupplied FromReader(DbDataReader reader)
        {
            return new DeliveryConsumedCementSupplied()
            {
                CementSupplied = CementSupplied,
                Delivery = Delivery,
                Amount = reader.GetDecimal("Amount")
            };
        }

        public Task<DeliveryConsumedCementSupplied> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
