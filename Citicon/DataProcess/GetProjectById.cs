using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetProjectById : DataProcessBase
    {
        private ulong ProjectId;

        public GetProjectById(ulong projectId)
        {
            ProjectId = projectId;
        }

        public async Task<Project> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
    }
}
