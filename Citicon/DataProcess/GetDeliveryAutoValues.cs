using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetDeliveryAutoValues : DataProcessBase
    {
        public GetDeliveryAutoValues(ProjectDesign projectDesign, DateTime deliveryDate)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
            DeliveryDate = deliveryDate;
        }

        private ProjectDesign ProjectDesign;
        private DateTime DeliveryDate;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetDeliveryAutoValues", connection);
            command.Parameters.AddWithValue("@_ProjectDesignId", ProjectDesign.Id);
            command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);

            return command;
        }

        private DeliveryAutoValues FromReader(DbDataReader reader)
        {
            return new DeliveryAutoValues()
            {
                Load = reader.GetUInt32("Load"),
                CumulativeVolume = reader.GetDecimal("CumulativeVolume")
            };
        }

        public Task<DeliveryAutoValues> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
