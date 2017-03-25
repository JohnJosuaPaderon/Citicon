using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectListWithUnbilledDeliveryByClient : DataProcessBase
    {
        public GetProjectListWithUnbilledDeliveryByClient(Client client)
        {
            Client = client;
        }

        private Client Client;

        public async Task<IEnumerable<Project>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectListWithUnbilledDeliveryByClientId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ClientId", Client.Id);
                    List<Project> projects = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                projects = new List<Project>();
                                while (await reader.ReadAsync())
                                {
                                    projects.Add(await ProjectManager.FromDbDataReaderAsync(reader));
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        projects = null;
                        throw;
                    }
                    return projects;
                }
            }
        }
    }
}
