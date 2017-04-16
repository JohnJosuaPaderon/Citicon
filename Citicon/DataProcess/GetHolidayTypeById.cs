using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetHolidayTypeById : DataProcessBase
    {
        public GetHolidayTypeById(ulong holidayTypeId)
        {
            HolidayTypeId = holidayTypeId > 0 ? holidayTypeId : throw new ArgumentException("Value cannot be zero.", nameof(holidayTypeId));
        }

        private ulong HolidayTypeId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetHolidayTypeById", connection);
            command.Parameters.AddWithValue("@_Id", HolidayTypeId);

            return command;
        }

        public Task<HolidayType> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
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
