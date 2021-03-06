﻿using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetTallySheetDeliveryListByClientAndDeliveryDate : DataProcessBase
    {
        private Client Client;
        private DateTime DeliveryDate;

        public GetTallySheetDeliveryListByClientAndDeliveryDate(Client client, DateTime deliveryDate)
        {
            Client = client;
            DeliveryDate = deliveryDate;
        }

        public async Task<IEnumerable<Delivery>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetTallySheetDeliveryListByClientIdAndDeliveryDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ClientId", Client.Id);
                    command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);
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
                                        CumulativeVolume = reader.GetDecimal("CommulativeVolume"),
                                        DeliveryDate = DeliveryDate,
                                        DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                                        Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("Driver")),
                                        Id = reader.GetUInt64("Id"),
                                        Load = reader.GetUInt32("Load"),
                                        PlantArrive = reader.GetNullableDateTime("PlantArrive"),
                                        PlantLeave = reader.GetNullableDateTime("PlantLeave"),
                                        Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                                        ProjectDesign = null,
                                        TransitMixer = TransitMixer.FromBase(await VehicleManager.GetByVehicleIdAsync(reader.GetUInt64("TransitMixer"))),
                                        Volume = reader.GetDecimal("Volume"),
                                        Remarks = reader.GetString("Remarks")
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
