using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class InsertPumpcreteCharge
    {
        #region Constructor
        public InsertPumpcreteCharge(PumpcreteCharge pumpcreteCharge)
        {
            PumpcreteCharge = pumpcreteCharge;
        }
        #endregion

        #region Properties
        private PumpcreteCharge PumpcreteCharge { get; set; }
        #endregion

        #region Execution
        public async Task<PumpcreteCharge> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            PumpcreteCharge.OperationTimeFrame = await OperationTimeFrameManager.InsertAsync(PumpcreteCharge.OperationTimeFrame, connection, transaction);
            return await ExecuteCoreAsync(connection, transaction);
        }

        private async Task<PumpcreteCharge> ExecuteCoreAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = new MySqlCommand("InsertPumpcreteCharge", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;
                const string PARAM_ID = "@_Id";
                command.Parameters.Add(new MySqlParameter { ParameterName = PARAM_ID, Direction = ParameterDirection.Output });
                command.Parameters.AddWithValue("@_BillingId", PumpcreteCharge.Billing.Id);
                command.Parameters.AddWithValue("@_PumpTypeId", PumpcreteCharge.PumpType?.Id);
                command.Parameters.AddWithValue("@_PumpSizeId", PumpcreteCharge.PumpSize?.Id);
                command.Parameters.AddWithValue("@_PricePerSetup", PumpcreteCharge.PricePerSetup);
                command.Parameters.AddWithValue("@_OperationTimeFrameId", PumpcreteCharge.OperationTimeFrame?.Id);
                command.Parameters.AddWithValue("@_TotalVolumePumped", PumpcreteCharge.TotalVolumePumped);
                command.Parameters.AddWithValue("@_Remarks", PumpcreteCharge.Remarks);

                await command.ExecuteNonQueryAsync();

                var _id = command.Parameters[PARAM_ID].Value;

                if (_id != DBNull.Value)
                {
                    PumpcreteCharge.Id = Convert.ToUInt64(_id);
                }

                return PumpcreteCharge;
            }
        }
        #endregion
    }
}
