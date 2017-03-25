using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetDeliveryListByClient : DataProcessBase
    {
        private Client Client;

        public GetDeliveryListByClient(Client client)
        {
            Client = client;
        }

        public async Task <IEnumerable<Delivery>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetDeliveryListByClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ClientId", Client.Id);
                    List<Delivery> deliveries = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                deliveries = new List<Delivery>();
                                while (await reader.ReadAsync())
                                {
                                    deliveries.Add(new Delivery
                                    {
                                        CommulativeVolume = reader.GetDecimal("CommulativeVolume"),
                                        DeliveryDate = reader.GetDateTime("DeliveryDate"),
                                        DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                                        Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DriverId")),
                                        Id = reader.GetUInt64("Id"),
                                        Load = reader.GetString("Load"),
                                        PlantTrip = new DateTimeRange(reader.GetDateTime("PlantLeave"), reader.GetDateTime("PlantArrived")),
                                        //Project
                                        PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        deliveries = null;
                        throw;
                    }
                    return deliveries;
                }
            }
        }
    }
}
