using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectDesignById : DataProcessBase
    {
        public GetProjectDesignById(ulong projectDesignId)
        {
            ProjectDesignId = projectDesignId;
        }

        private ulong ProjectDesignId;
        
        public async Task<ProjectDesign> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetProjectDesignById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectDesignId", ProjectDesignId);
                    ProjectDesign projectDesign = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                projectDesign = await ProjectDesignManager.FromDbDataReader(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        projectDesign = null;
                        throw;
                    }
                    return projectDesign;
                }
            }
        }
    }
}
