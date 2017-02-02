using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectListWithUnbilledDeliveryByClient : IDisposable
    {
        #region Constructor
        public GetProjectListWithUnbilledDeliveryByClient(Client client)
        {
            Client = client;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private MySqlConnectionHelper ConnectionHelper;
        private Client Client;
        #endregion

        #region Execution
        public async Task<IEnumerable<Project>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
            Client = null;
        } 
        #endregion
    }
}
