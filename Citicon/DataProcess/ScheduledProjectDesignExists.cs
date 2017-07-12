using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class ScheduledProjectDesignExists : DataProcessBase
    {
        public ScheduledProjectDesignExists(ScheduledProjectDesign scheduledDesign)
        {
            ScheduledDesign = scheduledDesign ?? throw new ArgumentNullException(nameof(scheduledDesign));
        }

        private ScheduledProjectDesign ScheduledDesign;
        private const string Parameter_ProjectDesignId = "@_ProjectDesignId";
        private const string Parameter_ScheduledDate = "@_ScheduledDate";
        private const string Parameter_UseRangeDate = "@_UseRangeDate";
        private const string Parameter_RangeEnd = "@_RangeEnd";

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                Connection = connection,
                CommandText = string.Format("SELECT ScheduledProjectDesignExists({0}, {1}, {2}, {3});", Parameter_ProjectDesignId, Parameter_ScheduledDate, Parameter_UseRangeDate, Parameter_RangeEnd)
            };
            command.Parameters.AddWithValue(Parameter_ProjectDesignId, ScheduledDesign.Design.Id);
            command.Parameters.AddWithValue(Parameter_ScheduledDate, ScheduledDesign.ScheduledDate);
            command.Parameters.AddWithValue(Parameter_UseRangeDate, ScheduledDesign.UseRangeDate);
            command.Parameters.AddWithValue(Parameter_RangeEnd, ScheduledDesign.RangeEnd);

            return command;
        }

        public override void Dispose()
        {
            ScheduledDesign = null;
            base.Dispose();
        }

        public async Task<bool> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return Convert.ToBoolean(await command.ExecuteScalarAsync());
            }
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
