using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal abstract class SavePayroll<TPayroll> : DataProcessBase
        where TPayroll : PayrollBase
    {
        public SavePayroll(TPayroll payroll)
        {
            _Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
        }

        protected readonly TPayroll _Payroll;

        protected virtual MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand("SavePayroll", connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_TypeId", _Payroll.Type?.Id)
                .AddInParameter("@_BranchId", _Payroll.Branch?.Id)
                .AddInParameter("@_CutOffBegin", _Payroll.CutOff.Begin)
                .AddInParameter("@_CutOffEnd", _Payroll.CutOff.End)
                .AddInParameter("@_RunDate", _Payroll.RunDate);
        }

        protected virtual TPayroll Callback(int affectedRows, MySqlCommand command)
        {
            if (affectedRows > 0)
            {
                _Payroll.Id = command.Parameters.GetUInt64("@_Id");
                return _Payroll;
            }
            else
            {
                return null;
            }
        }

        public virtual Task<TPayroll> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            return ProcessUtility.HandleExecuteAsync(connection, transaction, CreateCommand, Callback);
        }
    }
}
