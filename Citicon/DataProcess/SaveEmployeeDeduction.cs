using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveEmployeeDeduction : DataProcessBase
    {
        public SaveEmployeeDeduction(EmployeeDeduction employeeDeduction)
        {
            _EmployeeDeduction = employeeDeduction ?? throw new ArgumentNullException(nameof(employeeDeduction));
        }

        private readonly EmployeeDeduction _EmployeeDeduction;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(SaveEmployeeDeduction), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_EmployeeId", _EmployeeDeduction.Employee?.Id)
                .AddInParameter("@_WithholdingTax", _EmployeeDeduction.WithholdingTax)
                .AddInParameter("@_Sss", _EmployeeDeduction.Sss)
                .AddInParameter("@_SssLoan", _EmployeeDeduction.SssLoan)
                .AddInParameter("@_PagibigLoan", _EmployeeDeduction.PagibigLoan);
        }

        private EmployeeDeduction Callback(int affectedRows, MySqlCommand command)
        {
            if (affectedRows > 0)
            {
                _EmployeeDeduction.Id = command.Parameters.GetUInt64("@_Id");
                return _EmployeeDeduction;
            }
            else
            {
                return null;
            }
        }

        public Task<EmployeeDeduction> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            return ProcessUtility.HandleExecuteAsync(connection, transaction, CreateCommand, Callback);
        }
    }
}
