using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetScheduledProjectDesignListByProject : DataProcessBase
    {
        public GetScheduledProjectDesignListByProject(Project project, DateTime scheduledDate, ScheduledProjectDesignStatus status)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
            ScheduledDate = scheduledDate.Date == default(DateTime).Date ? throw new ArgumentException("Value cannot be equal to 0001/01/01", nameof(scheduledDate)) : scheduledDate.Date;
            Status = status ?? throw new ArgumentNullException(nameof(status));
        }

        private Project Project;
        private DateTime ScheduledDate;
        private ScheduledProjectDesignStatus Status;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetScheduledProjectDesignListByProject", connection);
            command.Parameters.AddWithValue("@_ProjectId", Project.Id);
            command.Parameters.AddWithValue("@_ScheduledDate", ScheduledDate);
            command.Parameters.AddWithValue("@_Status", Status.Value);

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
                ScheduledDate = ScheduledDate,
                Status = Status
            };
        }
    }
}
