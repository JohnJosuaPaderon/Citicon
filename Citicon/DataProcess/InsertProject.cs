using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertProject : DataProcessBase
    {
        public InsertProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;
        private const string Parameter_Id = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertProject", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
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
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    Project.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                }
                else
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
