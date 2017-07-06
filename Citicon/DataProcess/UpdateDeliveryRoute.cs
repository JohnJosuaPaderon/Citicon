using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateDeliveryRoute : DataProcessBase
    {
        public UpdateDeliveryRoute(DeliveryRoute route)
        {
            Route = route ?? throw new ArgumentNullException(nameof(route));
        }

        private DeliveryRoute Route;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateDeliveryRoute", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Route.Id);
            command.Parameters.AddWithValue("@_Name", Route.Name);
            command.Parameters.AddWithValue("@_StartPoint", Route.StartPoint);
            command.Parameters.AddWithValue("@_EndPoint", Route.EndPoint);
            command.Parameters.AddWithValue("@_Rate", Route.Rate);

            return command;
        }

        public async Task<DeliveryRoute> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    Route = null;
                }

                return Route;
            }
        }

        public Task<DeliveryRoute> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
