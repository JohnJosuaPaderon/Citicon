using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertHoliday : DataProcessBase
    {
        public InsertHoliday(Holiday holiday)
        {
            Holiday = holiday ?? throw new ArgumentNullException(nameof(holiday));
        }

        private Holiday Holiday;
        private const string Parameter_Id = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertHoliday", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
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
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    Holiday.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                }
                else
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
