using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDeliveryReceiptByNumber : DataProcessBase
    {
        public GetDeliveryReceiptByNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentException("Invalid Delivery Receipt No.", nameof(number));
            }

            Number = number;
        }

        private string Number { get; set; }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDeliveryReceiptByNumber", connection);
            command.Parameters.AddWithValue("@_Number", Number);

            return command;
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery()
            {
                Admixture = reader.GetString("Admixture"),
                AdmixtureQuantity = reader.GetString("AdmixtureQuantity"),
                Billing = null, // GetById: not implemented.
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
                Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                ProjectArrive = reader.GetNullableDateTime("ProjectArrive"),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                PurchaseOrder = PurchaseOrderManager.GetById(reader.GetUInt64("PurchaseOrderId")),
                Remarks = reader.GetString("Remarks"),
                Route = await DeliveryRouteManager.GetByIdAsync(reader.GetInt64("RouteId")),
                ScheduleStatus = null, // GetById: not implemented.
                ServiceEngineer = await EmployeeManager.GetByIdAsync(reader.GetInt64("ServiceEngineerId")),
                StartUnloading = reader.GetNullableDateTime("StartUnloading"),
                TransitMixer = await TransitMixerManager.GetByIdAsync(reader.GetUInt64("TransitMixerId")),
                Volume = reader.GetDecimal("Volume")
            };
        }

        public Task<Delivery> ExecuteAsync(MySqlConnection connection)
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand(connection), FromReaderAsync);
        }

        public Task<Delivery> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
