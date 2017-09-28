using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCementSuppliedProjectListByClient : DataProcessBase
    {
        public GetCementSuppliedProjectListByClient(Client client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private Client Client;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetCementSuppliedProjectListByClient", connection);
            command.Parameters.AddWithValue("@_ClientId", Client.Id);

            return command;
        }

        private Project FromReader(DbDataReader reader)
        {
            return new Project()
            {
                Id = reader.GetUInt64("Id"),
                Client = Client,
                Name = reader.GetString("Name")
            };
        }

        public Task<IEnumerable<Project>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        public Task<IEnumerable<Project>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
