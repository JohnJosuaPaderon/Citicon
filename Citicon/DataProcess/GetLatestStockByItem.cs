using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetLatestStockByItem : DataProcessBase
    {
        public GetLatestStockByItem(Item item)
        {
            Item = item;
        }

        private Item Item;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetLatestStockByItem", connection);
            command.Parameters.AddWithValue("@_ItemId", Item.Id);

            return command;
        }

        private async Task<Stock> FromReaderAsync(DbDataReader reader)
        {
            return new Stock()
            {
                AcceptedBy = reader.GetString("AcceptedBy"),
                AddedStockValue = reader.GetDecimal("AddedStockValue"),
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                UnitPrice = reader.GetDecimal("UnitPrice"),
                DeliveryDate = reader.GetDateTime("DeliveryDate")
            };
        }
        
        public Task<Stock> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReaderAsync);
        }
    }
}
