using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;

namespace Citicon.DataProcess
{
    public sealed class GetPurchaseOrderById : DataProcessBase
    {
        public GetPurchaseOrderById(ulong purchaseOrderId)
        {
            PurchaseOrderId = purchaseOrderId == 0 ? throw new ArgumentException("Cannot be zero.", nameof(purchaseOrderId)) : purchaseOrderId;
        }

        private ulong PurchaseOrderId;
        
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetPurchaseOrderById", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@_Id", PurchaseOrderId);
            return command;
        }

        private PurchaseOrder FromReader(DbDataReader reader)
        {
            return new PurchaseOrder
            {
                Id = PurchaseOrderId,
                Number = reader.GetString("Number"),
                MaximumCumulativePricePerCubicMeter = reader.GetDecimal("MaximumCumulativePricePerCubicMeter"),
                RunningBalance = reader.GetDecimal("RunningBalance")
            };
        }

        internal PurchaseOrder Execute(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return FromReader(reader);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public PurchaseOrder Execute()
        {
            using (var connection = Utility.EstablishConnection())
            {
                if (connection.State == ConnectionState.Open)
                {
                    return Execute(connection);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
    