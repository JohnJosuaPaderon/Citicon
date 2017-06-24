using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertJobPosition : DataProcessBase
    {
        public InsertJobPosition(JobPosition jobPosition)
        {
            JobPosition = jobPosition ?? throw new ArgumentNullException(nameof(jobPosition));
        }

        private JobPosition JobPosition { get; set; }
        private const string PARAMETER_ID = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertJobPosition", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(PARAMETER_ID));
            command.Parameters.AddWithValue("@_Name", JobPosition.Name);
            command.Parameters.AddWithValue("@_DepartmentId", JobPosition.Department?.Id);

            return command;
        }

        public async Task<JobPosition> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    JobPosition.Id = Convert.ToInt64(command.Parameters[PARAMETER_ID].Value);
                }
                else
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
