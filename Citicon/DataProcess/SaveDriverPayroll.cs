using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveDriverPayroll : SavePayroll<DriverPayroll>
    {
        public SaveDriverPayroll(DriverPayroll payroll, IEnumerable<DriverPayrollEmployee> payrollEmployees) : base(payroll)
        {
            _PayrollEmployees = payrollEmployees;
        }

        private readonly IEnumerable<DriverPayrollEmployee> _PayrollEmployees;

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
                            await PayrollManager.SaveDriverPayrollEmployeeAsync(payrollEmployee, connection, transaction);
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
