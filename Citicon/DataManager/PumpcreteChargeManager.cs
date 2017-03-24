using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PumpcreteChargeManager
    {
        static PumpcreteChargeManager()
        {
            PumpcreteCharges = new List<PumpcreteCharge>();
        }
        private static List<PumpcreteCharge> PumpcreteCharges { get; }
        private static PumpcreteCharge Manage(PumpcreteCharge pumpcreteCharge)
        {
            if (PumpcreteCharges.Contains(pumpcreteCharge))
            {
                var index = PumpcreteCharges.IndexOf(pumpcreteCharge);
                PumpcreteCharges[index] = pumpcreteCharge;
            }
            else
            {
                PumpcreteCharges.Add(pumpcreteCharge);
            }
            return pumpcreteCharge;
        }

        #region Insert
        public static async Task<PumpcreteCharge> InsertAsync(PumpcreteCharge pumpcreteCharge, MySqlConnection connection, MySqlTransaction transaction)
        {
            var process = new InsertPumpcreteCharge(pumpcreteCharge);
            return Manage(await process.ExecuteAsync(connection, transaction));
        }
        #endregion
    }
}
