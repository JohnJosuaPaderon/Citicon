using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class QuotationManager
    {
        public static async Task<IEnumerable<Quotation>> GetForApprovalMetaDataListByProjectAsync(Project project)
        {
            using (var process = new GetForApprovalQuotationMetaDataListByProject(project))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<Quotation> UpdateStatusAsync(Quotation quotation, QuotationStatus quotationStatus)
        {
            using (var process = new UpdateQuotationStatus(quotation, quotationStatus))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Quotation>> GetListForFinalApprovalAsync()
        {
            using (var process = new GetForFinalApprovalQuotationMetaDataList())
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<Quotation> GetByIdAsync(ulong quotationId)
        {
            using (var process = new GetQuotationById(quotationId))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Quotation>> GetListByProjectAsync(Project project)
        {
            if (project != null)
            {
                using (var process = new GetQuotationListByProject(project))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static ExportQuotationResult ExportQuotation(ExportQuotation.QuotationReportTemplate template, string templatesDirectory, Quotation quotation, List<ProjectDesign> projectDesigns, string saveDirectory)
        {
            using (var process = new ExportQuotation(template, templatesDirectory, quotation, projectDesigns, saveDirectory))
            {
                return process.Export();
            }
        }

        public static async Task<uint> GenerateNumberByTypeAsync(QuotationType quotationType)
        {
            using (var process = new GenerateQuotationNumberByType(quotationType))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<Quotation> InsertAsync(MySqlConnection connection, MySqlTransaction transaction, Quotation quotation)
        {
            if (quotation != null)
            {
                using (var process = new InsertQuotation(quotation))
                {
                    quotation = await process.ExecuteAsync(connection, transaction);
                }
            }

            return quotation;
        }

        public static async Task<QuotationTransaction> InsertTransactionAsync(QuotationTransaction quotationTransaction)
        {
            if (quotationTransaction != null)
            {
                using (var process = new InsertQuotationTransaction(quotationTransaction))
                {
                    quotationTransaction = await process.ExecuteAsync();
                }
            }

            return quotationTransaction;
        }

        public static async Task<Quotation> UpdateAsync(Quotation quotation)
        {
            if (quotation != null)
            {
                using (var process = new UpdateQuotation(quotation))
                {
                    quotation = await process.ExecuteAsync();
                }
            }

            return quotation;
        }
    }
}
