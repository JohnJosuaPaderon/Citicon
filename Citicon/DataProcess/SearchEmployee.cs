using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SearchEmployee : DataProcess
    {
        public SearchEmployee(string keyword)
        {
            Keyword = keyword;
        }

        private string Keyword;

        private Employee FromReader(DbDataReader reader)
        {
            return new Employee()
            {
                FirstName = reader.GetString("FirstName"),
                Id = reader.GetInt64("Id"),
                LastName = reader.GetString("LastName"),
                MiddleName = reader.GetString("MiddleName"),
                Position = JobPositionManager.GetById(reader.GetInt64("PositionId"))
            };
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("SearchEmployee", connection);
            command.Parameters.AddWithValue("@_Keyword", Keyword);

            return command;
        }

        public Task<IEnumerable<Employee>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return ProcessUtility.HandleReadingIEnumerableAsync(command, FromReader);
            }
        }

        public Task<IEnumerable<Employee>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
