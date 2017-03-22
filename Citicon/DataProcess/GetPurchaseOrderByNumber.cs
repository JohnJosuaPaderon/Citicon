using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;

namespace Citicon.DataProcess
{
    public sealed class GetPurchaseOrderByNumber : IDisposable
    {
        #region Constructor
        public GetPurchaseOrderByNumber(string purchaseOrderNumber)
        {
            PurchaseOrderNumber = string.IsNullOrWhiteSpace(purchaseOrderNumber) ? throw new ArgumentException("Cannot be null or white space.", nameof(purchaseOrderNumber)) : purchaseOrderNumber;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private string PurchaseOrderNumber;
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        #region Helpers
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand("GetPurchaseOrderByNumber", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@_PurchaseOrderNumber", PurchaseOrderNumber);
            return command;
        }

        private PurchaseOrder FromReader(DbDataReader reader)
        {
            return new PurchaseOrder
            {
                Id = reader.GetUInt64("Id"),
                Number = PurchaseOrderNumber,
                //RunningBalance = reader.GetDecimal("RunningBalance")
            };
        }
        #endregion

        #region Executions
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

        internal PurchaseOrder Execute()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
