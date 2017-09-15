using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetClientListWithScheduledProjectDesign : DataProcessBase
    {
        public GetClientListWithScheduledProjectDesign(DateTime scheduledDate, ScheduledProjectDesignStatus status)
        {
            ScheduledDate = scheduledDate;
            Status = status;
        }

        private DateTime ScheduledDate;
        private ScheduledProjectDesignStatus Status;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetClientListWithScheduledProjectDesign", connection);
            command.Parameters.AddWithValue("@_ScheduledDate", ScheduledDate);
            command.Parameters.AddWithValue("@_Status", Status.Value);

            return command;
        }

        public Task<IEnumerable<Client>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReader);
        }

        public Task<IEnumerable<Client>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private async Task<Client> FromReader(DbDataReader reader)
        {
            return new Client()
            {
                Id = reader.GetUInt64("Id"),
                Address = reader.GetString("Address"),
                CompanyName = reader.GetString("CompanyName"),
                Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId"))
            };
        }
    }
}
