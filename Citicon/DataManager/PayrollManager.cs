using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PayrollManager
    {
        public static async Task<SemiMonthlyPayroll> SaveSemiMonthlyAsync(SemiMonthlyPayroll semiMonthlyPayroll)
        {
            if (semiMonthlyPayroll != null)
            {
                using (var process = new SaveSemiMonthlyPayroll(semiMonthlyPayroll))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
