using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateHoliday : DataProcessBase
    {
        public UpdateHoliday(Holiday holiday)
        {
            Holiday = holiday ?? throw new ArgumentNullException(nameof(holiday));
        }

        private Holiday Holiday;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("UpdateHoliday", connection, transaction);
            command.Parameters.AddWithValue("@_Id", Holiday.Id);
            command.Parameters.AddWithValue("@_TypeId", Holiday.Type?.Id);
            command.Parameters.AddWithValue("@_Name", Holiday.Name);
            command.Parameters.AddWithValue("@_DateOccur", Holiday.DateOccur);

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
