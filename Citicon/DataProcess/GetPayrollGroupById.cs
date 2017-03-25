using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetPayrollGroupById : DataProcessBase
    {
        public GetPayrollGroupById(uint payrollGroupId)
        {
            PayrollGroupId = payrollGroupId == 0 ? throw new ArgumentException("Value cannot be zero.", nameof(payrollGroupId)) : payrollGroupId;
        }

        private uint PayrollGroupId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetPayrollGroupById", connection);
            command.Parameters.AddWithValue("@_Id", PayrollGroupId);

            return command;
        }

        private PayrollGroup FromReader(DbDataReader reader)
        {
            return new PayrollGroup()
            {
                Id = PayrollGroupId,
                Description = reader.GetString("Description"),
                SortCode = reader.GetUInt32("SortCode")
            };
        }

        public Task<PayrollGroup> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand(connection), FromReader);
        }

        public Task<PayrollGroup> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
