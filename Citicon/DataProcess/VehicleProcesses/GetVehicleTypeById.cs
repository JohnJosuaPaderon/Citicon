using Citicon.Data;
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
    public class GetVehicleTypeById : IDisposable
    {
        private ulong VehicleTypeId;
        private MySqlConnectionHelper ConnectionHelper;

        public GetVehicleTypeById(ulong vehicleTypeId)
        {
            VehicleTypeId = vehicleTypeId;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<VehicleType> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetVehicleTypeById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_VehicleTypeId", VehicleTypeId);
                    VehicleType vehicleType = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();
                                vehicleType = new VehicleType
                                {
                                    Id = VehicleTypeId,
                                    Code = reader.GetString("Code"),
                                    Description = reader.GetString("Description")
                                };
                            }
                        }
                    }
                    catch (Exception)
                    {
                        vehicleType = null;
                        throw;
                    }
                    return vehicleType;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
