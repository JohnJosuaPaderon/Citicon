using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetTransitMixerById : DataProcessBase
    {
        public GetTransitMixerById(ulong transitMixerId)
        {
            TransitMixerId = transitMixerId > 0 ? transitMixerId : throw new ArgumentException("Value cannot be zero.", nameof(transitMixerId));
        }

        private ulong TransitMixerId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetTransitMixerById", connection);
            command.Parameters.AddWithValue("@_Id", TransitMixerId);

            return command;
        }

        public Task<TransitMixer> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<TransitMixer> FromReaderAsync(DbDataReader reader)
        {
            return new TransitMixer()
            {
                Id = TransitMixerId,
                DefaultDriver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DefaultDriverId")),
                PhysicalNumber = reader.GetString("PhysicalNumber"),
                PlateNumber = reader.GetString("PlateNumber"),
                Type = VehicleType.TransitMixer,
                VolumeCapacity =reader.GetDouble("VolumeCapacity")
            };
        }
    }
}
