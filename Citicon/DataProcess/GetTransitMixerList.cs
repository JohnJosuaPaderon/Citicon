using Citicon.Data;
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
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private TransitMixer FromReader(DbDataReader reader)
        {
            return new TransitMixer()
            {
                Id = reader.GetUInt64("Id"),
                PhysicalNumber = reader.GetString("PhysicalNumber"),
                PlateNumber = reader.GetString("PlateNumber"),
                Type = VehicleType.TransitMixer,
                VolumeCapacity = reader.GetDouble("VolumeCapacity")
            };
        }
    }
}
