using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveEmployeeAddition : DataProcessBase
    {
        public SaveEmployeeAddition(EmployeeAddition employeeAddition)
        {
            _EmployeeAddition = employeeAddition ?? throw new ArgumentNullException(nameof(employeeAddition));
        }

        private readonly EmployeeAddition _EmployeeAddition;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(SaveEmployeeAddition), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_EmployeeId", _EmployeeAddition.Employee?.Id)
                .AddInParameter("@_DailyRate", _EmployeeAddition.DailyRate)
                .AddInParameter("@_BasicPay", _EmployeeAddition.BasicPay)
                .AddInParameter("@_Allowance", _EmployeeAddition.Allowance)
                .AddInParameter("@_OvertimeAllowance", _EmployeeAddition.OvertimeAllowance)
                .AddInParameter("@_ShopRate", _EmployeeAddition.ShopRate);
        }

        private EmployeeAddition Callback(int affectedRows, MySqlCommand command)
        {
            if (affectedRows > 0)
            {
                _EmployeeAddition.Id = command.Parameters.GetUInt64("@_Id");
                return _EmployeeAddition;
            }
            else
            {
                return null;
            }
        }

        public Task<EmployeeAddition> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            return ProcessUtility.HandleExecuteAsync(connection, transaction, CreateCommand, Callback);
        }
    }
}
