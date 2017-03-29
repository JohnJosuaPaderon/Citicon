using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertQuotationTransaction : DataProcessBase
    {
        public InsertQuotationTransaction(QuotationTransaction quotationTransaction)
        {
            QuotationTransaction = quotationTransaction ?? throw new ArgumentNullException(nameof(quotationTransaction));
        }

        private QuotationTransaction QuotationTransaction;

        public override void Dispose()
        {
            QuotationTransaction = null;
            base.Dispose();
        }

        public async Task<QuotationTransaction> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            var quotation = await QuotationManager.InsertAsync(connection, transaction, QuotationTransaction.Quotation);
            var result = new QuotationTransaction(quotation);

            if (quotation != null)
            {
                foreach (var projectDesign in QuotationTransaction.Designs)
                {
                    projectDesign.Project = quotation.Project;
                    projectDesign.Quotation = quotation;
                    var temp = await ProjectDesignManager.InsertAsync(projectDesign, connection, transaction);

                    if (temp != null)
                    {
                        result.Designs.Add(temp);
                    }
                }
            }

            return result;
        }

        public Task<QuotationTransaction> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
