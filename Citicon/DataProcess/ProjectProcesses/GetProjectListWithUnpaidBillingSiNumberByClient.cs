using Citicon.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProjectListWithUnpaidBillingSiNumberByClient : IDisposable
    {
        private Client Client;
        private MySqlConnectionHelper ConnectionHelper;

        public GetProjectListWithUnpaidBillingSiNumberByClient(Client client)
        {
            Client = client;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Project>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectListWithUnpaidBillingSiNumberByClientId", connection))
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
                                        Client = Client,
                                        Id = reader.GetUInt64("Id"),
                                        Name = reader.GetString("Name"),
                                        Location = reader.GetString("Location")
                                    });
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

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
