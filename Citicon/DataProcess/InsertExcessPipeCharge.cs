using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class InsertExcessPipeCharge
    {
        #region Constructor
        public InsertExcessPipeCharge(ExcessPipeCharge excessPipeCharge)
        {
            ExcessPipeCharge = excessPipeCharge;
        }
        #endregion

        #region Properties
        private ExcessPipeCharge ExcessPipeCharge { get; set; }
        #endregion

        #region Execution
        public async Task<ExcessPipeCharge> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            ExcessPipeCharge.OperationTimeFrame = await OperationTimeFrameManager.InsertAsync(ExcessPipeCharge.OperationTimeFrame, connection, transaction);
            return await ExecuteCoreAsync(connection, transaction);
        }

        private async Task<ExcessPipeCharge> ExecuteCoreAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("InsertExcessPipeCharge", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                const string PARAM_ID = "@_Id";
                command.Parameters.Add(new MySqlParameter { ParameterName = PARAM_ID, Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_BillingId", ExcessPipeCharge.Billing.Id);
                command.Parameters.AddWithValue("@_AccessoryTypeId", ExcessPipeCharge.AccessoryType?.Id);
                command.Parameters.AddWithValue("@_OperationTimeFrameId", ExcessPipeCharge.OperationTimeFrame?.Id);
                command.Parameters.AddWithValue("@_MaximumCount", ExcessPipeCharge.MaximumCount);
                command.Parameters.AddWithValue("@_ChargePerCubicMeter", ExcessPipeCharge.ChargePerCubicMeter);
                command.Parameters.AddWithValue("@_Amount", ExcessPipeCharge.Amount);

                await command.ExecuteNonQueryAsync();

                var _id = command.Parameters[PARAM_ID].Value;

                if (_id != DBNull.Value)
                {
                    ExcessPipeCharge.Id = Convert.ToUInt64(_id);
                }

                return ExcessPipeCharge;
            }
        }
        #endregion
    }
}
