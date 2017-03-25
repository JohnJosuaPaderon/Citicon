using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class LogEmployee : DataProcessBase
    {
        public LogEmployee(EmployeeLogin loginInfo)
        {
            LoginInfo = loginInfo ?? throw new ArgumentNullException(nameof(loginInfo));
            TimeLogTypeManager = new TimeLogTypeManager();
        }

        private EmployeeLogin LoginInfo;
        private TimeLogTypeManager TimeLogTypeManager;
        private const string PARAMETER_ID = "@_Id";
        private const string PARAMETER_LOGIN = "@_Login";
        private const string PARAMETER_LOGOUT = "@_Logout";
        private const string PARAMETER_TYPEID = "@_TypeId";
        private TimeLog TimeLog;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("LogEmployee", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(PARAMETER_ID));
            command.Parameters.Add(Utility.CreateOutParameter(PARAMETER_LOGIN));
            command.Parameters.Add(Utility.CreateOutParameter(PARAMETER_LOGOUT));
            command.Parameters.Add(Utility.CreateOutParameter(PARAMETER_TYPEID));
            command.Parameters.AddWithValue("@_EmployeeLoginId", LoginInfo.Id);

            return command;
        }

        private async Task Validate(int affectedRows, MySqlParameterCollection parameters)
        {
            if (affectedRows > 0)
            {
                var loginParameter = parameters[PARAMETER_LOGIN].Value;
                var logoutParameter = parameters[PARAMETER_LOGOUT].Value;

                TimeLog = new TimeLog()
                {
                    EmployeeLogin = LoginInfo,
                    Id = Convert.ToUInt64(parameters[PARAMETER_ID].Value),
                    Login = loginParameter != DBNull.Value ? new DateTime?(Convert.ToDateTime(loginParameter)) : null,
                    Logout = logoutParameter != DBNull.Value ? new DateTime?(Convert.ToDateTime(logoutParameter)) : null,
                    Type = await TimeLogTypeManager.GetByIdAsync(Convert.ToUInt64(parameters[PARAMETER_TYPEID].Value))
                };
            }
        }

        public async Task<TimeLog> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await Validate(await command.ExecuteNonQueryAsync(), command.Parameters);
                return TimeLog;
            }
        }

        public Task<TimeLog> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
