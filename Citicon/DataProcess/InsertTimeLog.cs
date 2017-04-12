using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertTimeLog : DataProcessBase
    {
        public InsertTimeLog(TimeLog timeLog)
        {
            TimeLog = timeLog ?? throw new ArgumentNullException(nameof(timeLog));
            TypeManager = new TimeLogTypeManager();
        }

        private TimeLog TimeLog;
        private TimeLogTypeManager TypeManager;
        private const string Parameter_Id = "@_Id";
        private const string Parameter_TypeId = "@_TypeId";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertTimeLog", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
            command.Parameters.AddWithValue("@_EmployeeLoginId", TimeLog.EmployeeLogin?.Id);
            command.Parameters.AddWithValue("@_Login", TimeLog.Login);
            command.Parameters.AddWithValue("@_Logout", TimeLog.Logout);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_TypeId));

            return command;
        }

        public override void Dispose()
        {
            TimeLog = null;
            TypeManager = null;
            base.Dispose();
        }

        public Task<TimeLog> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        public async Task<TimeLog> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    TimeLog.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                    TimeLog.Type = await TypeManager.GetByIdAsync(Convert.ToUInt64(command.Parameters[Parameter_TypeId].Value));
                }
                else
                {
                    TimeLog = null;
                }

                return TimeLog;
            }
        }
    }
}
