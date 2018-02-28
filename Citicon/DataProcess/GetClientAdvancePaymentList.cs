using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetClientAdvancePaymentList : DataProcessBase
    {
        public GetClientAdvancePaymentList(Client client)
        {
            _Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private readonly Client _Client;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetClientAdvancePaymentList), connection)
                .AddInParameter("@_ClientId", _Client.Id);
        }

        private ClientAdvancePayment FromReader(DbDataReader reader)
        {
            return new ClientAdvancePayment(_Client)
            {
                Id = reader.GetUInt64("Id"),
                AddedValue = reader.GetDecimal("AddedValue"),
                TransactionDate = reader.GetDateTime("TransactionDate")
            };
        }

        public Task<IEnumerable<ClientAdvancePayment>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }
    }
}
