using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveSemiMonthlyPayrollEmployee : DataProcessBase
    {
        public SaveSemiMonthlyPayrollEmployee(SemiMonthlyPayrollEmployee payrollEmployee)
        {
            _PayrollEmployee = payrollEmployee ?? throw new ArgumentNullException(nameof(payrollEmployee));
        }

        private readonly SemiMonthlyPayrollEmployee _PayrollEmployee;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(SaveSemiMonthlyPayrollEmployee), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_PayrollId", _PayrollEmployee.Payroll?.Id)
                .AddInParameter("@_EmployeeId", _PayrollEmployee.Employee?.Id)
                .AddInParameter("@_VacationLeave", _PayrollEmployee.VacationLeave)
                .AddInParameter("@_SickLeave", _PayrollEmployee.SickLeave)
                .AddInParameter("@_DailyRate", _PayrollEmployee.DailyRate)
                .AddInParameter("@_BasicPay", _PayrollEmployee.BasicPay)
                .AddInParameter("@_Allowance", _PayrollEmployee.Allowance)
                .AddInParameter("@_OvertimeAllowance", _PayrollEmployee.OvertimeAllowance)
                .AddInParameter("@_WithholdingTax", _PayrollEmployee.WithholdingTax)
                .AddInParameter("@_Sss", _PayrollEmployee.Sss)
                .AddInParameter("@_SssEr", _PayrollEmployee.SssEr)
                .AddInParameter("@_SssEc", _PayrollEmployee.SssEc)
                .AddInParameter("@_Pagibig", _PayrollEmployee.Pagibig)
                .AddInParameter("@_PhilHealth", _PayrollEmployee.PhilHealth)
                .AddInParameter("@_CashAdvance", _PayrollEmployee.CashAdvance)
                .AddInParameter("@_SunCellBill", _PayrollEmployee.SunCellBill)
                .AddInParameter("@_RegularWorkingHours", _PayrollEmployee.RegularWorkingHours)
                .AddInParameter("@_RegularOvertimeWorkingHours", _PayrollEmployee.RegularOvertimeWorkingHours)
                .AddInParameter("@_SundayWorkingHours", _PayrollEmployee.SundayWorkingHours)
                .AddInParameter("@_SpecialHolidayWorkingHours", _PayrollEmployee.SpecialHolidayWorkingHours)
                .AddInParameter("@_SpecialHolidayOvertimeWorkingHours", _PayrollEmployee.SpecialHolidayOvertimeWorkingHours)
                .AddInParameter("@_NightDifferentialWorkingHours", _PayrollEmployee.NightDifferentialWorkingHours)
                .AddInParameter("@_RegularOvertimePay", _PayrollEmployee.RegularOvertimePay)
                .AddInParameter("@_SundayPay", _PayrollEmployee.SundayPay)
                .AddInParameter("@_SpecialHolidayPay", _PayrollEmployee.SpecialHolidayPay)
                .AddInParameter("@_SpecialHolidayOvertimePay", _PayrollEmployee.SpecialHolidayOvertimePay)
                .AddInParameter("@_GrossPay", _PayrollEmployee.GrossPay)
                .AddInParameter("@_TotalDeduction", _PayrollEmployee.TotalDeduction)
                .AddInParameter("@_NetPay", _PayrollEmployee.NetPay);
        }

        private SemiMonthlyPayrollEmployee Callback(int affectedRows, MySqlCommand command)
        {
            if (affectedRows > 0)
            {
                _PayrollEmployee.Id = command.Parameters.GetUInt64("@_Id");
                return _PayrollEmployee;
            }
            else
            {
                return null;
            }
        }

        public Task<SemiMonthlyPayrollEmployee> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            return ProcessUtility.HandleExecuteAsync(connection, transaction, CreateCommand, Callback);
        }
    }
}
