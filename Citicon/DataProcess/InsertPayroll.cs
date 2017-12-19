using Citicon.Data;
using Citicon.Extensions;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertPayroll : DataProcessBase
    {
        public InsertPayroll(Payroll payroll)
        {
            _Payroll = payroll;
        }

        private readonly Payroll _Payroll;

        private MySqlCommand InsertPayrollCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertPayroll", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter("@_Id"));
            command.Parameters.AddWithValue("@_DateRangeBegin", _Payroll.DateRange.Begin);
            command.Parameters.AddWithValue("@_DateRangeEnd", _Payroll.DateRange.End);
            command.Parameters.AddWithValue("@_BranchId", _Payroll.Branch?.Id);
            return command;
        }

        private MySqlCommand InsertEmployeePayrollCommand(EmployeePayroll employeePayroll, MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertEmployeePayroll", connection, transaction);
            command.Parameters.AddWithValue("@_EmployeeId", employeePayroll.Employee?.Id);
            return command;
        }

        private async Task<Payroll> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = InsertPayrollCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    _Payroll.Id = DbValueConverter.ToUInt64(command.Parameters.GetUInt64("@_Id"));
                    return _Payroll;
                }
                else
                {
                    return null;
                }
            }
        }

        private async Task<bool> ExecuteAsync(EmployeePayroll employeePayroll, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = InsertEmployeePayrollCommand(employeePayroll, connection, transaction))
            {
                return await command.ExecuteNonQueryAsync() == 1;
            }
        }

        public async Task<Payroll> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        await ExecuteAsync(connection, transaction);
                        foreach (var employee in _Payroll.Employees)
                        {
                            await ExecuteAsync(employee, connection, transaction);
                        }
                        transaction.Commit();
                        return _Payroll;
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
