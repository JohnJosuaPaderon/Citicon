using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCurrentEmployeePayrollAdditionByEmployee : DataProcessBase
    {
        public GetCurrentEmployeePayrollAdditionByEmployee(Employee employee)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private readonly Employee _Employee;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand("GetCurrentEmployeePayrollAdditionByEmployee", connection)
                .AddInParameter("@_EmployeeId", _Employee?.Id);
        }

        private EmployeePayrollAddition FromReader(DbDataReader reader)
        {
            return new EmployeePayrollAddition
            {
                Id = reader.GetUInt64("Id"),
                Employee = _Employee,
                EffectivityDate = reader.GetDateTime("EffectivityDate"),
                BasicPay = reader.GetDecimal("BasicPay"),
                DailyRate = reader.GetDecimal("DailyRate"),
                Allowance = reader.GetDecimal("Allowance"),
                OvertimeAllowance = reader.GetDecimal("OvertimeAllowance")
            };
        }

        public Task<EmployeePayrollAddition> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
