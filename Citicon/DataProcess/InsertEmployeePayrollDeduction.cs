using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertEmployeePayrollDeduction : DataProcessBase
    {
        public InsertEmployeePayrollDeduction(EmployeePayrollDeduction employeePayrollDeduction)
        {
            _EmployeePayrollDeduction = employeePayrollDeduction ?? throw new ArgumentNullException(nameof(employeePayrollDeduction));
        }

        private readonly EmployeePayrollDeduction _EmployeePayrollDeduction;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("InsertEmployeePayrollDeduction", connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_EmployeeId", _EmployeePayrollDeduction.Employee?.Id)
                .AddInParameter("@_EffectivityDate", _EmployeePayrollDeduction.EffectivityDate)
                .AddInParameter("@_Sss", _EmployeePayrollDeduction.Sss)
                .AddInParameter("@_SssEc", _EmployeePayrollDeduction.SssEc)
                .AddInParameter("@_SssEr", _EmployeePayrollDeduction.SssEr)
                .AddInParameter("@_PagibigLoan", _EmployeePayrollDeduction.PagibigLoan)
                .AddInParameter("@_PhilHealth", _EmployeePayrollDeduction.PhilHealth)
                .AddInParameter("@_WithholdingTax", _EmployeePayrollDeduction.WithholdingTax);
        }

        public async Task<EmployeePayrollDeduction> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                _EmployeePayrollDeduction.Id = command.Parameters.GetUInt64("@_Id");
                return _EmployeePayrollDeduction;
            }
        }

        public Task<EmployeePayrollDeduction> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
