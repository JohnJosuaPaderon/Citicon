using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetLatestDeliveryReceiptNumber : DataProcessBase
    {
        public GetLatestDeliveryReceiptNumber(DateTime deliveryDate)
        {
            DeliveryDate = deliveryDate;
        }

        private DateTime DeliveryDate;
        private const string Parameter_DeliveryDate = "@_DeliveryDate";

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                Connection = connection,
                CommandText = string.Format("SELECT GetLatestDeliveryReceiptNumber({0});", Parameter_DeliveryDate)
            };
            command.Parameters.AddWithValue(Parameter_DeliveryDate, DeliveryDate);

            return command;
        }

        public Task<ulong> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, Convert.ToUInt64);
        }
    }
}
