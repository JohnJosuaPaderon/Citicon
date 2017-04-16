using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetHolidayTypeList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetHolidayTypeList", connection);
            return command;
        }

        public Task<IEnumerable<HolidayType>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private HolidayType FromReader(DbDataReader reader)
        {
            return new HolidayType()
            {
                Id = reader.GetUInt64("Id"),
                Description = reader.GetString("Description")
            };
        }
    }
}
