using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveSemiMonthlyPayroll : SavePayroll<SemiMonthlyPayroll>
    {
        public SaveSemiMonthlyPayroll(SemiMonthlyPayroll payroll, IEnumerable<SemiMonthlyPayrollEmployee> payrollEmployees) : base(payroll)
        {
            _PayrollEmployees = payrollEmployees ?? throw new ArgumentNullException(nameof(payrollEmployees));
        }

        private readonly IEnumerable<SemiMonthlyPayrollEmployee> _PayrollEmployees;

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
                            await PayrollManager.SaveSemiMonthlyPayrollEmployeeAsync(payrollEmployee, connection, transaction);
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
