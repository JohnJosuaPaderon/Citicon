using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class EmployeeDeductionManager
    {
        public static async Task<EmployeeDeduction> SaveAsync(EmployeeDeduction employeeDeduction, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (employeeDeduction != null)
            {
                using (var process = new SaveEmployeeDeduction(employeeDeduction))
                {
                    return await process.ExecuteAsync(connection, transaction);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeeDeduction> GetAsync(Employee employee)
        {
            if (employee != null)
            {
                using (var process = new GetEmployeeDeduction(employee))
                {
                    var result = await process.ExecuteAsync();
                    employee.Deduction = result;
                    return result;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
