using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GenerateWeeklyPayrollEmployeeList : DataProcessBase
    {
        public GenerateWeeklyPayrollEmployeeList(WeeklyPayroll payroll)
        {
            _Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
        }

        private readonly WeeklyPayroll _Payroll;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GenerateWeeklyPayrollEmployeeList), connection)
                .AddInParameter("@_BranchId", _Payroll.Branch?.Id)
                .AddInParameter("@_CutOffBegin", _Payroll.CutOff?.Begin)
                .AddInParameter("@_CutOffEnd", _Payroll.CutOff?.End);
        }

        private async Task<WeeklyPayrollEmployee> FromReaderAsync(DbDataReader reader)
        {
            var employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId"));

            var result = new WeeklyPayrollEmployee(_Payroll, employee)
            {
                Allowance = reader.GetDecimal("Allowance"),
                BasicPay = reader.GetDecimal("BasicPay"),
                CashAdvance = default(decimal),
                DailyRate = reader.GetDecimal("DailyRate"),
                Id = default(ulong),
                OvertimeAllowance = reader.GetDecimal("OvertimeAllowance"),
                Pagibig = reader.GetDecimal("Pagibig"),
                PhilHealth = reader.GetDecimal("PhilHealth"),
                SickLeave = default(decimal),
                Sss = reader.GetDecimal("Sss"),
                SssEc = reader.GetDecimal("SssEc"),
                SssEr = reader.GetDecimal("SssEr"),
                SunCellBill = default(decimal),
                VacationLeave = default(decimal),
                WithholdingTax = reader.GetDecimal("WithholdingTax"),
                Others = default(decimal)
            };
            await result.CountTimeLogHoursAsync();

            return result;
        }

        public Task<IEnumerable<WeeklyPayrollEmployee>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
