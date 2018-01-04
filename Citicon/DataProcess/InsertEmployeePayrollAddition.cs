using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertEmployeePayrollAddition : DataProcessBase
    {
        public InsertEmployeePayrollAddition(EmployeePayrollAddition employeePayrollAddition)
        {
            _EmployeePayrollAddition = employeePayrollAddition;
        }

        private readonly EmployeePayrollAddition _EmployeePayrollAddition;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("InsertEmployeePayrollAddition", connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_EmployeeId", _EmployeePayrollAddition.Employee?.Id)
                .AddInParameter("@_EffectivityDate", _EmployeePayrollAddition.EffectivityDate)
                .AddInParameter("@_BasicPay", _EmployeePayrollAddition.BasicPay)
                .AddInParameter("@_DailyRate", _EmployeePayrollAddition.DailyRate)
                .AddInParameter("@_Allowance", _EmployeePayrollAddition.Allowance)
                .AddInParameter("@_OvertimeAllowance", _EmployeePayrollAddition.OvertimeAllowance);
        }

        public async Task<EmployeePayrollAddition> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                _EmployeePayrollAddition.Id = command.Parameters.GetUInt64("@_Id");
                return _EmployeePayrollAddition;
            }
        }

        public Task<EmployeePayrollAddition> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
