using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class CancelCheque : DataProcessBase
    {
        public CancelCheque(VoidCheque voidCheque)
        {
            _VoidCheque = voidCheque;
        }

        private readonly VoidCheque _VoidCheque;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(CancelCheque), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_ChequeNumber", _VoidCheque.ChequeNumber)
                .AddInParameter("@_VoidDate", DateTime.Now)
                .AddInParameter("@_VoidBy", User.CurrentUser?.Id)
                .AddInParameter("@_BankAccountId", _VoidCheque.BankAccount?.Id)
                .AddInParameter("@_Remarks", _VoidCheque.Remarks);
        }
        
        public async Task<VoidCheque> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                var affectedRows = await command.ExecuteNonQueryAsync();

                if (affectedRows > 0)
                {
                    _VoidCheque.Id = command.Parameters.GetUInt64("@_Id");
                    return _VoidCheque;
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<VoidCheque> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
