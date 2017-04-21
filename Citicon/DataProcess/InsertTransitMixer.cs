using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertTransitMixer : DataProcessBase
    {
        public InsertTransitMixer(TransitMixer transitMixer)
        {
            TransitMixer = transitMixer ?? throw new ArgumentNullException(nameof(transitMixer));
        }

        private TransitMixer TransitMixer;
        private const string Parameter_Id = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertTransitMixer", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
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
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    TransitMixer.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                }
                else
                {
                    TransitMixer = null;
                }

                return TransitMixer;
            }
        }
    }
}
