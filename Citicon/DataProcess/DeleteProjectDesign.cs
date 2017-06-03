using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteProjectDesign : DataProcessBase
    {
        public DeleteProjectDesign(ProjectDesign projectDesign, bool includeToRevisedQuotation)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
            IncludeToRevisedQuotation = includeToRevisedQuotation;
        }

        private ProjectDesign ProjectDesign;
        private bool IncludeToRevisedQuotation;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteProjectDesign", connection, transaction);
            command.Parameters.AddWithValue("@_Id", ProjectDesign.Id);
            command.Parameters.AddWithValue("@_IncludeToRevisedQuotation", IncludeToRevisedQuotation);

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
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    ProjectDesign = null;
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
