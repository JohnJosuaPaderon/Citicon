using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class ScheduledProjectDesignExists : DataProcess
    {
        public ScheduledProjectDesignExists(ScheduledProjectDesign scheduledDesign)
        {
            if (scheduledDesign == null)
            {
                throw new ArgumentNullException(nameof(scheduledDesign));
            }

            ScheduledDesign = scheduledDesign;
        }

        private ScheduledProjectDesign ScheduledDesign;
        private const string Parameter_ProjectDesignId = "@_ProjectDesignId";
        private const string Parameter_ScheduledDate = "@_ScheduledDate";

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = string.Format("SELECT ScheduledProjectDesignExists({0}, {1});", Parameter_ProjectDesignId, Parameter_ScheduledDate);
            command.Parameters.AddWithValue(Parameter_ProjectDesignId, ScheduledDesign.Design.Id);
            command.Parameters.AddWithValue(Parameter_ScheduledDate, ScheduledDesign.ScheduledDate);

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
