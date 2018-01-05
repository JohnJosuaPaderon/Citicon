using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class UpdateEmployeePayrollDeduction : DataProcessBase
    {
        public UpdateEmployeePayrollDeduction(EmployeePayrollDeduction employeePayrollDeduction)
        {
            _EmployeePayrollDeduction = employeePayrollDeduction;
        }

        private readonly EmployeePayrollDeduction _EmployeePayrollDeduction;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(UpdateEmployeePayrollDeduction), connection, transaction)
                .AddInParameter("@_Id", _EmployeePayrollDeduction.Id)
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
                return _EmployeePayrollDeduction;
            }
        }

        public Task<EmployeePayrollDeduction> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
