using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCancellableDeliveryListByProjectDesign : DataProcessBase
    {
        public GetCancellableDeliveryListByProjectDesign(ProjectDesign projectDesign)
        {
            _ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
        }

        private readonly ProjectDesign _ProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetCancellableDeliveryListByProjectDesign), connection)
                .AddInParameter("@_ProjectDesignId", _ProjectDesign.Id);
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery
            {
                Admixture = reader.GetString("Admixture"),
                AdmixtureQuantity = reader.GetString("AdmixtureQuantity"),
                Billing = null,
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                CumulativeVolume = default(decimal),
                DeliveryDate = reader.GetDateTime("DeliveryDate"),
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DriverId")),
                EstimatedStay = null,
                FinishedUnloading = null,
                Id = reader.GetUInt64("Id"),
                Load = reader.GetUInt32("Load"),
                LoadCutOff = null,
                MaxSlump = reader.GetString("MaxSlump"),
                PlantArrive = null,
                PlantLeave = reader.GetNullableDateTime("PlantLeave"),
                PricePerCubicMeter = default(decimal),
                Project = _ProjectDesign.Project,
                ProjectArrive = null,
                ProjectDesign = _ProjectDesign,
                PurchaseOrder = null,
                Remarks = null,
                Route = await DeliveryRouteManager.GetByIdAsync(reader.GetInt64("RouteId")),
                ScheduleStatus = default(DeliveryScheduleStatus),
                ServiceEngineer = null,
                StartUnloading = null,
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
