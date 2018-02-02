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
                .AddInParameter("@_SssEr", _EmployeeDeduction.SssEr)
                .AddInParameter("@_SssEc", _EmployeeDeduction.SssEc)
                .AddInParameter("@_Pagibig", _EmployeeDeduction.Pagibig)
                .AddInParameter("@_PhilHealth", _EmployeeDeduction.PhilHealth);
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
