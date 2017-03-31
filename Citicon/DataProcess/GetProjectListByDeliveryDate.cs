using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetProjectListByDeliveryDate : DataProcessBase
    {
        public GetProjectListByDeliveryDate(DateTime deliveryDate)
        {
            DeliveryDate = deliveryDate;
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetProjectListByDeliveryDate", connection);
            command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);

            return command;
        }

        private DateTime DeliveryDate;

        public Task<IEnumerable<Project>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<Project> FromReaderAsync(DbDataReader reader)
        {
            return new Project()
            {
                Id = reader.GetUInt64("Id"),
                Name = reader.GetString("Name"),
                Client = await ClientManager.GetByIdAsync(reader.GetUInt64("ClientId"))
            };
        }
    }
}
