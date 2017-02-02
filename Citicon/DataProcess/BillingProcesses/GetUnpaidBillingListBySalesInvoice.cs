using Citicon.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetUnpaidBillingListBySalesInvoice : IDisposable
    {
        private SalesInvoice SalesInvoice;
        private MySqlConnectionHelper ConnectionHelper;

        public GetUnpaidBillingListBySalesInvoice(SalesInvoice salesInvoice)
        {
            SalesInvoice = salesInvoice;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<Billing>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetUnpaidBillingListBySalesInvoiceNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_SalesInvoiceNumber", SalesInvoice.Number);
                    List<Billing> billings = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                billings = new List<Billing>();
                                while (await reader.ReadAsync())
                                {
                                    billings.Add(new Billing
                                    {
                                        Id = reader.GetUInt64("Id"),
                                        AmountDue = reader.GetDecimal("AmountDue"),
                                        BillingNo = reader.GetString("BillingNumber"),
                                        AmountPaid = reader.GetDecimal("AmountPaid"),
                                        SiNumber = SalesInvoice.Number,
                                        Volume = reader.GetDecimal("Volume")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        billings = null;
                        throw;
                    }
                    return billings;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
