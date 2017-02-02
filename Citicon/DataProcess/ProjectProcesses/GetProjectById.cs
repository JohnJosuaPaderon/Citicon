using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProjectById : IDisposable
    {
        private ulong ProjectId;
        private MySqlConnectionHelper ConnectionHelper;

        public GetProjectById(ulong projectId)
        {
            ProjectId = projectId;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<Project> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", ProjectId);
                    Project project = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                return await ProjectManager.FromDbDataReaderAsync(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        project = null;
                        throw;
                    }
                    return project;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
