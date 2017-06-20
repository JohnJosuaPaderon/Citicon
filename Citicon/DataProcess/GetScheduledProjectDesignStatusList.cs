using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetScheduledProjectDesignStatusList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetScheduledProjectDesignStatusList", connection);
            return command;
        }

        private ScheduledProjectDesignStatus FromReader(DbDataReader reader)
        {
            return new ScheduledProjectDesignStatus(reader.GetString("Value"));
        }

        public Task<IEnumerable<ScheduledProjectDesignStatus>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }
    }
}
