using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDeliveryRouteList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDeliveryRouteList", connection);
            return command;
        }

        public Task<IEnumerable<DeliveryRoute>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private DeliveryRoute FromReader(DbDataReader reader)
        {
            return new DeliveryRoute()
            {
                Id = reader.GetInt64("Id"),
                Name = reader.GetString("Name"),
                StartPoint = reader.GetString("StartPoint"),
                EndPoint = reader.GetString("EndPoint"),
                Rate = reader.GetDecimal("Rate")
            };
        }
    }
}
