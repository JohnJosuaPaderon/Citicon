using System.Collections.Generic;
using System.Threading.Tasks;
using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Citicon.DataProcess
{
    internal sealed class GetSupplierList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetSupplierList", connection);
            return command;
        }

        private Supplier FromReader(DbDataReader reader)
        {
            return new Supplier()
            {
                Address = reader.GetString("Address"),
                Code = reader.GetString("Code"),
                ContactNumber = reader.GetString("ContactNumber"),
                Description = reader.GetString("Description"),
                Id = reader.GetUInt64("Id")
            };
        }

        public Task<IEnumerable<Supplier>> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return ProcessUtility.HandleReadingIEnumerableAsync(command, FromReader);
            }
        }

        public Task<IEnumerable <Supplier>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
