using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class EmployeeManager
    {
        static EmployeeManager()
        {
            Employees = new Dictionary<long, Employee>();
        }

        private static Dictionary<long, Employee> Employees;

        public static async Task<Employee> DeleteAsync(Employee employee, string deletedBy)
        {
            if (employee != null && !string.IsNullOrWhiteSpace(deletedBy))
            {
                using (var process = new DeleteEmployee(employee, deletedBy))
                {
                    employee = await process.ExecuteAsync();
                }
            }

            return employee;
        }

        public static IEnumerable<Employee> GetAgent()
        {
            using (var getEmployeeAgent = new GetEmployeeAgent())
            {
                return getEmployeeAgent.Return();
            }
        }

        public static async Task<Employee> GetByIdAsync(long id)
        {
            if (Employees.ContainsKey(id))
            {
                return Employees[id];
            }
            using (var getEmployeeById = new GetEmployeeById(id))
            {
                var employee = await getEmployeeById.GetAsync();
                if (!Employees.ContainsKey(id))
                {
                    Employees.Add(id, employee);
                }
                return employee;
            }
        }

        public static async Task<IEnumerable<Employee>> SearchEmployeeAsync(string keyword)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var process = new SearchEmployee(keyword);
                return await process.ExecuteAsync();
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeeLogin> GetEmployeeLoginByCode(uint loginCode)
        {
            var process = new GetEmployeeLoginByCode(loginCode);
            return await process.ExecuteAsync();
        }

        public static async Task<TimeLog> LogEmployeeAsync(EmployeeLogin loginInfo)
        {
            if (loginInfo != null)
            {
                var process = new LogEmployee(loginInfo);
                return await process.ExecuteAsync();
            }
            else
            {
                return null;
            }
        }

        public static async Task<EmployeeLogin> RegisterEmployeeLoginAsync(Employee employee)
        {
            if (employee != null)
            {
                var process = new RegisterEmployeeLogin(employee);
                return await process.ExecuteAsync();
            }
            else
            {
                return null;
            }
        }
    }
}
