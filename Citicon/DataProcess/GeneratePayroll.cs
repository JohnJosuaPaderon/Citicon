using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GeneratePayroll : DataProcessBase
    {
        public GeneratePayroll(Payroll payroll)
        {
            _Payroll = payroll;
            JobPositionManager = new JobPositionManager();
            PayrollGroupManager = new PayrollGroupManager();
        }

        private readonly Payroll _Payroll;
        private JobPositionManager JobPositionManager;
        private PayrollGroupManager PayrollGroupManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GeneratePayroll", connection);
            command.Parameters.AddWithValue("@_RangeStart", _Payroll.DateRange.Begin);
            command.Parameters.AddWithValue("@_RangeEnd", _Payroll.DateRange.End);
            command.Parameters.AddWithValue("@_BranchId", _Payroll.Branch.Id);

            return command;
        }

        private async Task<EmployeePayroll> FromReaderAsync(DbDataReader reader)
        {
            return new EmployeePayroll(_Payroll)
            {
                Employee = new Employee()
                {
                    Id = reader.GetInt64("Id"),
                    FirstName = reader.GetString("FirstName"),
                    MiddleName = reader.GetString("MiddleName"),
                    LastName = reader.GetString("LastName"),
                    JobPosition = JobPositionManager.GetById(reader.GetInt64("JobPositionId"))
                },
                BasicPay = reader.GetDecimal("BasicPay"),
                Rate = reader.GetDecimal("DailyRate"),
                VacationLeave = reader.GetDecimal("VacationLeave"),
                SickLeave = reader.GetDecimal("SickLeave"),
                RegularWorkingHours = reader.GetDecimal("RegularWorkingHours"),
                Group = await PayrollGroupManager.GetByIdAsync(reader.GetUInt32("PayrollGroupId"))
            };
        }

        public Task<IEnumerable<EmployeePayroll>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReaderAsync);
        }

        public Task<IEnumerable<EmployeePayroll>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
