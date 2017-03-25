using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteProject : DataProcessBase
    {
        public DeleteProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteProject", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Project.Id);

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
