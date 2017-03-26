using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetVehicleById : DataProcessBase
    {
        private ulong VehicleId;

        public GetVehicleById(ulong vehicleId)
        {
            VehicleId = vehicleId;
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetVehicleById", connection);
            command.Parameters.AddWithValue("@_VehicleId", VehicleId);

            return command;
        }

        public Task<Vehicle> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<Vehicle> FromReaderAsync(DbDataReader reader)
        {
            return new Vehicle
            {
                Id = VehicleId,
                PhysicalNumber = reader.GetString("PhysicalNumber"),
                PlateNumber = reader.GetString("PlateNumber"),
                Type = await VehicleTypeManager.GetVehicleTypeByIdAsync(reader.GetUInt64("TypeId"))
            };
        }
    }
}
