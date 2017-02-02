using Citicon.Data;
using Citicon.DataProcess;
using Citicon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
