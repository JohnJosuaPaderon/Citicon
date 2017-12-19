using Citicon.Data;
using Citicon.DataProcess;
using Citicon.Reports;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class PayrollManager
    {
        public async Task<IEnumerable<EmployeePayroll>> GeneratePayrollAsync(Payroll payroll)
        {
            if (payroll != null)
            {
                var process = new GeneratePayroll(payroll);
                return await process.ExecuteAsync();
            }
            else
            {
                return null;
            }
        }

        public async Task ExportPayrollAsync(Payroll payroll)
        {
            if (payroll != null)
            {
                var exporter = new ExportPayroll(payroll);
                await exporter.ExportAsync();
            }
        }

        public async Task<Payroll> InsertAsync(Payroll payroll)
        {
            if (payroll != null)
            {
                using (var process = new InsertPayroll(payroll))
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
