using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteTransitMixer : DataProcessBase
    {
        public DeleteTransitMixer(TransitMixer transitMixer)
        {
            TransitMixer = transitMixer ?? throw new ArgumentNullException(nameof(transitMixer));
        }

        private TransitMixer TransitMixer;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteTransitMixer", connection, transaction);
            command.Parameters.AddWithValue("@_Id", TransitMixer.Id);

            return command;
        }

        public override void Dispose()
        {
            TransitMixer = null;
            base.Dispose();
        }

        public async Task<TransitMixer> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    TransitMixer = null;
                }

                return TransitMixer;
            }
        }

        public Task<TransitMixer> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
