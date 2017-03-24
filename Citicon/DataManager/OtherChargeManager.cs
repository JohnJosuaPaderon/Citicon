using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class OtherChargeManager
    {
        static OtherChargeManager()
        {
            OtherCharges = new List<OtherCharge>();
        }
        private static List<OtherCharge> OtherCharges { get; }
        private static OtherCharge Manage(OtherCharge otherCharge)
        {
            if (OtherCharges.Contains(otherCharge))
            {
                var index = OtherCharges.IndexOf(otherCharge);
                OtherCharges[index] = otherCharge;
            }
            else
            {
                OtherCharges.Add(otherCharge);
            }
            return otherCharge;
        }

        #region Insert
        public static async Task<OtherCharge> InsertAsync(OtherCharge otherCharge, MySqlConnection connection, MySqlTransaction transaction)
        {
            var process = new InsertOtherCharge(otherCharge);
            return Manage(await process.ExecuteAsync(connection, transaction));
        }
        #endregion
    }
}
