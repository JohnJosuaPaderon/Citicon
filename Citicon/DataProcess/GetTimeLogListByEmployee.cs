using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetTimeLogListByEmployee : DataProcessBase
    {
        public GetTimeLogListByEmployee(Employee employee, DateTimeRange timeRange)
        {
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
            TimeRange = timeRange ?? throw new ArgumentNullException(nameof(timeRange));
            TypeManager = new TimeLogTypeManager();
        }

        private Employee Employee;
        private TimeLogTypeManager TypeManager;
        private DateTimeRange TimeRange;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetTimeLogListByEmployee", connection);
            command.Parameters.AddWithValue("@_EmployeeId", Employee.Id);
            command.Parameters.AddWithValue("@_TimeRangeStart", TimeRange.Start);
            command.Parameters.AddWithValue("@_TimeRangeEnd", TimeRange.End);

            return command;
        }

        public override void Dispose()
        {
            Employee = null;
            base.Dispose();
        }

        public Task<IEnumerable<TimeLog>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<TimeLog> FromReaderAsync(DbDataReader reader)
        {
            return new TimeLog()
            {
                Id = reader.GetUInt64("Id"),
                EmployeeLogin = await EmployeeManager.GetEmployeeLoginByIdAsync(reader.GetUInt64("EmployeeLoginId")),
                Login = reader.GetNullableDateTime("Login"),
                Logout = reader.GetNullableDateTime("Logout"),
                Type = await TypeManager.GetByIdAsync(reader.GetUInt64("TypeId"))
            };
        }
    }
}
