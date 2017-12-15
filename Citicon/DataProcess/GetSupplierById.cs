using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetSupplierById : DataProcessBase
    {
        public GetSupplierById(ulong supplierId)
        {
            _SupplierId = supplierId;
        }

        private readonly ulong _SupplierId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("_suppliers_getbyid", connection);
            command.Parameters.AddWithValue("@_SupplierId", _SupplierId);

            return command;
        }

        private Supplier FromReader(DbDataReader reader)
        {
            return new Supplier
            {
                Id = _SupplierId,
                Address = reader.GetString("Address"),
                Code = reader.GetString("Code"),
                ContactNumber = reader.GetString("ContactNumber"),
                Description = reader.GetString("Description")
            };
        }

        public Task<Supplier> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
