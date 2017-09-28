using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetClientListWithCementSuppliedProject : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetClientListWithCementSuppliedProject", connection);
            return command;
        }

        private Client FromReader(DbDataReader reader)
        {
            return new Client()
            {
                Id = reader.GetUInt64("Id"),
                CompanyName = reader.GetString("CompanyName")
            };
        }

        public Task<IEnumerable<Client>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        public Task<IEnumerable<Client>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
