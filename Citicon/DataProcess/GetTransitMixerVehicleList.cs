using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetTransitMixerVehicleList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetTransitMixerVehicleList", connection);
            return command;
        }

        public Task<IEnumerable<Vehicle>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<Vehicle> FromReaderAsync(DbDataReader reader)
        {
            return new Vehicle
            {
                Id = reader.GetUInt64("Id"),
                PhysicalNumber = reader.GetString("PhysicalNumber"),
                PlateNumber = reader.GetString("PlateNumber"),
                Type = await VehicleTypeManager.GetVehicleTypeByIdAsync(reader.GetUInt64("TypeId"))
            };
        }
    }
}
