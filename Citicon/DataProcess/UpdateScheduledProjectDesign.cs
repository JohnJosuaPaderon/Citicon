using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateScheduledProjectDesign : DataProcessBase
    {
        public UpdateScheduledProjectDesign(ScheduledProjectDesign scheduledProjectDesign)
        {
            ScheduledProjectDesign = scheduledProjectDesign ?? throw new ArgumentNullException(nameof(scheduledProjectDesign));
        }

        private ScheduledProjectDesign ScheduledProjectDesign { get; set; }

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateScheduledProjectDesign", connection, transaction);
            command.Parameters.AddWithValue("@_ProjectDesignId", ScheduledProjectDesign.Design?.Id);
            command.Parameters.AddWithValue("@_ScheduledDate", ScheduledProjectDesign.ScheduledDate);
            command.Parameters.AddWithValue("@_Status", ScheduledProjectDesign.Status?.Value);

            return command;
        }

        public async Task<ScheduledProjectDesign> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 0)
                {
                    ScheduledProjectDesign = null;
                }

                return ScheduledProjectDesign;
            }
        }

        public Task<ScheduledProjectDesign> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
