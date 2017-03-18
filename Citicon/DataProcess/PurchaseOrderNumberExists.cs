using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class PurchaseOrderNumberExists : DataProcess
    {
        public PurchaseOrderNumberExists(string purchaseOrderNumber)
        {
            PurchaseOrderNumber = string.IsNullOrWhiteSpace(purchaseOrderNumber) ? throw new ArgumentNullException(nameof(purchaseOrderNumber)) : purchaseOrderNumber;
        }

        private string PurchaseOrderNumber;
        private const string Parameter_Number = "@_Number";

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                Connection = connection,
                CommandText = string.Format("SELECT PurchaseOrderNumberExists({0});", Parameter_Number)
            };
            command.Parameters.AddWithValue(Parameter_Number, PurchaseOrderNumber);

            return command;
        }

        public async Task<bool> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return Convert.ToBoolean(await command.ExecuteScalarAsync());
            }
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
