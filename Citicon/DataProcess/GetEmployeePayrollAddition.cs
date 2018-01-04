using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeePayrollAddition : DataProcessBase
    {
        public GetEmployeePayrollAddition(ulong id)
        {
            _Id = id;
        }

        private readonly ulong _Id;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand("GetEmployeePayrollAddition", connection)
                .AddInParameter("@_Id", _Id);
        }

        public async Task<EmployeePayrollAddition> FromReaderAsync(DbDataReader reader)
        {
            return new EmployeePayrollAddition
            {
                Id = _Id,
                Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
                EffectivityDate = reader.GetDateTime("EffectivityDate"),
                BasicPay = reader.GetDecimal("BasicPay"),
                DailyRate = reader.GetDecimal("DailyRate"),
                Allowance = reader.GetDecimal("Allowance"),
                OvertimeAllowance = reader.GetDecimal("OvertimeAllowance")
            };
        }

        public Task<EmployeePayrollAddition> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReaderAsync);
        }
    }
}
