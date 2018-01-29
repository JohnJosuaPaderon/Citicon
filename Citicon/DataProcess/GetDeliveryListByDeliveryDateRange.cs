using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDeliveryListByDeliveryDateRange : DataProcessBase
    {
        public GetDeliveryListByDeliveryDateRange(DateTimeRange deliveryDateRange)
        {
            _DeliveryDateRange = deliveryDateRange;
        }

        private readonly DateTimeRange _DeliveryDateRange;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetDeliveryListByDeliveryDateRange), connection)
                .AddInParameter("@_DeliveryDateRangeBegin", _DeliveryDateRange.Begin)
                .AddInParameter("@_DeliveryDateRangeEnd", _DeliveryDateRange.End);
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery
            {
                Id = reader.GetUInt64("Id"),
                Admixture = reader.GetString("Admixture"),
                AdmixtureQuantity = reader.GetString("AdmixtureQuantity"),
                Billing = null,
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                DeliveryDate = reader.GetDateTime("DeliveryDate"),
                CumulativeVolume = 0,
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DriverId")),
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

        public Task<IEnumerable<Delivery>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
