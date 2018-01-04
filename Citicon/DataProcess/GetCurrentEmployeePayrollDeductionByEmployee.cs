using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCurrentEmployeePayrollDeductionByEmployee : DataProcessBase
    {
        public GetCurrentEmployeePayrollDeductionByEmployee(Employee employee)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private readonly Employee _Employee;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand("GetCurrentEmployeePayrollDeductionByEmployee", connection)
                .AddInParameter("@_EmployeeId", _Employee?.Id);
        }

        private EmployeePayrollDeduction FromReader(DbDataReader reader)
        {
            return new EmployeePayrollDeduction
            {
                Id = reader.GetUInt64("Id"),
                Employee = _Employee,
                EffectivityDate = reader.GetDateTime("EffectivityDate"),
                Sss = reader.GetDecimal("Sss"),
                SssEc = reader.GetDecimal("SssEc"),
                SssEr = reader.GetDecimal("SssEr"),
                PagibigLoan = reader.GetDecimal("PagibigLoan"),
                PhilHealth = reader.GetDecimal("PhilHealth"),
                WithholdingTax = reader.GetDecimal("WithholdingTax")
            };
        }

        public Task<EmployeePayrollDeduction> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
