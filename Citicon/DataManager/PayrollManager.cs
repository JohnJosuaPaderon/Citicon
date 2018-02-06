using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PayrollManager
    {
        public static async Task<IEnumerable<SemiMonthlyPayrollEmployee>> GenerateSemiMonthlyPayrollEmployeeListAsync(SemiMonthlyPayroll payroll)
        {
            if (payroll != null)
            {
                using (var process = new GenerateSemiMonthlyPayrollEmployeeList(payroll))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

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
