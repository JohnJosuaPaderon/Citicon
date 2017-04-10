using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeeLoginById : DataProcessBase
    {
        public GetEmployeeLoginById(ulong employeeLoginId)
        {
            EmployeeLoginId = employeeLoginId > 0 ? employeeLoginId : throw new ArgumentException("Value cannot be zero.", nameof(employeeLoginId));
        }

        private ulong EmployeeLoginId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetEmployeeLoginById", connection);
            command.Parameters.AddWithValue("@_Id", EmployeeLoginId);

            return command;
        }

        public Task<EmployeeLogin> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<EmployeeLogin> FromReaderAsync(DbDataReader reader)
        {
            return new EmployeeLogin()
            {
                Id = EmployeeLoginId,
                Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
                LoginCode = reader.GetUInt32("LoginCode")
            };
        }
    }
}
