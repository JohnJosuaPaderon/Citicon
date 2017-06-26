using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetPurchaseOrderListBySelector : DataProcessBase
    {
        public GetPurchaseOrderListBySelector(PurchaseOrderSelector selector)
        {
            Selector = selector;
        }

        private PurchaseOrderSelector Selector;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetPurchaseOrderListBySelector", connection);
            command.Parameters.AddWithValue("@_Selector", Selector.ToString());

            return command;
        }

        private async Task<PurchaseOrder> FromReaderAsync(DbDataReader reader)
        {
            return new PurchaseOrder()
            {
                Id = reader.GetUInt64("Id"),
                MaximumCumulativePricePerCubicMeter = reader.GetDecimal("MaximumCumulativePricePerCubicMeter"),
                Number = reader.GetString("Number"),
                Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId"))
            };
        }

        public Task<IEnumerable<PurchaseOrder>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
