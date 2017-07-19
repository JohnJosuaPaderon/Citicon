using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetMaximumScheduledVolumeByProjectDesignAndDeliveryDate : DataProcessBase
    {
        public GetMaximumScheduledVolumeByProjectDesignAndDeliveryDate(ProjectDesign projectDesign, DateTime deliveryDate)
        {
            ProjectDesign = projectDesign;
            DeliveryDate = deliveryDate;
        }

        private ProjectDesign ProjectDesign;
        private DateTime DeliveryDate;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetMaximumScheduledVolumeByProjectDesignAndDeliveryDate", connection);
            command.Parameters.AddWithValue("@_ProjectDesignId", ProjectDesign?.Id);
            command.Parameters.AddWithValue("@_DeliveryDate", DeliveryDate);

            return command;
        }

        public Task<decimal> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, Convert.ToDecimal);
        }
    }
}
