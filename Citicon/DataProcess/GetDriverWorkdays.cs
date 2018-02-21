using Citicon.Data;
using Citicon.Extensions;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDriverWorkdays : DataProcessBase
    {
        public GetDriverWorkdays(DriverPayrollEmployee payrollEmployee)
        {
            _PayrollEmployee = payrollEmployee ?? throw new ArgumentNullException(nameof(payrollEmployee));
        }

        private readonly DriverPayrollEmployee _PayrollEmployee;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetDriverWorkdays), connection)
                .AddInParameter("@_EmployeeId", _PayrollEmployee.Employee?.Id)
                .AddInParameter("@_CutOffBegin", _PayrollEmployee.Payroll.CutOff.Begin)
                .AddInParameter("@_CutOffEnd", _PayrollEmployee.Payroll.CutOff.End);
        }

        public Task<decimal> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, DbValueConverter.ToDecimal);
        }
    }
}
