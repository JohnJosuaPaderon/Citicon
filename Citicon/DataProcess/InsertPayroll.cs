using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertPayroll : DataProcessBase
    {
        public InsertPayroll(Payroll payroll)
        {
            _Payroll = payroll;
        }

        private readonly Payroll _Payroll;

        private MySqlCommand InsertPayrollCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("InsertPayroll", connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_DateRangeBegin", _Payroll.DateRange.Begin)
                .AddInParameter("@_DateRangeEnd", _Payroll.DateRange.End)
                .AddInParameter("@_BranchId", _Payroll.Branch?.Id);
        }

        private MySqlCommand InsertEmployeePayrollCommand(EmployeePayroll employeePayroll, MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("InsertEmployeePayroll", connection, transaction)
                .AddInParameter("@_EmployeeId", employeePayroll.Employee?.Id)
                .AddInParameter("@_PayrollId", employeePayroll.Payroll?.Id)
                .AddInParameter("@_BasicPay", employeePayroll.BasicPay)
                .AddInParameter("@_DailyRate", employeePayroll.DailyRate)
                .AddInParameter("@_VacationLeave", employeePayroll.VacationLeave)
                .AddInParameter("@_SickLeave", employeePayroll.SickLeave)
                .AddInParameter("@_RegularWorkingHours", employeePayroll.RegularWorkingHours)
                .AddInParameter("@_NightDifferentialHours", employeePayroll.NightDifferentialHours)
                .AddInParameter("@_SundayHours", employeePayroll.SundayHours)
                .AddInParameter("@_SpecialHolidayHours", employeePayroll.SpecialHolidayHours)
                .AddInParameter("@_SpecialHolidayOvertimeHours", employeePayroll.SpecialHolidayOvertimeHours)
                .AddInParameter("@_WithholdingTax", employeePayroll.WithholdingTax)
                .AddInParameter("@_SSSER", employeePayroll.SSSER)
                .AddInParameter("@_SSSEC", employeePayroll.SSSEC);
        }

        private async Task<Payroll> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = InsertPayrollCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    _Payroll.Id = command.Parameters.GetUInt64("@_Id");
                    return _Payroll;
                }
                else
                {
                    return null;
                }
            }
        }

        private async Task<bool> ExecuteAsync(EmployeePayroll employeePayroll, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = InsertEmployeePayrollCommand(employeePayroll, connection, transaction))
            {
                return await command.ExecuteNonQueryAsync() == 1;
            }
        }

        public async Task<Payroll> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        await ExecuteAsync(connection, transaction);
                        foreach (var employee in _Payroll.Employees)
                        {
                            await ExecuteAsync(employee, connection, transaction);
                        }
                        transaction.Commit();
                        return _Payroll;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
