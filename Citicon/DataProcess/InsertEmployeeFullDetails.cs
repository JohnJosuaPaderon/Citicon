using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertEmployeeFullDetails : DataProcessBase
    {
        public InsertEmployeeFullDetails(Employee employee)
        {
            _Employee = employee;
        }

        private readonly Employee _Employee;

        public async Task ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            await EmployeeManager.InsertAsync(_Employee, connection, transaction);
        }

        public Task ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
