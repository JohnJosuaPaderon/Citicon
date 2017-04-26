using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetTripReportDeliveryListByDriver : DataProcessBase
    {
        public GetTripReportDeliveryListByDriver(DateTimeRange range, Employee driver)
        {
            Range = range ?? throw new ArgumentNullException(nameof(range));
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            RouteManager = new DeliveryRouteManager();
            BranchManager = new BranchManager();
            TransitMixerManager = new TransitMixerManager();
        }

        private DateTimeRange Range;
        private Employee Driver;
        private DeliveryRouteManager RouteManager;
        private BranchManager BranchManager;
        private TransitMixerManager TransitMixerManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetTripReportDeliveryListByDriver", connection);
            command.Parameters.AddWithValue("@_DriverId", Driver.Id);
            command.Parameters.AddWithValue("@_RangeStart", Range.Start);
            command.Parameters.AddWithValue("@_RangeEnd", Range.End);

            return command;
        }

        public Task<IEnumerable<Delivery>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        public override void Dispose()
        {
            Range = null;
            Driver = null;
            BranchManager = null;
            RouteManager = null;
            TransitMixerManager = null;
            base.Dispose();
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery()
            {
                Id = reader.GetUInt64("Id"),
                Admixture = reader.GetString("Admixture"),
                AdmixtureQuantity = reader.GetDecimal("AdmixtureQuantity"),
                Billing = null,
                Branch = await BranchManager.GetByIdAsync(reader.GetUInt64("BranchId")),
                DeliveryDate = reader.GetDateTime("DeliveryDate"),
                CommulativeVolume = 0,
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DriverId")),
                Load = reader.GetString("Load"),
                MaxSlump = reader.GetDecimal("MaxSlump"),
                PlantArrive = reader.GetNullableDateTime("PlantArrive"),
                PlantLeave = reader.GetNullableDateTime("PlantLeave"),
                PricePerCubicMeter = 0,
                Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                Remarks = null,
                Route = await RouteManager.GetByIdAsync(reader.GetInt64("RouteId")),
                TransitMixer = await TransitMixerManager.GetByIdAsync(reader.GetUInt64("TransitMixerId")),
                Volume = reader.GetDecimal("Volume")
            };
        }
    }
}
