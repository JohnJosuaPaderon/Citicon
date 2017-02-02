using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.BillingProcesses
{
    public sealed class InsertBilling : IDisposable
    {
        #region Constructor
        public InsertBilling(Billing billing)
        {
            Billing = billing;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private Billing Billing;
        private MySqlConnectionHelper ConnectionHelper;
        #endregion

        #region Execution
        public async Task<Billing> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        await ExecuteCoreAsync(connection, transaction);
                        await DeliveriesExecuteAsync(connection, transaction);
                        await PumpcreteChargesExecuteAsync(connection, transaction);
                        await ExcessPipeChargesExecuteAsync(connection, transaction);
                        await OtherChargeExecuteAsync(connection, transaction);
                        transaction.Commit();
                        return Billing;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private async Task DeliveriesExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            for (int i = 0; i < Billing.Deliveries.Count; i++)
            {
                Billing.Deliveries[i].Billing = Billing;
                await DeliveryManager.UpdateDeliveryBillingId(Billing.Deliveries[i], connection, transaction);
            }
        }

        private async Task PumpcreteChargesExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            for (int i = 0; i < Billing.PumpcreteCharges.Count; i++)
            {
                Billing.PumpcreteCharges[i].Billing = Billing;
                Billing.PumpcreteCharges[i] = await PumpcreteChargeManager.InsertAsync(Billing.PumpcreteCharges[i], connection, transaction);
            }
        }

        private async Task ExcessPipeChargesExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            for (int i = 0; i < Billing.ExcessPipeCharges.Count; i++)
            {
                Billing.ExcessPipeCharges[i].Billing = Billing;
                Billing.ExcessPipeCharges[i] = await ExcessPipeChargeManager.InsertAsync(Billing.ExcessPipeCharges[i], connection, transaction);
            }
        }

        private async Task OtherChargeExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            for (int i = 0; i < Billing.OtherCharges.Count; i++)
            {
                Billing.OtherCharges[i].Billing = Billing;
                Billing.OtherCharges[i] = await OtherChargeManager.InsertAsync(Billing.OtherCharges[i], connection, transaction);
            }
        }

        private async Task ExecuteCoreAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("InsertBilling", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                const string PARAM_ID = "@_Id";
                const string PARAM_BILLINGNO = "@_BillingNumber";
                command.Parameters.Add(new MySqlParameter { ParameterName = PARAM_ID, Direction = ParameterDirection.Output });
                command.Parameters.Add(new MySqlParameter { ParameterName = PARAM_BILLINGNO, Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_Volume", Billing.Volume);
                command.Parameters.AddWithValue("@_AmountDue", Billing.AmountDue);
                command.Parameters.AddWithValue("@_AmountPaid", Billing.AmountPaid);
                command.Parameters.AddWithValue("@_StructureTypeId", Billing.StructureType.Id);
                command.Parameters.AddWithValue("@_ProjectId", Billing.Project.Id);
                command.Parameters.AddWithValue("@_BillingDate", Billing.BillingDate);
                command.Parameters.AddWithValue("@_PreparedBy", Billing.PreparedBy);
                command.Parameters.AddWithValue("@_CheckedBy", Billing.CheckedBy);
                command.Parameters.AddWithValue("@_CertifiedBy", Billing.CertifiedBy);
                command.Parameters.AddWithValue("@_ReceivedBy", Billing.ReceivedBy);

                await command.ExecuteNonQueryAsync();

                var _id = command.Parameters[PARAM_ID].Value;
                var _billingNo = command.Parameters[PARAM_BILLINGNO].Value;

                if (_id != DBNull.Value)
                {
                    Billing.Id = Convert.ToUInt64(_id);
                    Billing.BillingNo = Convert.ToString(_billingNo);
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
