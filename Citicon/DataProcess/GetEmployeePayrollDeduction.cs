using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeePayrollDeduction : DataProcessBase
    {
        public GetEmployeePayrollDeduction(ulong id)
        {
            _Id = id;
        }

        private readonly ulong _Id;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand("GetEmployeePayrollDeduction", connection)
                .AddInParameter("@_Id", _Id);
        }

        public async Task<EmployeePayrollDeduction> FromReaderAsync(DbDataReader reader)
        {
            return new EmployeePayrollDeduction
            {
                Id = _Id,
                Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
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
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReaderAsync);
        }
    }
}
