using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteScheduledProjectDesign : DataProcessBase
    {
        public DeleteScheduledProjectDesign(ScheduledProjectDesign scheduledProjectDesign)
        {
            ScheduledProjectDesign = scheduledProjectDesign ?? throw new ArgumentNullException(nameof(scheduledProjectDesign));
        }

        private ScheduledProjectDesign ScheduledProjectDesign { get; set; }

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteScheduledProjectDesign", connection, transaction);
            command.Parameters.AddWithValue("@_ProjectDesignId", ScheduledProjectDesign.Design?.Id);
            command.Parameters.AddWithValue("@_ScheduledDate", ScheduledProjectDesign.ScheduledDate);

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
