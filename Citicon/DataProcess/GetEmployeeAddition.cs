using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeeAddition : DataProcessBase
    {
        public GetEmployeeAddition(Employee employee)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private readonly Employee _Employee;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetEmployeeAddition), connection)
                .AddInParameter("@_EmployeeId", _Employee.Id);
        }

        private EmployeeAddition FromReader(DbDataReader reader)
        {
            return new EmployeeAddition(_Employee)
            {
                Id = reader.GetUInt64("Id"),
                DailyRate = reader.GetDecimal("DailyRate"),
                BasicPay = reader.GetDecimal("BasicPay"),
                Allowance = reader.GetDecimal("Allowance"),
                OvertimeAllowance = reader.GetDecimal("OvertimeAllowance"),
                ShopRate = reader.GetDecimal("ShopRate")
            };
        }

        public Task<EmployeeAddition> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
