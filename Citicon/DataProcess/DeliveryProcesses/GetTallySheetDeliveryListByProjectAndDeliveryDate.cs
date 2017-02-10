using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetTallySheetDeliveryListByProjectAndDeliveryDate : IDisposable
    {
        private Project Project;
        private DateTime DeliveryDate;
        private MySqlConnectionHelper ConnectionHelper;

        public GetTallySheetDeliveryListByProjectAndDeliveryDate(Project project, DateTime deliveryDate)
        {
            Project = project;
            DeliveryDate = deliveryDate;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Delivery>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetTallySheetDeliveryListByProjectIdAndDeliveryDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", Project.Id);
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
                                        CommulativeVolume = reader.GetDecimal("CommulativeVolume"),
                                        DeliveryDate = DeliveryDate,
                                        DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                                        Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("Driver")),
                                        Id = reader.GetUInt64("Id"),
                                        Load = reader.GetString("Load"),
                                        PlantTrip = new DateTimeRange(reader.GetDateTime("PlantLeave"), reader.GetDateTime("PlantArrived")),
                                        Project = Project,
                                        ProjectDesign = null,
                                        TransitMixer = await VehicleManager.GetByVehicleIdAsync(reader.GetUInt64("TransitMixer")),
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

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
