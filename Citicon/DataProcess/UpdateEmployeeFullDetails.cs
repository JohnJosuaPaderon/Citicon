using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateEmployeeFullDetails : DataProcessBase
    {
        public UpdateEmployeeFullDetails(Employee employee)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private readonly Employee _Employee;

        public async Task ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            await EmployeeManager.UpdateAsync(_Employee, connection, transaction);
        }

        public Task ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
