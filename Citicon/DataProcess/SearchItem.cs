using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SearchItem : DataProcessBase
    {
        public SearchItem(SearchItemCategory category, string searchKey)
        {
            _Category = category;
            _SearchKey = searchKey;
            _ClassificationManager = new ClassificationManager();
            _MeasurementUnitManager = new MeasurementUnitManager();
        }

        private readonly ClassificationManager _ClassificationManager;
        private readonly MeasurementUnitManager _MeasurementUnitManager;
        private readonly SearchItemCategory _Category;
        private readonly string _SearchKey;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("SearchItem", connection);
            command.Parameters.AddWithValue("@_Category", _Category.ToString());
            command.Parameters.AddWithValue("@_SearchKey", _SearchKey);

            return command;
        }

        private async Task<Item> FromReaderAsync(DbDataReader reader)
        {
            return new Item()
            {
                Id = reader.GetUInt64("Id"),
                Classification = await _ClassificationManager.GetByIdAsync(reader.GetUInt64("ClassificationId")),
                MeasurementUnit = await _MeasurementUnitManager.GetByIdAsync(reader.GetUInt64("MeasurementUnitId")),
                Code = reader.GetString("Code"),
                Description = reader.GetString("Description"),
                StockValue = reader.GetDecimal("StockValue")
            };
        }

        public  Task<IEnumerable<Item>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
