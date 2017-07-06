using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertDeliveryRoute : DataProcessBase
    {
        public InsertDeliveryRoute(DeliveryRoute route)
        {
            Route = route ?? throw new ArgumentNullException(nameof(route));
        }

        private DeliveryRoute Route;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertDeliveryRoute", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter("@_Id"));
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
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    Route.Id = Convert.ToInt64(command.Parameters["@_Id"].Value);
                }
                else
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
