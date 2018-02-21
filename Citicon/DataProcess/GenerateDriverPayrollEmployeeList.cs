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
    internal sealed class GenerateDriverPayrollEmployeeList : DataProcessBase
    {
        public GenerateDriverPayrollEmployeeList(DriverPayroll payroll)
        {
            _Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
        }

        private readonly DriverPayroll _Payroll;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GenerateDriverPayrollEmployeeList), connection)
                .AddInParameter("@_BranchId", _Payroll.Branch?.Id)
                .AddInParameter("@_CutOffBegin", _Payroll.CutOff?.Begin)
                .AddInParameter("@_CutOffEnd", _Payroll.CutOff?.End);
        }

        private async Task<DriverPayrollEmployee> FromReaderAsync(DbDataReader reader)
        {
            var employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId"));
            var result = new DriverPayrollEmployee(_Payroll, employee)
            {
                CashAdvance = default(decimal),
                Id = default(ulong),
                OtherDeduction = default(decimal),
                Pagibig = reader.GetDecimal("Pagibig"),
                PhilHealth = reader.GetDecimal("PhilHealth"),
                ShopRate = reader.GetDecimal("ShopRate"),
                SickLeave = default(decimal),
                Sss = reader.GetDecimal("Sss"),
                SssEc = reader.GetDecimal("SssEc"),
                SssEr = reader.GetDecimal("SssEr"),
                SunCellBill = default(decimal),
                VacationLeave = default(decimal),
                WithholdingTax = reader.GetDecimal("WithholdingTax")
            };
            await result.GetCalculatedValuesAsync();
            return result;
        }

        public Task<IEnumerable<DriverPayrollEmployee>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
