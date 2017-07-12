using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertScheduledProjectDesign : DataProcessBase
    {
        public InsertScheduledProjectDesign(ScheduledProjectDesign scheduledDesign)
        {
            ScheduledDesign = scheduledDesign ?? throw new ArgumentNullException(nameof(scheduledDesign));
        }

        private ScheduledProjectDesign ScheduledDesign;

        public override void Dispose()
        {
            ScheduledDesign = null;
            base.Dispose();
        }

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertScheduledProjectDesign", connection, transaction);
            command.Parameters.AddWithValue("@_ProjectDesignId", ScheduledDesign.Design.Id);
            command.Parameters.AddWithValue("@_ScheduledDate", ScheduledDesign.ScheduledDate);
            command.Parameters.AddWithValue("@_UseRangeDate", ScheduledDesign.UseRangeDate);
            command.Parameters.AddWithValue("@_RangeEnd", ScheduledDesign.RangeEnd);
            command.Parameters.AddWithValue("@_StructureTypeId", ScheduledDesign.StructureType?.Id);

            return command;
        }

        public async Task<ScheduledProjectDesign> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    ScheduledDesign = null;
                }

                return ScheduledDesign;
            }
        }

        public Task<ScheduledProjectDesign> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
