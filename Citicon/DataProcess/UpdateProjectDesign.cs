using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateProjectDesign : DataProcessBase
    {
        public UpdateProjectDesign(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
        }

        private ProjectDesign ProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateProjectDesign", connection, transaction);
            command.Parameters.Add(Utility.CreateInOutParameter("@_Id", ProjectDesign.Id));
            command.Parameters.AddWithValue("@_MixType", ProjectDesign.MixType.ToString());
            command.Parameters.AddWithValue("@_ProjectId", ProjectDesign.Project?.Id);
            command.Parameters.AddWithValue("@_Psi", ProjectDesign.Psi);
            command.Parameters.AddWithValue("@_AggregateId", ProjectDesign.Aggregate?.Id);
            command.Parameters.AddWithValue("@_StrengthId", ProjectDesign.Strength?.Id);
            command.Parameters.AddWithValue("@_PricePerCubicMeter", ProjectDesign.PricePerCubicMeter);
            command.Parameters.AddWithValue("@_CementFactor", ProjectDesign.CementFactor);
            command.Parameters.AddWithValue("@_ForApproval", ProjectDesign.ForApproval);
            command.Parameters.AddWithValue("@_QuotationId", ProjectDesign.Quotation?.Id);
            return command;
        }

        public override void Dispose()
        {
            ProjectDesign = null;
            base.Dispose();
        }

        public async Task<ProjectDesign> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    if (ProjectDesign.Id == 0)
                    {
                        ProjectDesign.Id = Convert.ToUInt64(command.Parameters["@_Id"].Value);
                    }
                    else
                    {
                        ProjectDesign = null;
                    }
                }

                return ProjectDesign;
            }
        }

        public Task<ProjectDesign> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
