using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class UpdateDeliveryBillingId
    {
        #region Constructor
        public UpdateDeliveryBillingId(Delivery delivery)
        {
            Delivery = delivery;
        }
        #endregion

        #region Properties
        private Delivery Delivery { get; set; }
        #endregion

        #region Execution
        public async Task ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("UpdateDeliveryBillingId", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@_Id", Delivery.Id);
                command.Parameters.AddWithValue("@_BillingId", Delivery.Billing.Id);

                await command.ExecuteNonQueryAsync();
            }
        } 
        #endregion
    }
}
