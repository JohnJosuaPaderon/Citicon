using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProjectListWithoutBIllingSiNumberByClient : IDisposable
    {
        private Client Client;
        private MySqlConnectionHelper ConnectionHelper;

        public GetProjectListWithoutBIllingSiNumberByClient(Client client)
        {
            Client = client;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Project>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectListWithoutBillingSiNumberByClientId", connection))
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
                                    projects.Add(new Project
                                    {
                                        Id = reader.GetUInt64("Id"),
                                        Client = Client,
                                        Location = reader.GetString("Location"),
                                        Name = reader.GetString("Name")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        projects = null;
                        throw;
                    }
                    return projects;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
