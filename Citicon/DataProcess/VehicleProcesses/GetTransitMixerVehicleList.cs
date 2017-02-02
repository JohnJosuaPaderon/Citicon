using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetTransitMixerVehicleList : IDisposable
    {
        private MySqlConnectionHelper ConnectionHelper;

        public GetTransitMixerVehicleList()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Vehicle>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetTransitMixerVehicleList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<Vehicle> vehicles = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                vehicles = new List<Vehicle>();
                                while (await reader.ReadAsync())
                                {
                                    vehicles.Add(new Vehicle
                                    {
                                        Id = reader.GetUInt64("Id"),
                                        PhysicalNumber = reader.GetString("PhysicalNumber"),
                                        PlateNumber = reader.GetString("PlateNumber"),
                                        Type = await VehicleTypeManager.GetVehicleTypeByIdAsync(reader.GetUInt64("TypeId"))
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        vehicles = null;
                        throw;
                    }
                    return vehicles;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
