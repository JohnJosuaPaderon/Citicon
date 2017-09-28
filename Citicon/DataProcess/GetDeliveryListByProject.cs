using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetDeliveryListByProject : DataProcessBase
    {
        public GetDeliveryListByProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDeliveryListByProject", connection);
            command.Parameters.AddWithValue("@_ProjectId", Project.Id);
            return command;
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery()
            {
                Admixture = reader.GetString("Admixture"),
                AdmixtureQuantity = reader.GetString("AdmixtureQuantity"),
                Billing = null,
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                CumulativeVolume = reader.GetDecimal("CumulativeVolume"),
                DeliveryDate = reader.GetDateTime("DeliveryDate"),
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),  
                Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DriverId")),
                EstimatedStay = reader.GetNullableDateTime("EstimatedStay"),
                FinishedUnloading = reader.GetNullableDateTime("FinishedUnloading"),
                Id = reader.GetUInt64("Id"),
                Load = reader.GetUInt32("Load"),
                MaxSlump = reader.GetString("MaxSlump"),
                PlantArrive = reader.GetNullableDateTime("PlantArrive"),
                PlantLeave = reader.GetNullableDateTime("PlantLeave"),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                Project = Project,
                ProjectArrive = reader.GetNullableDateTime("ProjectArrive"),
                ProjectDesign  = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                PurchaseOrder = PurchaseOrderManager.GetById(reader.GetUInt64("PurchaseOrderId")),
                Remarks = reader.GetString("Remarks"),
                Route = await DeliveryRouteManager.GetByIdAsync(reader.GetInt64("RouteId")),
                ScheduleStatus = reader.GetString("ScheduleStatus"),
                ServiceEngineer = await EmployeeManager.GetByIdAsync(reader.GetInt64("ServiceEngineerId")),
                StartUnloading = reader.GetNullableDateTime("StartUnloading"),
                TransitMixer = await TransitMixerManager.GetByIdAsync(reader.GetUInt64("TransitMixerId")),
                Volume = reader.GetDecimal("Volume")
            };
        }

        public Task<IEnumerable<Delivery>> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        public Task<IEnumerable<Delivery>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
