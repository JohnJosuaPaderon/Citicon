using Citicon.Data;
using Citicon.Data.Converters;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SearchProjectWithCancellableDelivery : DataProcessBase
    {
        public SearchProjectWithCancellableDelivery(string searchKey, SearchProjectOption option)
        {
            _SearchKey = searchKey;
            _Option = option;
        }
        
        private readonly string _SearchKey;
        private readonly SearchProjectOption _Option;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(SearchProjectWithCancellableDelivery), connection)
                .AddInParameter("@_SearchKey", _SearchKey)
                .AddInParameter("@_Option", _Option.Key);
        }

        private async Task<Project> FromReaderAsync(DbDataReader reader)
        {
            return new Project
            {
                Client = await ClientManager.GetByIdAsync(reader.GetUInt64("ClientId")),
                Completed = default(bool),
                Id = reader.GetUInt64("Id"),
                InitialCement = default(double),
                InitialPayment = default(decimal),
                Location = reader.GetString("Location"),
                Name = reader.GetString("Name"),
                QuotationType = QuotationTypeConverter.Parse(reader.GetString("QuotationType")),
                TotalCost = default(decimal),
                Type = ProjectTypeConverter.Parse(reader.GetString("Type"))
            };
        }

        public Task<IEnumerable<Project>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
