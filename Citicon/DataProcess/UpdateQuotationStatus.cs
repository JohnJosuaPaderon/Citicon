using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class UpdateQuotationStatus : DataProcessBase
    {
        public UpdateQuotationStatus(Quotation quotation, QuotationStatus quotationStatus)
        {
            Quotation = quotation;
            QuotationStatus = quotationStatus;
        }

        Quotation Quotation { get; }
        QuotationStatus QuotationStatus { get; }

        public async Task<Quotation> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    using (var command = new MySqlCommand("UpdateQuotationStatus", connection, transaction))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_QuotationId", Quotation.Id);
                        command.Parameters.AddWithValue("@_QuotationStatus", QuotationStatus.ToString());

                        try
                        {
                            await command.ExecuteNonQueryAsync();
                            transaction.Commit();
                            Quotation.Status = QuotationStatus;
                            return Quotation;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        }
    }
}
