using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetUnpaidBillingListBySalesInvoice : DataProcessBase
    {
        private SalesInvoice SalesInvoice;

        public GetUnpaidBillingListBySalesInvoice(SalesInvoice salesInvoice)
        {
            SalesInvoice = salesInvoice;
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetUnpaidBillingListBySalesInvoiceNumber", connection);
            command.Parameters.AddWithValue("@_SalesInvoiceNumber", SalesInvoice.Number);

            return command;
        }

        public override void Dispose()
        {
            SalesInvoice = null;
            base.Dispose();
        }

        public Task<IEnumerable<Billing>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private Billing FromReader(DbDataReader reader)
        {
            return new Billing
            {
                Id = reader.GetUInt64("Id"),
                AmountDue = reader.GetDecimal("AmountDue"),
                BillingNo = reader.GetString("BillingNumber"),
                AmountPaid = reader.GetDecimal("AmountPaid"),
                SiNumber = SalesInvoice.Number,
                Volume = reader.GetDecimal("Volume")
            };
        }
    }
}
