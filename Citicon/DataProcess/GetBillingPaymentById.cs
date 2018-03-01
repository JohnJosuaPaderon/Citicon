using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetBillingPaymentById : DataProcessBase
    {
        public GetBillingPaymentById(ulong billingPaymentId)
        {
            _BillingPaymentId = billingPaymentId;
        }

        private readonly ulong _BillingPaymentId;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetBillingPaymentById), connection)
                .AddInParameter("@_Id", _BillingPaymentId);
        }

        private BillingPayment FromReader(DbDataReader reader)
        {
            return new BillingPayment
            {
                AckNumber = reader.GetString("AckNumber"),
                AmountPaid = reader.GetDecimal("AmountPaid"),
                Bank = reader.GetString("Bank"),
                ChequeDate = reader.GetDateTime("ChequeDate"),
                Billings = null,
                ChequeNumber = reader.GetString("ChequeNumber"),
                CrNumber = reader.GetString("CrNumber"),
                Ewt = reader.GetNullableDecimal("Ewt"),
                Id = _BillingPaymentId,
                OrNumber = reader.GetString("OrNumber"),
                PaymentDate = reader.GetDateTime("PaymentDate"),
                PaymentType = BillingPaymentTypeParser.Parse(reader.GetString("PaymentType")),
                PrNumber = reader.GetString("PrNumber"),
                VatIncluded = reader.GetBoolean("VatIncluded"),
                VatLess = reader.GetNullableDecimal("VatLess")
            };
        }

        public Task<BillingPayment> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
