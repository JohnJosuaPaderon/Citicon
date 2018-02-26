using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveWeeklyPayroll : SavePayroll<WeeklyPayroll>
    {
        public SaveWeeklyPayroll(WeeklyPayroll payroll, IEnumerable<WeeklyPayrollEmployee> payrollEmployees) : base(payroll)
        {
            _PayrollEmployees = payrollEmployees ?? throw new ArgumentNullException(nameof(payrollEmployees));
        }

        private readonly IEnumerable<WeeklyPayrollEmployee> _PayrollEmployees;

        public async Task ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        await ExecuteAsync(connection, transaction);

                        foreach (var payrollEmployee in _PayrollEmployees)
                        {
                            await PayrollManager.SaveWeeklyPayrollEmployeeAsync(payrollEmployee, connection, transaction);
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
