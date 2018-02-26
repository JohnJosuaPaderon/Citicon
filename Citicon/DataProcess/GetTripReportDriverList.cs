using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetTripReportDriverList : DataProcessBase
    {
        public GetTripReportDriverList(DateTimeRange range)
        {
            Range = range ?? throw new ArgumentNullException(nameof(range));
        }

        private DateTimeRange Range;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetTripReportDriverList", connection);
            command.Parameters.AddWithValue("@_RangeStart", Range.Begin);
            command.Parameters.AddWithValue("@_RangeEnd", Range.End);

            return command;
        }

        public Task<IEnumerable<Employee>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        public override void Dispose()
        {
            Range = null;
            base.Dispose();
        }

        private Employee FromReader(DbDataReader reader)
        {
            return new Employee()
            {
                Id = reader.GetInt64("Id"),
                FirstName = reader.GetString("FirstName"),
                MiddleName = reader.GetString("MiddleName"),
                LastName = reader.GetString("LastName"),
                Position = JobPositionManager.GetById(reader.GetInt64("PositionId")),
                ShopRate = reader.GetDecimal("ShopRate")
            };
        }
    }
}
