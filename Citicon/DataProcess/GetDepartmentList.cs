using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDepartmentList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDepartmentList", connection);
            return command;
        }

        private Department FromReader(DbDataReader reader)
        {
            return new Department()
            {
                Id = reader.GetInt64("Id"),
                Name = reader.GetString("Name")
            };
        }

        public Task<IEnumerable<Department>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }
    }
}
