using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateProject : DataProcessBase
    {
        public UpdateProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateProject", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Project.Id);
            command.Parameters.AddWithValue("@_ClientId", Project.Client?.Id);
            command.Parameters.AddWithValue("@_Name", Project.Name);
            command.Parameters.AddWithValue("@_Location", Project.Location);
            command.Parameters.AddWithValue("@_Type", Project.Type.ToString());
            command.Parameters.AddWithValue("@_InitialPayment", Project.InitialPayment);
            command.Parameters.AddWithValue("@_InitialCement", Project.InitialCement);
            command.Parameters.AddWithValue("@_Completed", Project.Completed);
            command.Parameters.AddWithValue("@_QuotationType", Project.QuotationType.ToString());

            return command;
        }

        public override void Dispose()
        {
            Project = null;
            base.Dispose();
        }

        public async Task<Project> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    Project = null;
                }

                return Project;
            }
        }

        public Task<Project> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
