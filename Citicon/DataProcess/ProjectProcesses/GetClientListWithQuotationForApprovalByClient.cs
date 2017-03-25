using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectListWithQuotationForApprovalByClient : DataProcessBase
    {
        public GetProjectListWithQuotationForApprovalByClient(Client client)
        {
            Client = client;
        }

        private Client Client { get; set; }
        
        public async Task<IEnumerable<Project>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectListWithQuotationForApprovalByClientId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ClientId", Client.Id);
                    List<Project> projects = null;
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            projects = new List<Project>();
                            while (await reader.ReadAsync())
                            {
                                projects.Add(new Project()
                                {
                                    Id = reader.GetUInt64("Id"),
                                    Name = reader.GetString("Name"),
                                    Location = reader.GetString("Location")
                                });
                            }
                        }
                    }
                    return projects;
                }
            }
        }
    }
}
