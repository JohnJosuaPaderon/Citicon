using Citicon.Data;
using Citicon.DataProcess.ExcessPipeChargeProcesses;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class ExcessPipeChargeManager
    {
        static ExcessPipeChargeManager()
        {
            ExcessPipeCharges = new List<ExcessPipeCharge>();
        }
        private static List<ExcessPipeCharge> ExcessPipeCharges { get; }
        private static ExcessPipeCharge Manage(ExcessPipeCharge excessPipeCharge)
        {
            if (ExcessPipeCharges.Contains(excessPipeCharge))
            {
                var index = ExcessPipeCharges.IndexOf(excessPipeCharge);
                ExcessPipeCharges[index] = excessPipeCharge;
            }
            else
            {
                ExcessPipeCharges.Add(excessPipeCharge);
            }

            return excessPipeCharge;
        }

        #region Insert
        public static async Task<ExcessPipeCharge> InsertAsync(ExcessPipeCharge excessPipeCharge, MySqlConnection connection, MySqlTransaction transaction)
        {
            var process = new InsertExcessPipeCharge(excessPipeCharge);
            return Manage(await process.ExecuteAsync(connection, transaction));
        }
        #endregion
    }
}
