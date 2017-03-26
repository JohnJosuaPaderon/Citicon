using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetVehicleTypeById : DataProcessBase
    {
        private ulong VehicleTypeId;

        public GetVehicleTypeById(ulong vehicleTypeId)
        {
            VehicleTypeId = vehicleTypeId;
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetVehicleTypeById", connection);
            command.Parameters.AddWithValue("@_VehicleTypeId", VehicleTypeId);

            return command;
        }

        private VehicleType FromReader(DbDataReader reader)
        {
            return new VehicleType
            {
                Id = VehicleTypeId,
                Code = reader.GetString("Code"),
                Description = reader.GetString("Description")
            };
        }

        public Task<VehicleType> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
