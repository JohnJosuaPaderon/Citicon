using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class UpdateQuotationStatus : IDisposable
    {
        #region Constructor
        public UpdateQuotationStatus(Quotation quotation, QuotationStatus quotationStatus)
        {
            Quotation = quotation;
            QuotationStatus = quotationStatus;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        Quotation Quotation { get; }
        QuotationStatus QuotationStatus { get; }
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Execute
        public async Task<Quotation> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
