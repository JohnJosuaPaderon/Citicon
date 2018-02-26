using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveDriverPayrollEmployee : DataProcessBase
    {
        public SaveDriverPayrollEmployee(DriverPayrollEmployee payrollEmployee)
        {
            _PayrollEmployee = payrollEmployee ?? throw new ArgumentNullException(nameof(payrollEmployee));
        }

        private readonly DriverPayrollEmployee _PayrollEmployee;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(SaveDriverPayrollEmployee), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_PayrollId", _PayrollEmployee.Payroll?.Id)
                .AddInParameter("@_EmployeeId", _PayrollEmployee.Employee?.Id)
                .AddInParameter("@_VacationLeave", _PayrollEmployee.VacationLeave)
                .AddInParameter("@_SickLeave", _PayrollEmployee.SickLeave)
                .AddInParameter("@_WithholdingTax", _PayrollEmployee.WithholdingTax)
                .AddInParameter("@_Sss", _PayrollEmployee.Sss)
                .AddInParameter("@_SssEr", _PayrollEmployee.SssEr)
                .AddInParameter("@_SssEc", _PayrollEmployee.SssEc)
                .AddInParameter("@_Pagibig", _PayrollEmployee.Pagibig)
                .AddInParameter("@_PhilHealth", _PayrollEmployee.PhilHealth)
                .AddInParameter("@_CashAdvance", _PayrollEmployee.CashAdvance)
                .AddInParameter("@_SunCellBill", _PayrollEmployee.SunCellBill)
                .AddInParameter("@_GrossPay", _PayrollEmployee.GrossPay)
                .AddInParameter("@_TotalDeduction", _PayrollEmployee.TotalDeduction)
                .AddInParameter("@_NetPay", _PayrollEmployee.NetPay)
                .AddInParameter("@_Others", _PayrollEmployee.Others)
                .AddInParameter("@_ShopRate", _PayrollEmployee.ShopRate)
                .AddInParameter("@_ShopRatePay", _PayrollEmployee.Holidays)
                .AddInParameter("@_Holidays", _PayrollEmployee.Holidays)
                .AddInParameter("@_WorkDays", _PayrollEmployee.WorkDays)
                .AddInParameter("@_TripsPay", _PayrollEmployee.TripsPay);
        }

        private DriverPayrollEmployee Callback(int affectedRows, MySqlCommand command)
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

        public Task<DriverPayrollEmployee> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            return ProcessUtility.HandleExecuteAsync(connection, transaction, CreateCommand, Callback);
        }
    }
}
