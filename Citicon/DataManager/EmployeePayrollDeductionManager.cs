using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class EmployeePayrollDeductionManager
    {
        public static async Task<EmployeePayrollDeduction> InsertAsync(EmployeePayrollDeduction employeePayrollDeduction)
        {
            if (employeePayrollDeduction != null)
            {
                using (var process = new InsertEmployeePayrollDeduction(employeePayrollDeduction))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeePayrollDeduction> InsertAsync(EmployeePayrollDeduction employeePayrollDeduction, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (employeePayrollDeduction != null)
            {
                using (var process = new InsertEmployeePayrollDeduction(employeePayrollDeduction))
                {
                    return await process.ExecuteAsync(connection, transaction);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeePayrollDeduction> GetAsync(ulong id)
        {
            if (id > 0)
            {
                using (var process = new GetEmployeePayrollDeduction(id))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeePayrollDeduction> GetCurrentByEmployeeAsync(Employee employee)
        {
            if (employee != null)
            {
                using (var process = new GetCurrentEmployeePayrollDeductionByEmployee(employee))
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
