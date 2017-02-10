using Citicon.Data;
using Citicon.DataProcess.QuotationProcesses;
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

        public static ExportQuotationResult ExportQuotation(ExportQuotation.QuotationReportTemplate template, string templatesDirectory, Quotation quotation, List<ProjectDesign> projectDesigns, string saveDirectory)
        {
            using (var process = new ExportQuotation(template, templatesDirectory, quotation, projectDesigns, saveDirectory))
            {
                return process.Export();
            }
        }
    }
}
