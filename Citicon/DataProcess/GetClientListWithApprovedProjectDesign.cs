using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetClientListWithApprovedProjectDesign : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetClientListWithApprovedProjectDesign", connection);
            return command;
        }

        public Task<IEnumerable<Client>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReader);
        }

        public Task<IEnumerable<Client>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private Client FromReader(DbDataReader reader)
        {
            return new Client()
            {
                Id = reader.GetUInt64("Id"),
                CompanyName = reader.GetString("CompanyName")
            };
        }
    }
}
