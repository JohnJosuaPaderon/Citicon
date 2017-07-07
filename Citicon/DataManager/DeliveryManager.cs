using Citicon.Data;
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

        public static async Task<Delivery> ConfirmDeliveryAsync(Delivery delivery)
        {
            if (delivery != null)
            {
                using (var process = new ConfirmDelivery(delivery))
                {
                    delivery = await process.ExecuteAsync();
                }
            }

            return delivery;
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

        public static Task<IEnumerable<Delivery>> GetUnbilledDeliveryListAsync(bool filterByDeliveryDate, DateTime deliveryDate)
        {
            using (var process = new GetUnbilledDeliveryList(filterByDeliveryDate, deliveryDate))
            {
                return process.ExecuteAsync();
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
                PlantLeave = dataReader.GetNullableDateTime("PlantLeave"),
                PlantArrive = dataReader.GetNullableDateTime("PlantArrived"),
                Project = await ProjectManager.GetByIdAsync(dataReader.GetUInt64("ProjectId")),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(dataReader.GetUInt64("ProjectDesignId")),
                Remarks = dataReader.GetString("Remarks"),
                TransitMixer = await VehicleManager.GetByVehicleIdAsync(dataReader.GetUInt64("TransitMixer")) as TransitMixer,
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

        public static async Task<IEnumerable<Delivery>> GetListByProjectDesignAndDeliveryDateAsync(ProjectDesign projectDesign, DateTime deliveryDate)
        {
            if (projectDesign != null)
            {
                using (var process = new GetDeliveryListByProjectDesignAndDeliveryDate(projectDesign, deliveryDate))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<string> ExportDailyTallySheetAsync(TallySheetReport tallySheet)
        {
            if (tallySheet != null)
            {
                using (var process = new ExportTallySheet(tallySheet))
                {
                    await process.ExecuteAsync();
                    return process.FilePath;
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<Delivery> InsertAsync(Delivery delivery)
        {
            if (delivery != null)
            {
                using (var process = new InsertDelivery(delivery))
                {
                    delivery = await process.ExecuteAsync();
                }
            }

            return delivery;
        }

        public static Task<ulong> GetLatestDeliveryReceiptNumberAsync(DateTime deliveryDate)
        {
            using (var process = new GetLatestDeliveryReceiptNumber(deliveryDate))
            {
                return process.ExecuteAsync();
            }
        }

        public static Task<IEnumerable<Delivery>> GetTripReportDeliveryListByDriverAsync(DateTimeRange range, Employee driver)
        {
            if (range != null && driver != null)
            {
                using (var process = new GetTripReportDeliveryListByDriver(range, driver))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task ExportDeliveryReceiptAsync(Delivery delivery)
        {
            if (delivery != null)
            {
                using (var process = new ExportDeliveryReceipt(delivery))
                {
                    await process.ExecuteAsync();
                }
            }
        }
    }
}
