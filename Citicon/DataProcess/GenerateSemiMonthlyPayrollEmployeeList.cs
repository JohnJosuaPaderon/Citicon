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
    internal sealed class GenerateSemiMonthlyPayrollEmployeeList : DataProcessBase
    {
        public GenerateSemiMonthlyPayrollEmployeeList(SemiMonthlyPayroll payroll)
        {
            _Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
        }

        private readonly SemiMonthlyPayroll _Payroll;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GenerateSemiMonthlyPayrollEmployeeList), connection)
                .AddInParameter("@_BranchId", _Payroll.Branch?.Id)
                .AddInParameter("@_CutOffBegin", _Payroll.CutOff?.Begin)
                .AddInParameter("@_CutOffEnd", _Payroll.CutOff?.End);
        }

        private async Task<SemiMonthlyPayrollEmployee> FromReaderAsync(DbDataReader reader)
        {
            var employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId"));

            return new SemiMonthlyPayrollEmployee(_Payroll, employee)
            {
                Allowance = reader.GetDecimal("Allowance"),
                BasicPay = reader.GetDecimal("BasicPay"),
                CashAdvance = default(decimal),
                DailyRate = reader.GetDecimal("DailyRate"),
                Id = default(ulong),
                NightDifferentialWorkingHours = reader.GetDecimal("NightDifferentialWorkingHours"),
                OvertimeAllowance = reader.GetDecimal("OvertimeAllowance"),
                Pagibig = reader.GetDecimal("Pagibig"),
                PhilHealth = reader.GetDecimal("PhilHealth"),
                RegularOvertimeWorkingHours = reader.GetDecimal("RegularOvertimeWorkingHours"),
                RegularWorkingHours = reader.GetDecimal("RegularWorkingHours"),
                SickLeave = default(decimal),
                SpecialHolidayOvertimeWorkingHours = reader.GetDecimal("SpecialHolidayOvertimeWorkingHours"),
                SpecialHolidayWorkingHours = reader.GetDecimal("SpecialHolidayWorkingHours"),
                Sss = reader.GetDecimal("Sss"),
                SssEc = reader.GetDecimal("SssEc"),
                SssEr = reader.GetDecimal("SssEr"),
                SunCellBill = default(decimal),
                SundayWorkingHours = reader.GetDecimal("SundayWorkingHours"),
                VacationLeave = default(decimal),
                WithholdingTax = reader.GetDecimal("WithholdingTax")
            };
        }

        public Task<IEnumerable<SemiMonthlyPayrollEmployee>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
