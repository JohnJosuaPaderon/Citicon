using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.OtherChargeProcesses
{
    public sealed class InsertOtherCharge
    {
        #region Constructor
        public InsertOtherCharge(OtherCharge otherCharge)
        {
            OtherCharge = otherCharge;
        }
        #endregion

        #region Properties
        private OtherCharge OtherCharge { get; set; }
        #endregion

        #region Execution
        public async Task<OtherCharge> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("InsertOtherCharge", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                const string PARAM_ID = "@_Id";
                command.Parameters.Add(new MySqlParameter { ParameterName = PARAM_ID, Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_BillingId", OtherCharge.Billing.Id);
                command.Parameters.AddWithValue("@_TypeId", OtherCharge.Type?.Id);
                command.Parameters.AddWithValue("@_Amount", OtherCharge.Amount);
                command.Parameters.AddWithValue("@_Unit", OtherCharge.Unit);
                command.Parameters.AddWithValue("@_Remarks", OtherCharge.Remarks);

                await command.ExecuteNonQueryAsync();

                var _id = command.Parameters[PARAM_ID].Value;

                if (_id != DBNull.Value)
                {
                    OtherCharge.Id = Convert.ToUInt64(_id);
                }

                return OtherCharge;
            }
        }
        #endregion
    }
}
