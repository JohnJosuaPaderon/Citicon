using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetPayrollGroupList : DataProcess
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetPayrollGroupList", connection);

            return command;
        }

        private PayrollGroup FromReader(DbDataReader reader)
        {
            return new PayrollGroup()
            {
                Id = reader.GetUInt32("Id"),
                Description = reader.GetString("Description"),
                SortCode = reader.GetUInt32("SortCode")
            };
        }

        public Task<IEnumerable<PayrollGroup>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReader);
        }

        public Task<IEnumerable<PayrollGroup>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
