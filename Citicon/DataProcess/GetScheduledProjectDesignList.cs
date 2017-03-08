using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetScheduledProjectDesignList : DataProcess
    {
        public GetScheduledProjectDesignList(DateTime scheduledDate)
        {
            if (scheduledDate.Date == default(DateTime).Date)
            {
                throw new ArgumentException("Value cannot be equal to 0001/01/01", nameof(scheduledDate));
            }

            ScheduledDate = scheduledDate.Date;
        }

        private DateTime ScheduledDate;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetScheduledProjectDesignList", connection);
            command.Parameters.AddWithValue("@_ScheduledDate", ScheduledDate);

            return command;
        }

        public Task<IEnumerable<ScheduledProjectDesign>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReaderAsync);
        }

        public Task<IEnumerable<ScheduledProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private async Task<ScheduledProjectDesign> FromReaderAsync(DbDataReader reader)
        {
            return new ScheduledProjectDesign()
            {
                Design = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("DesignId")),
                ScheduledDate = ScheduledDate
            };
        }
    }
}
