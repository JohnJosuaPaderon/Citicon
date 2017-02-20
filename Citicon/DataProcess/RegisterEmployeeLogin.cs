using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class RegisterEmployeeLogin : DataProcess
    {
        public RegisterEmployeeLogin(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            Employee = employee;
        }

        private Employee Employee;
        private const string PARAMETER_ID = "@_Id";
        private const string PARAMETER_LOGINCODE = "@_LoginCode";
        private EmployeeLogin LoginInfo;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("RegisterEmployeeLogin", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(PARAMETER_ID));
            command.Parameters.AddWithValue("@_EmployeeId", Employee.Id);
            command.Parameters.Add(Utility.CreateOutParameter(PARAMETER_LOGINCODE));

            return command;
        }

        private void Validate(int affectedRows, MySqlParameterCollection parameters)
        {
            if (affectedRows > 0)
            {
                LoginInfo = new EmployeeLogin()
                {
                    Employee = Employee,
                    Id = Convert.ToUInt64(parameters[PARAMETER_ID].Value),
                    LoginCode = Convert.ToUInt32(parameters[PARAMETER_LOGINCODE].Value)
                };
            }
            else
            {
                LoginInfo = null;
            }
        }

        public async Task<EmployeeLogin> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                Validate(await command.ExecuteNonQueryAsync(), command.Parameters);
                return LoginInfo;
            }
        }

        public Task<EmployeeLogin> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
