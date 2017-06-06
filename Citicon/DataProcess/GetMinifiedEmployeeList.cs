using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetMinifiedEmployeeList : DataProcessBase
    {
        public GetMinifiedEmployeeList()
        {
            BranchManager = new BranchManager();
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetMinifiedEmployeeList", connection);
            return command;
        }

        private BranchManager BranchManager;

        public override void Dispose()
        {
            BranchManager = null;
            base.Dispose();
        }

        public Task<IEnumerable<Employee>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private Employee FromReader(DbDataReader reader)
        {
            return new Employee()
            {
                Id = reader.GetInt64("Id"),
                FirstName = reader.GetString("FirstName"),
                MiddleName = reader.GetString("MiddleName"),
                LastName = reader.GetString("LastName"),
                PayrollType = PayrollTypeManager.Parse(reader.GetString("PayrollType")),
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId"))
            };
        }
    }
}
