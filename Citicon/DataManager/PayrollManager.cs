using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static async Task<IEnumerable<WeeklyPayrollEmployee>> GenerateWeeklyPayrollEmployeeListAsync(WeeklyPayroll payroll)
        {
            if (payroll != null)
            {
                using (var process = new GenerateWeeklyPayrollEmployeeList(payroll))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<DriverPayrollEmployee>> GenerateDriverPayrollEmployeeListAsync(DriverPayroll payroll)
        {
            if (payroll != null)
            {
                using (var process = new GenerateDriverPayrollEmployeeList(payroll))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task SaveSemiMonthlyAsync(SemiMonthlyPayroll semiMonthlyPayroll, IEnumerable<SemiMonthlyPayrollEmployee> payrollEmployees)
        {
            if (semiMonthlyPayroll != null && payrollEmployees != null && payrollEmployees.Any())
            {
                using (var process = new SaveSemiMonthlyPayroll(semiMonthlyPayroll, payrollEmployees))
                {
                    await process.ExecuteAsync();
                }
            }
            else
            {
                throw new Exception("No employees.");
            }
        }

        public static async Task SaveWeeklyAsync(WeeklyPayroll payroll, IEnumerable<WeeklyPayrollEmployee> payrollEmployees)
        {
            if (payroll != null && payrollEmployees != null && payrollEmployees.Any())
            {
                using (var process = new SaveWeeklyPayroll(payroll, payrollEmployees))
                {
                    await process.ExecuteAsync();
                }
            }
            else
            {
                throw new Exception("No employees.");
            }
        }

        public static async Task SaveDriverPayrollAsync(DriverPayroll payroll, IEnumerable<DriverPayrollEmployee> payrollEmployees)
        {
            if (payroll != null && payrollEmployees != null && payrollEmployees.Any())
            {
                using (var process = new SaveDriverPayroll(payroll, payrollEmployees))
                {
                    await process.ExecuteAsync();
                }
            }
            else
            {
                throw new Exception("No employees.");
            }
        }

        public static async Task<SemiMonthlyPayrollEmployee> SaveSemiMonthlyPayrollEmployeeAsync(SemiMonthlyPayrollEmployee payrollEmployee, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (payrollEmployee != null)
            {
                using (var process = new SaveSemiMonthlyPayrollEmployee(payrollEmployee))
                {
                    return await process.ExecuteAsync(connection, transaction);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<WeeklyPayrollEmployee> SaveWeeklyPayrollEmployeeAsync(WeeklyPayrollEmployee payrollEmployee, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (payrollEmployee != null)
            {
                using (var process = new SaveWeeklyPayrollEmployee(payrollEmployee))
                {
                    return await process.ExecuteAsync(connection, transaction);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<DriverPayrollEmployee> SaveDriverPayrollEmployeeAsync(DriverPayrollEmployee payrollEmployee, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (payrollEmployee != null)
            {
                using (var process = new SaveDriverPayrollEmployee(payrollEmployee))
                {
                    return await process.ExecuteAsync(connection, transaction);
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<TimeLog>> GetTimeLogListAsync(Employee employee, TimeLogType type, DateTimeRange cutOff)
        {
            if (employee != null && type != null && cutOff != null)
            {
                using (var process = new GetPayrollTimeLogList(employee, type, cutOff))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> ExistsAsync(PayrollBase payroll)
        {
            if (payroll != null)
            {
                using (var process = new PayrollExists(payroll))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return default(bool);
            }
        }

        public static async Task ExportSemiMonthlyAsync(SemiMonthlyPayroll payroll, IEnumerable<SemiMonthlyPayrollEmployee> payrollEmployees)
        {
            if (payroll != null && payrollEmployees != null && payrollEmployees.Any())
            {
                using (var process = new ExportSemiMonthlyPayroll(payroll, payrollEmployees))
                {
                    await process.ExecuteAsync();
                }
            }
        }

        public static async Task ExportWeeklyAsync(WeeklyPayroll payroll, IEnumerable<WeeklyPayrollEmployee> payrollEmployees)
        {
            if (payroll != null && payrollEmployees != null && payrollEmployees.Any())
            {
                using (var process = new ExportWeeklyPayroll(payroll, payrollEmployees))
                {
                    await process.ExecuteAsync();
                }
            }
        }
    }
}
