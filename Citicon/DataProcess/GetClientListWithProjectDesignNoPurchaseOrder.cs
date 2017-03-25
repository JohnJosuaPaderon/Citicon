using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetClientListWithProjectDesignNoPurchaseOrder : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetClientListWithProjectDesignNoPurchaseOrderId", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            return command;
        }

        private Client FromReader(DbDataReader reader)
        {
            return new Client
            {
                CompanyName = reader.GetString("CompanyName"),
                Id = reader.GetUInt64("Id")
            };
        }
        
        internal async Task<List<Client>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        var clientList = new List<Client>();

                        while (await reader.ReadAsync())
                        {
                            clientList.Add(FromReader(reader));
                        }

                        return clientList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public async Task<List<Client>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    return await ExecuteAsync(connection);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
