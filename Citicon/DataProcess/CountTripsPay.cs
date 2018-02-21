using Citicon.Data;
using Citicon.Extensions;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class CountTripsPay : DataProcessBase
    {
        public CountTripsPay(Employee employee, DateTimeRange cutOff)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
            _CutOff = cutOff ?? throw new ArgumentNullException(nameof(cutOff));
        }

        private readonly Employee _Employee;
        private readonly DateTimeRange _CutOff;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(CountTripsPay), connection)
                .AddInParameter("@_EmployeeId", _Employee.Id)
                .AddInParameter("@_CutOffBegin", _CutOff.Begin)
                .AddInParameter("@_CutOffEnd", _CutOff.End);
        }

        public Task<decimal> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, DbValueConverter.ToDecimal);
        }
    }
}
