using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectDesignById : IDisposable
    {
        #region Constructor
        public GetProjectDesignById(ulong projectDesignId)
        {
            ProjectDesignId = projectDesignId;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private MySqlConnectionHelper ConnectionHelper;
        private ulong ProjectDesignId;
        #endregion

        #region Execution
        public async Task<ProjectDesign> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
