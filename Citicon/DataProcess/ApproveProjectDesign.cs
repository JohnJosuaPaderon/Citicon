using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class ApproveProjectDesign : DataProcessBase
    {
        public ApproveProjectDesign(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign;
        }

        private ProjectDesign ProjectDesign { get; }

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

        public async Task<ProjectDesign> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
    }
}
