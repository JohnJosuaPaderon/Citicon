using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GeneratePayroll : DataProcess
    {
        public GeneratePayroll(DateTimeRange rangeDate, Branch branch)
        {
            RangeDate = rangeDate;
            Branch = branch;
            JobPositionManager = new JobPositionManager();
        }

        private DateTimeRange RangeDate;
        private Branch Branch;
        private JobPositionManager JobPositionManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GeneratePayroll", connection);
            command.Parameters.AddWithValue("@_RangeStart", RangeDate.Start);
            command.Parameters.AddWithValue("@_RangeEnd", RangeDate.End);
            command.Parameters.AddWithValue("@_BranchId", Branch.Id);

            return command;
        }

        private EmployeePayroll FromReader(DbDataReader reader)
        {
            return new EmployeePayroll()
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
                DailyRate = reader.GetDecimal("DailyRate"),
                VacationLeave = reader.GetDecimal("VacationLeave"),
                SickLeave = reader.GetDecimal("SickLeave"),
                RegularWorkingHours = reader.GetDecimal("RegularWorkingHours"),
                NightDifferentialHours = reader.GetDecimal("NightDifferentialHours"),
                SundayHours = reader.GetDecimal("SundayHours"),
                SpecialHolidayHours = reader.GetDecimal("SpecialHolidayHours"),
                SpecialHolidayOvertimeHours = reader.GetDecimal("SpecialHolidayOvertimeHours"),
                WithHoldingTax = reader.GetDecimal("WithHoldingTax"),
                SSSEC = reader.GetDecimal("SSSEC"),
                SSSER = reader.GetDecimal("SSSER")
            };
        }

        public Task<IEnumerable<EmployeePayroll>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReader);
        }

        public Task<IEnumerable<EmployeePayroll>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
