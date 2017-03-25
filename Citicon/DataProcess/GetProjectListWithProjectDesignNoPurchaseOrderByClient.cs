using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectListWithProjectDesignNoPurchaseOrderByClient : DataProcessBase
    {
        public GetProjectListWithProjectDesignNoPurchaseOrderByClient(Client client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private Client Client;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetProjectListWithProjectDesignNoPurchaseOrderByClientId", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@_ClientId", Client.Id);
            return command;
        }

        private Project FromReader(DbDataReader reader)
        {
            return new Project
            {
                Client = Client,
                Id = reader.GetUInt64("Id"),
                Name = reader.GetString("Name")
            };
        }
        
        internal async Task<List<Project>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        var projectList = new List<Project>();

                        while (await reader.ReadAsync())
                        {
                            projectList.Add(FromReader(reader));
                        }

                        return projectList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public async Task<List<Project>> ExecuteAsync()
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
