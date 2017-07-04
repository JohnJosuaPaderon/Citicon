using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetServiceEngineerList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetServiceEngineerList", connection);
            return command;
        }

        private Employee FromReader(DbDataReader reader)
        {
            return new Employee()
            {
                Id = reader.GetInt64("Id"),
                FirstName = reader.GetString("FirstName"),
                MiddleName = reader.GetString("MiddleName"),
                LastName = reader.GetString("LastName"),
                Position = JobPositionManager.GetById(reader.GetInt64("PositionId"))
            };
        }

        public Task<IEnumerable<Employee>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }
    }
}
