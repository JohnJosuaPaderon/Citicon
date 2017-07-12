using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetScheduledProjectDesignListByStatus : DataProcessBase
    {
        public GetScheduledProjectDesignListByStatus(ScheduledProjectDesignStatus status)
        {
            Status = status ?? throw new ArgumentNullException(nameof(status));
        }

        private ScheduledProjectDesignStatus Status { get; set; }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetScheduledProjectDesignListByStatus", connection);
            command.Parameters.AddWithValue("@_Status", Status.Value);

            return command;
        }

        private async Task<ScheduledProjectDesign> FromReaderAsync(DbDataReader reader)
        {
            return new ScheduledProjectDesign()
            {
                 Design = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                 ScheduledDate = reader.GetDateTime("ScheduledDate"),
                 Status = Status,
                 RangeEnd = reader.GetDateTime("RangeEnd"),
                 UseRangeDate = reader.GetBoolean("UseRangeDate")
            };
        }

        public Task<IEnumerable<ScheduledProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
