using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.ProjectProcesses
{
    public sealed class GetProjectListWithQuotationForApprovalByClient : IDisposable
    {
        #region Constructor
        public GetProjectListWithQuotationForApprovalByClient(Client client)
        {
            Client = client;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private Client Client { get; set; }
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Execute
        public async Task<IEnumerable<Project>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Client = null;
            ConnectionHelper = null;
        } 
        #endregion
    }
}
