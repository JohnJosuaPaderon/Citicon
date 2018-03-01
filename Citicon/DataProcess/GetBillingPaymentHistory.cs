using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetBillingPaymentHistory : DataProcessBase
    {
        public GetBillingPaymentHistory(Billing billing)
        {
            _Billing = billing ?? throw new ArgumentNullException(nameof(billing));
        }

        private readonly Billing _Billing;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetBillingPaymentHistory), connection)
                .AddInParameter("@_BillingId", _Billing.Id);
        }

        private async Task<BillingPaymentHistory> FromReaderAsync(DbDataReader reader)
        {
            return new BillingPaymentHistory(_Billing, await BillingPaymentManager.GetByIdAsync(reader.GetUInt64("PaymentId")))
            {
                Id = reader.GetUInt64("Id"),
                AmountPaid = reader.GetDecimal("AmountPaid"),
                PaymentDate = reader.GetDateTime("PaymentDate")
            };
        }

        public Task<IEnumerable<BillingPaymentHistory>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
