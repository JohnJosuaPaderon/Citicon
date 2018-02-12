using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeeListWithTimeLog : DataProcessBase
    {
        public GetEmployeeListWithTimeLog(bool filterByBranch, Branch branch, bool filterByEmployeePosition, JobPosition employeePosition, bool filterByPayrollType, PayrollType payrollType, DateTimeRange timeRange)
        {
            FilterByBranch = filterByBranch;
            Branch = branch;
            FilterByEmployeePosition = filterByEmployeePosition;
            EmployeePosition = employeePosition;
            FilterByPayrollType = filterByPayrollType;
            PayrollType = payrollType;
            TimeRange = timeRange ?? throw new ArgumentNullException(nameof(timeRange));
            PositionManager = new JobPositionManager();
        }

        private JobPositionManager PositionManager;
        private bool FilterByBranch;
        private bool FilterByEmployeePosition;
        private bool FilterByPayrollType;
        private Branch Branch;
        private JobPosition EmployeePosition;
        private DateTimeRange TimeRange;
        private PayrollType PayrollType;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetEmployeeListWithTimeLog", connection);
            command.Parameters.AddWithValue("@_FilterByBranch", FilterByBranch);
            command.Parameters.AddWithValue("@_BranchId", Branch?.Id);
            command.Parameters.AddWithValue("@_FilterByEmployeePosition", FilterByEmployeePosition);
            command.Parameters.AddWithValue("@_EmployeePositionId", EmployeePosition?.Id);
            command.Parameters.AddWithValue("@_FilterByPayrollType", FilterByPayrollType);
            command.Parameters.AddWithValue("@_PayrollTypeId", PayrollType.Id);
            command.Parameters.AddWithValue("@_TimeRangeStart", TimeRange.Begin);
            command.Parameters.AddWithValue("@_TimeRangeEnd", TimeRange.End);

            return command;
        }

        public override void Dispose()
        {
            PositionManager = null;
            Branch = null;
            TimeRange = null;
            base.Dispose();
        }

        public Task<IEnumerable<Employee>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private Employee FromReader(DbDataReader reader)
        {
            return new Employee()
            {
                Id = reader.GetInt64("Id"),
                FirstName = reader.GetString("FirstName"),
                MiddleName = reader.GetString("MiddleName"),
                LastName = reader.GetString("LastName"),
                Position = JobPositionManager.GetById(reader.GetInt64("PositionId"))
            };
        }
    }
}
