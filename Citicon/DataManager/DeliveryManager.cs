﻿using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class DeliveryManager
    {
        private static List<Delivery> Deliveries = new List<Delivery>();

        private static void ManageItem(Delivery delivery)
        {
            if (Deliveries.Contains(delivery))
            {
                var index = Deliveries.IndexOf(delivery);
                Deliveries[index] = delivery;
            }
            else
            {
                Deliveries.Add(delivery);
            }
        }

        public static async Task<IEnumerable<Delivery>> GetUnbilledListByProject(Project project)
        {
            using (var process = new GetUnbilledDeliveryListByProject(project))
            {
                var list = await process.ExecuteAsync();

                if (list != null)
                {
                    foreach (var item in list)
                    {
                        ManageItem(item);
                    }
                }

                return list;
            }
        }

        public static async Task<Delivery> FromDbDataReader(DbDataReader dataReader)
        {
            return new Delivery()
            {
                CommulativeVolume= dataReader.GetDecimal("CommulativeVolume"),
                DeliveryDate = dataReader.GetDateTime("DeliveryDate"),
                DeliveryReceiptNumber = dataReader.GetUInt64("DeliveryReceiptNumber"),
                Driver = await EmployeeManager.GetByIdAsync(dataReader.GetInt64("Driver")),
                Id = dataReader.GetUInt64("Id"),
                Load = dataReader.GetString("Load"),
                PlantTrip = new DateTimeRange(dataReader.GetDateTime("PlantLeave"), dataReader.GetDateTime("PlantArrived")),
                Project = await ProjectManager.GetByIdAsync(dataReader.GetUInt64("ProjectId")),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(dataReader.GetUInt64("ProjectDesignId")),
                Remarks = dataReader.GetString("Remarks"),
                TransitMixer = await VehicleManager.GetByVehicleIdAsync(dataReader.GetUInt64("TransitMixer")),
                Volume = dataReader.GetDecimal("Volume"),
                PricePerCubicMeter = dataReader.GetDecimal("PricePerCubicMeter")
            };
        }

        public static async Task<IEnumerable<Delivery>> GetTallySheetDeliveryListByClientAndDeliveryDate(Client client, DateTime deliveryDate)
        {
            using (var getTallySheetDeliveryListByClientAndDeliveryDate = new GetTallySheetDeliveryListByClientAndDeliveryDate(client, deliveryDate))
            {
                var deliveries = await getTallySheetDeliveryListByClientAndDeliveryDate.GetAsync();
                if (deliveries != null)
                {
                    foreach (var item in deliveries)
                    {
                        ManageItem(item);
                    }
                }
                return deliveries;

            }
        }

        public static async Task<IEnumerable<Delivery>> GetTallySheetDeliveryListByProjectAndDeliveryDateAsync(Project project, DateTime deliveryDate)
        {
            using (var getTallySheetDeliveryListByProjectAndDeliveryDate = new GetTallySheetDeliveryListByProjectAndDeliveryDate(project, deliveryDate))
            {
                var deliveries = await getTallySheetDeliveryListByProjectAndDeliveryDate.GetAsync();
                if (deliveries != null)
                {
                    foreach (var item in deliveries)
                    {
                        ManageItem(item);
                    }
                }
                return deliveries;
            }
        }

        public static async Task UpdateDeliveryBillingId(Delivery delivery, MySqlConnection connection, MySqlTransaction transaction)
        {
            var process = new UpdateDeliveryBillingId(delivery);
            await process.ExecuteAsync(connection, transaction);
        }
    }
}
