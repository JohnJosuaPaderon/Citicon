using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetJobPositionList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetJobPositionList", connection);
            return command;
        }

        private JobPosition FromReader(DbDataReader reader)
        {
            return new JobPosition()
            {
                Id = reader.GetUInt32("Id"),
                Department = DepartmentManager.GetById(reader.GetInt64("DepartmentId")),
                Name = reader.GetString("Name")
            };
        }

        public Task<IEnumerable<JobPosition>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }
    }
}
