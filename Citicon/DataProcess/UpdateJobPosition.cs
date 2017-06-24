using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateJobPosition : DataProcessBase
    {
        public UpdateJobPosition(JobPosition jobPosition)
        {
            JobPosition = jobPosition ?? throw new ArgumentNullException(nameof(jobPosition));
        }

        private JobPosition JobPosition { get; set; }

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateJobPosition", connection, transaction);
            command.Parameters.AddWithValue("@_Id", JobPosition.Id);
            command.Parameters.AddWithValue("@_Name", JobPosition.Name);
            command.Parameters.AddWithValue("@_DepartmentId", JobPosition.Department?.Id);

            return command;
        }

        public async Task<JobPosition> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 0)
                {
                    JobPosition = null;
                }

                return JobPosition;
            }
        }

        public Task<JobPosition> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
