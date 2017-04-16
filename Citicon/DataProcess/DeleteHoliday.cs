using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class DeleteHoliday : DataProcessBase
    {
        public DeleteHoliday(Holiday holiday)
        {
            Holiday = holiday ?? throw new ArgumentNullException(nameof(holiday));
        }

        private Holiday Holiday;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("DeleteHoliday", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Holiday.Id);

            return command;
        }

        public override void Dispose()
        {
            Holiday = null;
            base.Dispose();
        }

        public async Task<Holiday> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() != 1)
                {
                    Holiday = null;
                }

                return Holiday;
            }
        }

        public Task<Holiday> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
