using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;

namespace Citicon.DataProcess
{
    public sealed class GetPurchaseOrderByNumber : DataProcessBase
    {
        public GetPurchaseOrderByNumber(string purchaseOrderNumber)
        {
            PurchaseOrderNumber = string.IsNullOrWhiteSpace(purchaseOrderNumber) ? throw new ArgumentException("Cannot be null or white space.", nameof(purchaseOrderNumber)) : purchaseOrderNumber;
        }

        private string PurchaseOrderNumber;
        
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetPurchaseOrderByNumber", connection);
            command.Parameters.AddWithValue("@_PurchaseOrderNumber", PurchaseOrderNumber);
            return command;
        }

        public override void Dispose()
        {
            PurchaseOrderNumber = null;
            base.Dispose();
        }

        public PurchaseOrder Execute()
        {
            return ProcessUtility.HandleReading(CreateCommand, FromReader);
        }

        private PurchaseOrder FromReader(DbDataReader reader)
        {
            return new PurchaseOrder
            {
                Id = reader.GetUInt64("Id"),
                Number = PurchaseOrderNumber
            };
        }
    }
}
