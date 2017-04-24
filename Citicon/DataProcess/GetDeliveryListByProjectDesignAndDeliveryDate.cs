using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetDeliveryListByProjectDesignAndDeliveryDate : DataProcessBase
    {
        public GetDeliveryListByProjectDesignAndDeliveryDate(ProjectDesign projectDesign, DateTime deliveryDate)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
            DeliveryDate = deliveryDate;
        }

        private DateTime DeliveryDate;
        private ProjectDesign ProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDeliveryListByProjectDesignAndDeliveryDate", connection);
            command.Parameters.AddWithValue("@_ProjectDesignId", ProjectDesign.Id);
            command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);

            return command;
        }

        public override void Dispose()
        {
            ProjectDesign = null;
            base.Dispose();
        }

        public Task<IEnumerable<Delivery>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<Delivery> FromReaderAsync(DbDataReader reader)
        {
            return new Delivery()
            {
                Id = reader.GetUInt64("Id"),
                ProjectDesign = ProjectDesign,
                DeliveryReceiptNumber = reader.GetUInt64("DeliveryReceiptNumber"),
                Load = reader.GetString("Load"),
                TransitMixer = TransitMixer.FromBase(await VehicleManager.GetByVehicleIdAsync(reader.GetUInt64("TransitMixerId"))),
                Driver = await EmployeeManager.GetByIdAsync(reader.GetInt64("DriverId")),
                PlantLeave = reader.GetDateTime("PlantLeave"),
                PlantArrive = reader.GetDateTime("PlantArrive"),
                Volume = reader.GetDecimal("Volume")
            };
        }
    }
}
