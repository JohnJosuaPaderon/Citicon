using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateEmployeeFullDetails : DataProcessBase
    {
        public UpdateEmployeeFullDetails(Employee employee, EmployeePayrollAddition payrollAddition, EmployeePayrollDeduction payrollDeduction)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
            _PayrollAddition = payrollAddition ?? throw new ArgumentNullException(nameof(payrollAddition));
            _PayrollDeduction = payrollDeduction ?? throw new ArgumentNullException(nameof(payrollDeduction));
        }

        private readonly Employee _Employee;
        private readonly EmployeePayrollAddition _PayrollAddition;
        private readonly EmployeePayrollDeduction _PayrollDeduction;

        public async Task ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            await EmployeeManager.UpdateAsync(_Employee, connection, transaction);
            _PayrollAddition.Employee = _Employee;
            _PayrollDeduction.Employee = _Employee;
            await EmployeePayrollAdditionManager.UpdateAsync(_PayrollAddition, connection, transaction);
            await EmployeePayrollDeductionManager.UpdateAsync(_PayrollDeduction, connection, transaction);
        }

        public Task ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
