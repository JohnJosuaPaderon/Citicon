using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class SaveBillingSiNumber : IDisposable
    {
        private string SiNumber;
        private IEnumerable<Billing> Billings;
        private MySqlConnectionHelper ConnectionHelper;

        public SaveBillingSiNumber(string siNumber, IEnumerable<Billing> billings)
        {
            SiNumber = siNumber;
            Billings = billings;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        foreach (var item in Billings)
                        {
                            await ExecuteSingleAsync(item, connection, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.Message);
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private async Task ExecuteSingleAsync(Billing billing, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("SaveBillingSiNumber", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@_BillingId", billing.Id);
                command.Parameters.AddWithValue("@_SiNumber", SiNumber);
                await command.ExecuteNonQueryAsync();
            }
        }

        public void Dispose()
        {
            SiNumber = null;
            Billings = null;
            ConnectionHelper = null;
        }
    }
}
