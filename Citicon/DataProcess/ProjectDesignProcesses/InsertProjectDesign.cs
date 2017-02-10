using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.ProjectDesignProcesses
{
    public sealed class InsertProjectDesign : IDisposable
    {
        #region Constructor
        public InsertProjectDesign(ProjectDesign projectDesign)
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
            var command = new MySqlCommand("InsertProjectDesign", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter { ParameterName = "@_Id", Direction = ParameterDirection.Output });
            command.Parameters.AddWithValue("@_MixType", ProjectDesign.MixType.ToString());
            command.Parameters.AddWithValue("@_ProjectId", ProjectDesign.Project.Id);
            command.Parameters.AddWithValue("@_Psi", ProjectDesign.Psi);
            command.Parameters.AddWithValue("@_AggregateId", ProjectDesign.Aggregate.Id);
            command.Parameters.AddWithValue("@_StrengthId", ProjectDesign.Strength.Id);
            command.Parameters.AddWithValue("@_PricePerCubicMeter", ProjectDesign.PricePerCubicMeter);
            command.Parameters.AddWithValue("@_CementFactor", ProjectDesign.CementFactor);
            command.Parameters.AddWithValue("@_ForApproval", ProjectDesign.ForApproval);
            return command;
        }
        #endregion

        #region Execute
        public async Task<ProjectDesign> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                ProjectDesign.Id = Convert.ToUInt64(command.Parameters["@_Id"].Value);
                return ProjectDesign;
            }
        }

        public async Task<ProjectDesign> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        try
                        {
                            await ExecuteAsync(connection, transaction);
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
                else
                {
                    return null;
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
