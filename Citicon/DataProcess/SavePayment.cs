using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class SavePayment : DataProcessBase
    {
        private BillingPayment BillingPayment;

        public SavePayment(BillingPayment billingPayment)
        {
            BillingPayment = billingPayment;
        }

        public async Task ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        await SaveBillingPaymentAsync(connection, transaction);
                        foreach (Billing billing in BillingPayment.Billings)
                        {
                            await SaveBillingPaymentSingleItemAsync(billing, connection, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private async Task SaveBillingPaymentSingleItemAsync(Billing billing, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("SaveBillingPaymentSingleItem", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@_Id", billing.Id);
                command.Parameters.AddWithValue("@_AmountPaid", billing.AmountPaid);
                command.Parameters.AddWithValue("@_PaymentId", BillingPayment.Id);
                await command.ExecuteNonQueryAsync();
            }
        }

        private async Task SaveBillingPaymentAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("SaveBillingPayment", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter { ParameterName = "@_Id", Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_PaymentType", BillingPayment.PaymentType);
                command.Parameters.AddWithValue("@_AmountPaid", BillingPayment.AmountPaid);
                command.Parameters.AddWithValue("@_VatIncluded", BillingPayment.VatIncluded);
                command.Parameters.AddWithValue("@_VatLess", BillingPayment.VatLess);
                command.Parameters.AddWithValue("@_Ewt", BillingPayment.Ewt);
                command.Parameters.AddWithValue("@_TotalVat", BillingPayment.TotalVat);
                await command.ExecuteNonQueryAsync();
                BillingPayment.Id = Convert.ToUInt64(command.Parameters["@_Id"].Value);
            }
        }

        public override void Dispose()
        {
            BillingPayment = null;
            base.Dispose();
        }
    }
}
