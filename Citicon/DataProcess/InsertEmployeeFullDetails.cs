using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertEmployeeFullDetails : DataProcessBase
    {
        public InsertEmployeeFullDetails(Employee employee, EmployeePayrollAddition payrollAddition, EmployeePayrollDeduction payrollDeduction)
        {
            _Employee = employee;
            _PayrollAddition = payrollAddition;
            _PayrollDeduction = payrollDeduction;
        }

        private readonly Employee _Employee;
        private readonly EmployeePayrollAddition _PayrollAddition;
        private readonly EmployeePayrollDeduction _PayrollDeduction;

        public async Task ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            await EmployeeManager.InsertAsync(_Employee, connection, transaction);
            _PayrollAddition.Employee = _Employee;
            _PayrollDeduction.Employee = _Employee;
            await EmployeePayrollAdditionManager.InsertAsync(_PayrollAddition, connection, transaction);
            await EmployeePayrollDeductionManager.InsertAsync(_PayrollDeduction, connection, transaction);
        }

        public Task ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
