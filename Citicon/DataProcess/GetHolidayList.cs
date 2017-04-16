using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetHolidayList : DataProcessBase
    {
        public GetHolidayList(HolidaySearchFilter searchFilter)
        {
            SearchFilter = searchFilter;
            TypeManager = new HolidayTypeManager();
        }

        private HolidaySearchFilter SearchFilter;
        private HolidayTypeManager TypeManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetHolidayList", connection);
            command.Parameters.AddWithValue("@_SearchFilter", SearchFilter.ToString());

            return command;
        }

        public override void Dispose()
        {
            TypeManager = null;
            base.Dispose();
        }

        public Task<IEnumerable<Holiday>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }

        private async Task<Holiday> FromReaderAsync(DbDataReader reader)
        {
            return new Holiday()
            {
                Id = reader.GetUInt64("Id"),
                Type = await TypeManager.GetByIdAsync(reader.GetUInt64("TypeId")),
                Name = reader.GetString("Name"),
                DateOccur = reader.GetDateTime("DateOccur")
            };
        }
    }
}
