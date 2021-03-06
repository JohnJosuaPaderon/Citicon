﻿using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class EmployeeManager
    {
        static EmployeeManager()
        {
            Employees = new Dictionary<long, Employee>();
            EmployeeLogins = new Dictionary<ulong, EmployeeLogin>();
        }

        private static Dictionary<long, Employee> Employees;
        private static Dictionary<ulong, EmployeeLogin> EmployeeLogins;

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

        public static async Task<EmployeeLogin> GetEmployeeLoginAsync(Employee employee)
        {
            if (employee != null)
            {
                using (var process = new GetEmployeeLogin(employee))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<decimal> CountTripsPayAsync(Employee employee, DateTimeRange cutOff)
        {
            if (employee != null && cutOff != null)
            {
                using (var process = new CountTripsPay(employee, cutOff))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return 0;
            }
        }

        public static async Task<EmployeeLogin> GetEmployeeLoginByCode(uint loginCode)
        {
            var process = new GetEmployeeLoginByCode(loginCode);
            return await process.ExecuteAsync();
        }

        public static async Task<EmployeeLogin> GetEmployeeLoginByIdAsync(ulong employeeLoginId)
        {
            if (employeeLoginId > 0)
            {
                if (EmployeeLogins.ContainsKey(employeeLoginId))
                {
                    return EmployeeLogins[employeeLoginId];
                }
                else
                {
                    using (var process = new GetEmployeeLoginById(employeeLoginId))
                    {
                        var employeeLogin = await process.ExecuteAsync();

                        if (employeeLogin != null)
                        {
                            EmployeeLogins.Add(employeeLoginId, employeeLogin);
                        }

                        return employeeLogin;
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public static Task<IEnumerable<Employee>> GetDriverListAsync()
        {
            using (var process = new GetDriverList())
            {
                return process.ExecuteAsync();
            }
        }

        public static Task<IEnumerable<Employee>> GetTripReportDriverListAsync(DateTimeRange range)
        {
            if (range != null)
            {
                using (var process = new GetTripReportDriverList(range))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
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

        public static async Task<IEnumerable<Employee>> GetListByDepartmentAsync(Department department)
        {
            if (department != null)
            {
                using (var process = new GetEmployeeListByDepartment(department))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static Task<IEnumerable<Employee>> GetListWithTimeLogAsync(bool filterByBranch, Branch branch, bool filterByEmployeePosition, JobPosition employeePosition, bool filterByPayrollType, PayrollType payrollType, DateTimeRange timeRange)
        {
            if (timeRange != null)
            {
                using (var process = new GetEmployeeListWithTimeLog(filterByBranch, branch, filterByEmployeePosition, employeePosition, filterByPayrollType, payrollType, timeRange))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static Task<IEnumerable<TimeLog>> GetTimeLogListAsync(Employee employee, DateTimeRange timeRange)
        {
            if (employee != null && timeRange != null)
            {
                using (var process = new GetTimeLogListByEmployee(employee, timeRange))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> ExportTimeLogReportAsync(TimeLogReport data)
        {
            if (data != null)
            {
                using (var process = new ExportTimeLogReport(data))
                {
                    await process.ExecuteAsync();

                    return File.Exists(process.FilePath);
                }
            }
            else
            {
                return false;
            }
        }

        public async static Task<TimeLog> UpdateTimeLogAsync(TimeLog timeLog)
        {
            if (timeLog != null)
            {
                using (var process = new UpdateTimeLog(timeLog))
                {
                    timeLog = await process.ExecuteAsync();
                }
            }

            return timeLog;
        }

        public static async Task<TimeLog> DeleteTimeLogAsync(TimeLog timeLog)
        {
            if (timeLog != null)
            {
                using (var process = new DeleteTimeLog(timeLog))
                {
                    timeLog = await process.ExecuteAsync();
                }
            }

            return timeLog;
        }

        public static async Task<TimeLog> InsertTimeLogAsync(TimeLog timeLog)
        {
            if (timeLog != null)
            {
                using (var process = new InsertTimeLog(timeLog))
                {
                    timeLog = await process.ExecuteAsync();
                }
            }

            return timeLog;
        }

        public static async Task<Employee> InsertAsync(Employee employee)
        {
            if (employee == null) return null;

            using (var process = new InsertEmployee(employee))
            {
                employee = await process.ExecuteAsync();

                if (employee != null && !Employees.ContainsKey(employee.Id))
                {
                    Employees.Add(employee.Id, employee);
                }

                return employee;
            }
        }

        public static async Task<Employee> InsertAsync(Employee employee, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (employee == null) return null;

            using (var process = new InsertEmployee(employee))
            {
                employee = await process.ExecuteAsync(connection, transaction);

                if (employee != null && !Employees.ContainsKey(employee.Id))
                {
                    Employees.Add(employee.Id, employee);
                }

                return employee;
            }
        }

        public static async Task InsertFullDetailsAsync(Employee employee)
        {
            if (employee != null)
            {
                using (var process = new InsertEmployeeFullDetails(employee))
                {
                    await process.ExecuteAsync();
                }
            }
        }

        public static async Task<Employee> UpdateAsync(Employee employee)
        {
            if (employee == null) return null;

            using (var process = new UpdateEmployee(employee))
            {
                employee = await process.ExecuteAsync();

                if (employee != null)
                {
                    if (Employees.ContainsKey(employee.Id))
                    {
                        Employees[employee.Id] = employee;
                    }
                    else
                    {
                        Employees.Add(employee.Id, employee);
                    }
                }

                return employee;
            }
        }

        public static async Task<Employee> UpdateAsync(Employee employee, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (employee == null) return null;

            using (var process = new UpdateEmployee(employee))
            {
                employee = await process.ExecuteAsync(connection, transaction);

                if (employee != null)
                {
                    if (Employees.ContainsKey(employee.Id))
                    {
                        Employees[employee.Id] = employee;
                    }
                    else
                    {
                        Employees.Add(employee.Id, employee);
                    }
                }

                return employee;
            }
        }

        public static async Task UpdateFullDetailsAsync(Employee employee)
        {
            if (employee != null)
            {
                using (var process = new UpdateEmployeeFullDetails(employee))
                {
                    await process.ExecuteAsync();
                }
            }
        }

        public static Task<bool> EmployeeExistsAsync(string firstName, string middleName, string lastName)
        {
            using (var process = new EmployeeExists(firstName, middleName, lastName))
            {
                return process.ExecuteAsync();
            }
        }

        public static Task<IEnumerable<Employee>> GetMinifiedListAsync()
        {
            using (var process = new GetMinifiedEmployeeList())
            {
                return process.ExecuteAsync();
            }
        }

        public static Task<IEnumerable<Employee>> GetServiceEngineerListAsync()
        {
            using (var process = new GetServiceEngineerList())
            {
                return process.ExecuteAsync();
            }
        }
    }
}
