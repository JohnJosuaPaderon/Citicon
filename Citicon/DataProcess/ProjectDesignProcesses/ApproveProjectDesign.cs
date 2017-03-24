using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class ApproveProjectDesign : IDisposable
    {
        #region COnstructor
        public ApproveProjectDesign(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private ProjectDesign ProjectDesign { get; }
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Helper Methods
        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand("ApproveProjectDesign", connection, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@_ProjectDesignId", ProjectDesign.Id);
            command.Parameters.AddWithValue("@_PricePerCubicMeter", ProjectDesign.PricePerCubicMeter);
            return command;
        }
        #endregion

        #region Execute
        public async Task<ProjectDesign> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        using (var command = CreateCommand(connection, transaction))
                        {
                            try
                            {
                                await command.ExecuteNonQueryAsync();
                                transaction.Commit();
                                return ProjectDesign;
                            }
                            catch (Exception)
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    } 
                }

                return null;
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
