using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteClient : DataProcessBase
    {
        public DeleteClient(Client client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private Client Client;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteClient", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Client.Id);

            return command;
        }

        public override void Dispose()
        {
            Client = null;
            base.Dispose();
        }

        public async Task<Client> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    Client = null;
                }

                return Client;
            }
        }

        public Task<Client> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
