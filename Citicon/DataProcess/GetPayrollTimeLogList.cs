using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetPayrollTimeLogList : DataProcessBase
    {
        public GetPayrollTimeLogList(Employee employee, TimeLogType type, DateTimeRange cutOff)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
            _Type = type ?? throw new ArgumentNullException(nameof(type));
            _CutOff = cutOff ?? throw new ArgumentNullException(nameof(cutOff));
        }

        private readonly Employee _Employee;
        private readonly TimeLogType _Type;
        private readonly DateTimeRange _CutOff;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetPayrollTimeLogList), connection)
                .AddInParameter("@_EmployeeId", _Employee.Id)
                .AddInParameter("@_TypeId", _Type.Id)
                .AddInParameter("@_CutOffBegin", _CutOff.Begin)
                .AddInParameter("@_CutOffEnd", _CutOff.End);
        }

        private TimeLog FromReader(DbDataReader reader)
        {
            return new TimeLog
            {
                Id = reader.GetUInt64("Id"),
                Login = reader.GetDateTime("Login"),
                Logout = reader.GetDateTime("Logout")
            };
        }

        public Task<IEnumerable<TimeLog>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }
    }
}
