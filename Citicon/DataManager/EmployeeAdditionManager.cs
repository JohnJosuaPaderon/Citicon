using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class EmployeeAdditionManager
    {
        public static async Task<EmployeeAddition> SaveAsync(EmployeeAddition employeeAddition, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (employeeAddition != null)
            {
                using (var process = new SaveEmployeeAddition(employeeAddition))
                {
                    return await process.ExecuteAsync(connection, transaction);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeeAddition> GetAsync(Employee employee)
        {
            if (employee != null)
            {
                using (var process = new GetEmployeeAddition(employee))
                {
                    var result = await process.ExecuteAsync();
                    employee.Addition = result;
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
