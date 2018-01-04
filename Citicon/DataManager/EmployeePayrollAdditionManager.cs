using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class EmployeePayrollAdditionManager
    {
        public static async Task<EmployeePayrollAddition> InsertAsync(EmployeePayrollAddition employeePayrollAddition)
        {
            if (employeePayrollAddition != null)
            {
                using (var process = new InsertEmployeePayrollAddition(employeePayrollAddition))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeePayrollAddition> InsertAsync(EmployeePayrollAddition employeePayrollAddition, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (employeePayrollAddition != null)
            {
                using (var process = new InsertEmployeePayrollAddition(employeePayrollAddition))
                {
                    return await process.ExecuteAsync(connection, transaction);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeePayrollAddition> GetAsync(ulong id)
        {
            if (id > 0)
            {
                using (var process = new GetEmployeePayrollAddition(id))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeePayrollAddition> GetCurrentByEmployeeAsync(Employee employee)
        {
            if (employee != null)
            {
                using (var process = new GetCurrentEmployeePayrollAdditionByEmployee(employee))
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
