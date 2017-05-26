using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class ConfirmDelivery : DataProcessBase
    {
        public ConfirmDelivery(Delivery delivery)
        {
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        private Delivery Delivery;

        public override void Dispose()
        {
            Delivery = null;
            base.Dispose();
        }

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("ConfirmDelivery", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Delivery.Id);
            command.Parameters.AddWithValue("@_ProjectArrive", Delivery.ProjectArrive);
            command.Parameters.AddWithValue("@_PlantArrive", Delivery.PlantArrive);
            command.Parameters.AddWithValue("@_StartUnloading", Delivery.StartUnloading);
            command.Parameters.AddWithValue("@_FinishedUnloading", Delivery.FinishedUnloading);
            command.Parameters.AddWithValue("@_EstimatedStay", Delivery.EstimatedStay);

            return command;
        }

        public async Task<Delivery> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    Delivery = null;
                }

                return Delivery;
            }
        }

        public Task<Delivery> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
