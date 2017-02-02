using Citicon.Data;
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
    public class SaveProjectDetails
    {
        ProjectDesign ProjectDesign;
        MySqlConnectionHelper ConnectionHelper;
        public SaveProjectDetails(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public void Execute()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = new MySqlCommand("SaveProjectDesign", connection, transaction))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_ProjectId", ProjectDesign.Project.Id);
                        command.Parameters.AddWithValue("@_PricePerCubic", ProjectDesign.PricePerCubicMeter);
                        command.Parameters.AddWithValue("@_InitialVolume", ProjectDesign.InitialVolume);
                        command.Parameters.AddWithValue("@_DesignMixType", ProjectDesign.MixType.ToString());
                        command.Parameters.AddWithValue("@_Psi", ProjectDesign.Psi);
                        command.Parameters.AddWithValue("@_AggregateId", ProjectDesign.Aggregate.Id);
                        command.Parameters.AddWithValue("@_StrengthId", ProjectDesign.Strength.Id);
                        command.Parameters.AddWithValue("@_CementFactor", ProjectDesign.CementFactor);
                        try
                        {
                            command.ExecuteNonQuery();
                            transaction.Commit();
                        }
                        catch (Exception e)
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }
        }
    }
}
