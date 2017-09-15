using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetProjectListWithScheduledProjectDesignByClient : DataProcessBase
    {
        public GetProjectListWithScheduledProjectDesignByClient(Client client, DateTime scheduledDate, ScheduledProjectDesignStatus status)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            ScheduledDate = scheduledDate;
            Status = status ?? throw new ArgumentNullException(nameof(status));
        }

        private DateTime ScheduledDate;
        private ScheduledProjectDesignStatus Status;
        private Client Client;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetProjectListWithScheduledProjectDesignByClient", connection);
            command.Parameters.AddWithValue("@_ClientId", Client.Id);
            command.Parameters.AddWithValue("@_ScheduledDate", ScheduledDate);
            command.Parameters.AddWithValue("@_Status", Status.Value);

            return command;
        }

        public Task<IEnumerable<Project>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand(connection), FromReder);
        }

        public Task<IEnumerable<Project>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }

        private Project FromReder(DbDataReader reader)
        {
            return new Project()
            {
                Client = Client,
                Id = reader.GetUInt64("Id"),
                Name = reader.GetString("Name")
            };
        }
    }
}
