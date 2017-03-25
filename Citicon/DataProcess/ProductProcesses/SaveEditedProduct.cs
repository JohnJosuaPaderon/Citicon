using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class SaveEditedProduct : DataProcessBase
    {
        private ProjectDesign ProjectDesign;

        public SaveEditedProduct(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign;
        }

        public async Task ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    using (var command = new MySqlCommand("SaveEditedProjectDesign", connection, transaction))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_ProjectDesignId", ProjectDesign.Id);
                        command.Parameters.AddWithValue("@_ProjectId", ProjectDesign.Project.Id);
                        command.Parameters.AddWithValue("@_PricePerCubicMeter", ProjectDesign.PricePerCubicMeter);
                        command.Parameters.AddWithValue("@_InitialVolume", ProjectDesign.InitialVolume);
                        command.Parameters.AddWithValue("@_DesignMixType", ProjectDesign.MixType.ToString());
                        command.Parameters.AddWithValue("@_Psi", ProjectDesign.Psi);
                        command.Parameters.AddWithValue("@_AggregateId", ProjectDesign.Aggregate?.Id);
                        command.Parameters.AddWithValue("@_CementFactor", ProjectDesign.CementFactor);
                        command.Parameters.AddWithValue("@_StrengthId", ProjectDesign.Strength?.Id);
                        try
                        {
                            await command.ExecuteNonQueryAsync();
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message);
                            transaction.Rollback();
                        }
                    }
                }
            }
        }
    }
}
