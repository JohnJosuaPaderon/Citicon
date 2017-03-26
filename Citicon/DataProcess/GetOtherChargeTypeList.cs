using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetOtherChargeTypeList : DataProcessBase
    {
        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetOtherChargeTypeList", connection);
            return command;
        }

        public Task<IEnumerable<OtherChargeType>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, OtherChargeTypeManager.FromDbDataReader);
        }
    }
}
