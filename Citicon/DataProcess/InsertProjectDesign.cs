using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class InsertProjectDesign : DataProcessBase
    {
        public InsertProjectDesign(ProjectDesign projectDesign, bool includeToRevisedQuotation)
        {
            ProjectDesign = projectDesign;
            IncludeToRevisedQuotation = includeToRevisedQuotation;
        }

        private ProjectDesign ProjectDesign { get; }
        private bool IncludeToRevisedQuotation;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand("InsertProjectDesign", connection, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.Add(new MySqlParameter { ParameterName = "@_Id", Direction = ParameterDirection.Output });
            command.Parameters.AddWithValue("@_MixType", ProjectDesign.MixType.ToString());
            command.Parameters.AddWithValue("@_ProjectId", ProjectDesign.Project?.Id);
            command.Parameters.AddWithValue("@_Psi", ProjectDesign.Psi);
            command.Parameters.AddWithValue("@_AggregateId", ProjectDesign.Aggregate?.Id);
            command.Parameters.AddWithValue("@_StrengthId", ProjectDesign.Strength?.Id);
            command.Parameters.AddWithValue("@_PricePerCubicMeter", ProjectDesign.PricePerCubicMeter);
            command.Parameters.AddWithValue("@_CementFactor", ProjectDesign.CementFactor);
            command.Parameters.AddWithValue("@_ForApproval", ProjectDesign.ForApproval);
            command.Parameters.AddWithValue("@_QuotationId", ProjectDesign.Quotation?.Id);
            command.Parameters.AddWithValue("@_IncludeToRevisedQuotation", IncludeToRevisedQuotation);

            return command;
        }

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
            using (var connection = await Utility.EstablishConnectionAsync())
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
    }
}
