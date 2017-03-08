using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetVehicleById : IDisposable
    {
        private ulong VehicleId;
        private MySqlConnectionHelper ConnectionHelper;

        public GetVehicleById(ulong vehicleId)
        {
            VehicleId = vehicleId;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<Vehicle> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetVehicleById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_VehicleId", VehicleId);
                    Vehicle vehicle = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                vehicle = new Vehicle
                                {
                                    Id = VehicleId,
                                    PhysicalNumber = reader.GetString("PhysicalNumber"),
                                    PlateNumber = reader.GetString("PlateNumber"),
                                    Type = await VehicleTypeManager.GetVehicleTypeByIdAsync(reader.GetUInt64("TypeId"))
                                };
                            }
                        }
                    }
                    catch (Exception)
                    {
                        vehicle = null;
                        throw;
                    }
                    return vehicle;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
