using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertDelivery : DataProcessBase
    {
        public InsertDelivery(Delivery delivery)
        {
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        private Delivery Delivery;
        private const string Parameter_Id = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertDelivery", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
            command.Parameters.AddWithValue("@_ProjectId", Delivery.Project?.Id);
            command.Parameters.AddWithValue("@_ProjectDesignId", Delivery.ProjectDesign?.Id);
            command.Parameters.AddWithValue("@_DeliveryReceiptNumber", Delivery.DeliveryReceiptNumber);
            command.Parameters.AddWithValue("@_DeliveryDate", Delivery.DeliveryDate);
            command.Parameters.AddWithValue("@_Load", Delivery.Load);
            command.Parameters.AddWithValue("@_PlantLeave", Delivery.PlantLeave);
            command.Parameters.AddWithValue("@_PlantArrive", Delivery.PlantArrive);
            command.Parameters.AddWithValue("@_Volume", Delivery.Volume);
            command.Parameters.AddWithValue("@_PricePerCubicMeter", Delivery.PricePerCubicMeter);
            command.Parameters.AddWithValue("@_RouteId", Delivery.Route?.Id);
            command.Parameters.AddWithValue("@_TransitMixerId", Delivery.TransitMixer?.Id);
            command.Parameters.AddWithValue("@_BranchId", Delivery.Branch?.Id);
            command.Parameters.AddWithValue("@_DriverId", Delivery.Driver?.Id);
            command.Parameters.AddWithValue("@_MaxSlump", Delivery.MaxSlump);
            command.Parameters.AddWithValue("@_ScheduleStatus", (string)Delivery.ScheduleStatus);

            return command;
        }

        public override void Dispose()
        {
            Delivery = null;
            base.Dispose();
        }

        public Task<Delivery> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        public async Task<Delivery> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    Delivery.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                }
                else
                {
                    Delivery = null;
                }

                return Delivery;
            }
        }
    }
}
