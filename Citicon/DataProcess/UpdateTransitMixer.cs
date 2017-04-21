using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateTransitMixer : DataProcessBase
    {
        public UpdateTransitMixer(TransitMixer transitMixer)
        {
            TransitMixer = transitMixer ?? throw new ArgumentNullException(nameof(transitMixer));
        }

        private TransitMixer TransitMixer;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertTransitMixer", connection, transaction);
            command.Parameters.AddWithValue("@_Id", TransitMixer.Id);
            command.Parameters.AddWithValue("@_PhysicalNumber", TransitMixer.PhysicalNumber);
            command.Parameters.AddWithValue("@_PlateNumber", TransitMixer.PlateNumber);
            command.Parameters.AddWithValue("@_VolumeCapacity", TransitMixer.VolumeCapacity);
            command.Parameters.AddWithValue("@_DefaultDriverId", TransitMixer.DefaultDriver?.Id);

            return command;
        }

        public override void Dispose()
        {
            TransitMixer = null;
            base.Dispose();
        }

        public Task<TransitMixer> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
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
    }
}
