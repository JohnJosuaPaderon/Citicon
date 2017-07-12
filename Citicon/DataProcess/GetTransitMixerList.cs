using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetTransitMixerList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetTransitMixerList", connection);
            return command;
        }

        public Task<IEnumerable<TransitMixer>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<TransitMixer> FromReaderAsync(DbDataReader reader)
        {
            return new TransitMixer()
            {
                Id = reader.GetUInt64("Id"),
                PhysicalNumber = reader.GetString("PhysicalNumber"),
                PlateNumber = reader.GetString("PlateNumber"),
                Type = VehicleType.TransitMixer,
                VolumeCapacity = reader.GetDouble("VolumeCapacity"),
                DefaultDriver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DefaultDriverId")),
                Additionals = reader.GetDecimal("Additionals")
            };
        }
    }
}
