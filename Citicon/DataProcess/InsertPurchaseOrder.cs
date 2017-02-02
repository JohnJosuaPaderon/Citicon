using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Citicon.DataProcess
{
    public sealed class InsertPurchaseOrder : IDisposable
    {
        #region Constructor
        public InsertPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder == null)
            {
                throw new ArgumentNullException(nameof(purchaseOrder));
            }

            PurchaseOrder = purchaseOrder;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private PurchaseOrder PurchaseOrder;
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        #region Helpers
        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand("InsertPurchaseOrder", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new MySqlParameter() { ParameterName = "@_PurchaseOrderId", Direction = ParameterDirection.Output });
            command.Parameters.AddWithValue("@_Number", PurchaseOrder.Number);
            command.Parameters.AddWithValue("@_Balance", PurchaseOrder.Balance);
            return command;
        }

        private void GetOutParameters(MySqlCommand command)
        {
            PurchaseOrder.Id = Convert.ToUInt64(command.Parameters["@_PurchaseOrderId"].Value);
        }
        #endregion

        #region Executions
        internal PurchaseOrder Execute(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                command.ExecuteNonQuery();
                GetOutParameters(command);
                return PurchaseOrder;
            }
        }

        public PurchaseOrder Execute()
        {
            using (var connection = ConnectionHelper.EstablishConnection())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            Execute(connection, transaction);
                            transaction.Commit();
                            return PurchaseOrder;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
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
