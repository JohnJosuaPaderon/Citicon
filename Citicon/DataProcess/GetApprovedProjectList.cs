using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetApprovedProjectList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetApprovedProjectList", connection);
            return command;
        }

        public Task<IEnumerable<Project>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReaderAsync);
        }

        public Task<IEnumerable<Project>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private async Task<Project> FromReaderAsync(DbDataReader reader)
        {
            return new Project()
            {
                Id = reader.GetUInt64("Id"),
                Name = reader.GetString("Name"),
                Client = await ClientManager.GetByIdAsync(reader.GetUInt64("ClientId"))
            };
        }
    }
}
