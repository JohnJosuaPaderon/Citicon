using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetBillingsByClient : DataProcessBase
    {
        public GetBillingsByClient(Client client)
        {
            _Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private readonly Client _Client;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetBillingsByClient), connection)
                .AddInParameter("@_ClientId", _Client.Id);
        }

        private Billing FromReader(DbDataReader reader)
        {
            return new Billing
            {
                AmountDue = reader.GetDecimal("AmountDue"),
                AmountPaid = reader.GetDecimal("AmountPaid"),
                BillingDate = reader.GetDateTime("BillingDate"),
                BillingNo = reader.GetString("BillingNumber"),
                Id = reader.GetUInt64("Id"),
                SiNumber = reader.GetString("SiNumber")
            };
        }

        public Task<IEnumerable<Billing>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }
    }
}
