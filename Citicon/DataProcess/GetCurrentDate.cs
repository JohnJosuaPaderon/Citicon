using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCurrentDate : DataProcess
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT NOW();";

            return command;
        }

        public async Task<DateTime> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return Convert.ToDateTime(await command.ExecuteScalarAsync());
            }
        }

        public Task<DateTime> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
