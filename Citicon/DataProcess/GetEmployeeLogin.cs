using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeeLogin : DataProcessBase
    {
        public GetEmployeeLogin(Employee employee)
        {
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private Employee Employee;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetEmployeeLogin", connection);
            command.Parameters.AddWithValue("@_EmployeeId", Employee.Id);

            return command;
        }

        public Task<EmployeeLogin> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }

        private EmployeeLogin FromReader(DbDataReader reader)
        {
            return new EmployeeLogin()
            {
                Id = reader.GetUInt64("Id"),
                Employee = Employee,
                LoginCode = reader.GetUInt32("LoginCode")
            };
        }
    }
}
