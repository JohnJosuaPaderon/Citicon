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
        }

        private DateTimeRange Range;
        private Employee Driver;

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
            base.Dispose();
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery()
            {
                Id = reader.GetUInt64("Id"),
                Admixture = reader.GetString("Admixture"),
                AdmixtureQuantity = reader.GetString("AdmixtureQuantity"),
                Billing = null,
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                DeliveryDate = reader.GetDateTime("DeliveryDate"),
                CumulativeVolume = 0,
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                Driver = Driver,
                Load = reader.GetUInt32("Load"),
                MaxSlump = reader.GetString("MaxSlump"),
                PlantArrive = reader.GetNullableDateTime("PlantArrive"),
                PlantLeave = reader.GetNullableDateTime("PlantLeave"),
                PricePerCubicMeter = 0,
                Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                Remarks = null,
                Route = await DeliveryRouteManager.GetByIdAsync(reader.GetInt64("RouteId")),
                TransitMixer = await TransitMixerManager.GetByIdAsync(reader.GetUInt64("TransitMixerId")),
                Volume = reader.GetDecimal("Volume")
            };
        }
    }
}
