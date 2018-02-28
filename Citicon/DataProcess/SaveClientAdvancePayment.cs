using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SaveClientAdvancePayment : DataProcessBase 
    {
        public SaveClientAdvancePayment(ClientAdvancePayment advancePayment)
        {
            _AdvancePayment = advancePayment ?? throw new ArgumentNullException(nameof(advancePayment));
        }

        private readonly ClientAdvancePayment _AdvancePayment;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(SaveClientAdvancePayment), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_ClientId", _AdvancePayment.Client?.Id)
                .AddInParameter("@_TransactionDate", _AdvancePayment.TransactionDate)
                .AddInParameter("@_AddedValue", _AdvancePayment.AddedValue);
        }

        private ClientAdvancePayment Callback(int affectedRows, MySqlCommand command)
        {
            var id = command.Parameters.GetUInt64("@_Id");

            if (id > 0)
            {
                _AdvancePayment.Id = id;
                return _AdvancePayment;
            }
            else
            {
                return null;
            }
        }

        public Task<ClientAdvancePayment> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(CreateCommand, Callback);
        }
    }
}
