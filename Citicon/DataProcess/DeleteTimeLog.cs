using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteTimeLog : DataProcessBase
    {
        public DeleteTimeLog(TimeLog timeLog)
        {
            TimeLog = timeLog ?? throw new ArgumentNullException(nameof(timeLog));
        }

        private TimeLog TimeLog;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteTimeLog", connection, transaction);
            command.Parameters.AddWithValue("@_Id", TimeLog.Id);

            return command;
        }

        public override void Dispose()
        {
            TimeLog = null;
            base.Dispose();
        }

        public async Task<TimeLog> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    TimeLog = null;
                }

                return TimeLog;
            }
        }

        public Task<TimeLog> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
