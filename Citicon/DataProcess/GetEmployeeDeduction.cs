using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetEmployeeDeduction : DataProcessBase
    {
        public GetEmployeeDeduction(Employee employee)
        {
            _Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        private readonly Employee _Employee;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetEmployeeDeduction), connection)
                .AddInParameter("@_EmployeeId", _Employee.Id);
        }

        private EmployeeDeduction FromReader(DbDataReader reader)
        {
            return new EmployeeDeduction(_Employee)
            {
                Id = reader.GetUInt64("Id"),
                Sss = reader.GetDecimal("Sss"),
                SssEr = reader.GetDecimal("SssEr"),
                SssEc = reader.GetDecimal("SssEc"),
                Pagibig = reader.GetDecimal("Pagibig"),
                PhilHealth = reader.GetDecimal("PhilHealth"),
                WithholdingTax = reader.GetDecimal("WithholdingTax")
            };
        }

        public Task<EmployeeDeduction> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
