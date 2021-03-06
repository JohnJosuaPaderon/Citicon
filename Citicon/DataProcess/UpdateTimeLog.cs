﻿using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateTimeLog : DataProcessBase
    {
        public UpdateTimeLog(TimeLog timeLog)
        {
            TimeLog = timeLog ?? throw new ArgumentNullException(nameof(timeLog));
        }

        private TimeLog TimeLog;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateTimeLog", connection, transaction);
            command.Parameters.AddWithValue("@_Id", TimeLog.Id);
            command.Parameters.AddWithValue("@_EmployeeLoginId", TimeLog.EmployeeLogin.Id);
            command.Parameters.AddWithValue("@_Login", TimeLog.Login);
            command.Parameters.AddWithValue("@_Logout", TimeLog.Logout);
            command.AddOutParameter("@_TypeId");

            return command;
        }

        public override void Dispose()
        {
            TimeLog = null;
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
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    TimeLog = null;
                }
                else
                {
                    TimeLog.Type = await new TimeLogTypeManager().GetByIdAsync(command.Parameters.GetUInt64("@_TypeId"));
                }

                return TimeLog;
            }
        }
    }
}
