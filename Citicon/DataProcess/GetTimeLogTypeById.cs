using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetTimeLogTypeById : DataProcessBase
    {
        public GetTimeLogTypeById(ulong id)
        {
            Id = id;
        }

        private ulong Id;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetTimeLogTypeById", connection);
            command.Parameters.AddWithValue("@_Id", Id);

            return command;
        }

        private TimeLogType FromReader(DbDataReader reader)
        {
            return new TimeLogType()
            {
                Id = Id,
                Description = reader.GetString("Description")
            };
        }

        public Task<TimeLogType> ExecuteAsync(MySqlConnection connection)
        {
            using (var command = CreateCommand(connection))
            {
                return ProcessUtility.HandleReadingAsync(command, FromReader);
            }
        }

        public Task<TimeLogType> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
