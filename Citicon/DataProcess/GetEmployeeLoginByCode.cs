using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeeLoginByCode : DataProcess
    {
        public GetEmployeeLoginByCode(uint loginCode)
        {
            LoginCode = loginCode;
        }

        private uint LoginCode;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetEmployeeLoginByCode", connection);
            command.Parameters.AddWithValue("@_LoginCode", LoginCode);

            return command;
        }

        private async Task<EmployeeLogin> FromReaderAsync(DbDataReader reader)
        {
            return new EmployeeLogin()
            {
                Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
                Id = reader.GetUInt64("Id"),
                LoginCode = LoginCode
            };
        }

        public Task<EmployeeLogin> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return ProcessUtility.HandleReadingAsync(command, FromReaderAsync);
            }
        }

        public Task<EmployeeLogin> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
