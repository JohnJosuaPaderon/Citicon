using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDeliveryRouteById : DataProcessBase
    {
        public GetDeliveryRouteById(long routeId)
        {
            RouteId = routeId > 0 ? routeId : throw new ArgumentException("Value cannot be zero.", nameof(routeId));
        }

        private long RouteId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDeliveryRouteById", connection);
            command.Parameters.AddWithValue("@_Id", RouteId);

            return command;
        }

        public Task<DeliveryRoute> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }

        private DeliveryRoute FromReader(DbDataReader reader)
        {
            return new DeliveryRoute()
            {
                Id = RouteId,
                Name = reader.GetString("Name"),
                StartPoint = reader.GetString("StartPoint"),
                EndPoint = reader.GetString("EndPoint"),
                Rate = reader.GetDecimal("Rate")
            };
        }
    }
}
