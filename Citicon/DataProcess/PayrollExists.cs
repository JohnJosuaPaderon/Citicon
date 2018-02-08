using Citicon.Data;
using Citicon.Extensions;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class PayrollExists : DataProcessBase
    {
        public PayrollExists(PayrollBase payroll)
        {
            _Payroll = payroll ?? throw new ArgumentNullException(nameof(payroll));
        }

        private readonly PayrollBase _Payroll;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return new MySqlCommand()
            {
                Connection = connection,
                CommandText = $"SELECT PayrollExists(@_TypeId, @_BranchId, @_CutOffBegin, @_CutOffEnd);"
            }
            .AddInParameter("@_TypeId", _Payroll.Type?.Id)
            .AddInParameter("@_BranchId", _Payroll.Branch?.Id)
            .AddInParameter("@_CutOffBegin", _Payroll.CutOff.Begin)
            .AddInParameter("@_CutOffEnd", _Payroll.CutOff.End);
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, DbValueConverter.ToBoolean);
        }
    }
}
