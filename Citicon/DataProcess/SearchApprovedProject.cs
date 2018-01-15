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
    internal sealed class SearchApprovedProject : DataProcessBase
    {
        public SearchApprovedProject(string searchKey, SearchApprovedProjectPredicate predicate)
        {
            _SearchKey = searchKey;
            _Predicate = predicate;
        }

        private readonly string _SearchKey;
        private readonly SearchApprovedProjectPredicate _Predicate;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(SearchApprovedProject), connection)
                .AddInParameter("@_SearchKey", _SearchKey)
                .AddInParameter("@_Predicate", _Predicate.ToString());
        }

        private async Task<Project> FromReaderAsync(DbDataReader reader)
        {
            return new Project
            {
                Client = await ClientManager.GetByIdAsync(reader.GetUInt64("ClientId")),
                Id = reader.GetUInt64("Id"),
                Location = reader.GetString("Location"),
                Name = reader.GetString("Name"),
                QuotationType = QuotationTypeConverter.Parse(reader.GetString("QuotationType")),
                Type = ProjectTypeConverter.Parse(reader.GetString("Type"))
            };
        }

        public Task<IEnumerable<Project>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
