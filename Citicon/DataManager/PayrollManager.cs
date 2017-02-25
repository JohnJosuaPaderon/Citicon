using Citicon.Data;
using Citicon.DataProcess;
using Citicon.Reports;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class PayrollManager
    {
        public async Task<IEnumerable<EmployeePayroll>> GeneratePayrollAsync(DateTimeRange rangeDate, Branch branch)
        {
            if (branch != null && rangeDate != null)
            {
                var process = new GeneratePayroll(rangeDate, branch);
                return await process.ExecuteAsync();
            }
            else
            {
                return null;
            }
        }

        public void ExportPayroll(Payroll payroll)
        {
            if (payroll != null)
            {
                var exporter = new ExportPayroll(payroll);
                exporter.Export();
            }
        }
    }
}
