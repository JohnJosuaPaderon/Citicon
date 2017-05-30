﻿using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetUnbilledDeliveryList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetUnbilledDeliveryList", connection);
            return command;
        }

        private BranchManager BranchManager = new BranchManager();
        private DeliveryRouteManager RouteManager = new DeliveryRouteManager();
        private TransitMixerManager TransitMixerManager = new TransitMixerManager();

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery()
            {
                Admixture = reader.GetString("Admixture"),
                AdmixtureQuantity = reader.GetDecimal("AdmixtureQuantity"),
                Billing = null,
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                CommulativeVolume = reader.GetDecimal("CommulativeVolume"),
                DeliveryDate = reader.GetDateTime("DeliveryDate"),
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DriverId")),
                Id = reader.GetUInt64("Id"),
                Load = reader.GetString("Load"),
                MaxSlump = reader.GetDecimal("MaxSlump"),
                PlantArrive = reader.GetNullableDateTime("PlantArrive"),
                PlantLeave = reader.GetNullableDateTime("PlantLeave"),
                PricePerCubicMeter = reader.GetDecimal("PricePerCubicMeter"),
                Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                ProjectDesign = await ProjectDesignManager.GetByIdAsync(reader.GetUInt64("ProjectDesignId")),
                Remarks = reader.GetString("Remarks"),
                Route = await RouteManager.GetByIdAsync(reader.GetInt64("RouteId")),
                TransitMixer = await TransitMixerManager.GetByIdAsync(reader.GetUInt64("TransitMixerId")),
                Volume = reader.GetDecimal("Volume")
            };
        }

        public Task<IEnumerable<Delivery>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        public override void Dispose()
        {
            BranchManager = null;
            RouteManager = null;
            TransitMixerManager = null;
            base.Dispose();
        }
    }
}