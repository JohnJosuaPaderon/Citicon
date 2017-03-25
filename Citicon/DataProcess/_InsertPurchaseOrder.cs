using Citicon.Data;
using MySql.Data.MySqlClient;
using System;

namespace Citicon.DataProcess
{
    public sealed class _InsertPurchaseOrder : DataProcessBase
    {
        public _InsertPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            PurchaseOrder = purchaseOrder ?? throw new ArgumentNullException(nameof(purchaseOrder));
        }

        private PurchaseOrder PurchaseOrder;
        private const string Parameter_Id = "@_PurchaseOrderId";
        
        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("_InsertPurchaseOrder", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
            command.Parameters.AddWithValue("@_Number", PurchaseOrder.Number);
            return command;
        }

        public PurchaseOrder Execute(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    PurchaseOrder.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                }
                else
                {
                    PurchaseOrder = null;
                }

                return PurchaseOrder;
            }
        }

        public PurchaseOrder Execute()
        {
            return ProcessUtility.HandleExecute(Execute);
        }
    }
}
