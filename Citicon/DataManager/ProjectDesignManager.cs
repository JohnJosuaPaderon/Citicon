using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class ProjectDesignManager
    {
        static ProjectDesignManager()
        {
            ProjectDesigns = new List<ProjectDesign>();
        }

        private static List<ProjectDesign> ProjectDesigns { get; }

        internal static async Task<ProjectDesign> FromDbDataReader(DbDataReader dataReader)
        {
            return new ProjectDesign()
            {
                Aggregate = ProductAggregateManager.GetById(dataReader.GetInt64("AggregateId")),
                CementFactor = dataReader.GetDecimal("CementFactor"),
                Id = dataReader.GetUInt64("Id"),
                InitialVolume = dataReader.GetDecimal("InitialVolume"),
                MixType = ProjectDesignMixTypeManager.Parse(dataReader.GetString("MixType")),
                PricePerCubicMeter = dataReader.GetDecimal("PricePerCubicMeter"),
                Project = await ProjectManager.GetByIdAsync(dataReader.GetUInt64("ProjectId")),
                Psi = dataReader.GetDecimal("Psi"),
                Strength = ProductStrengthManager.GetById(dataReader.GetInt64("StrengthId")),
                PurchaseOrder = PurchaseOrderManager.GetById(dataReader.GetUInt64("PurchaseOrderId")),
                Quotation = await QuotationManager.GetByIdAsync(dataReader.GetUInt64("QuotationId"))
            };
        }

        public static async Task<ProjectDesign> GetByIdAsync(ulong projectDesignId)
        {
            ProjectDesign tempProjectDesign = null;
            //var tempProjectDesign = ProjectDesigns.FirstOrDefault(projectDesign => projectDesign.Id == projectDesignId);

            //if (tempProjectDesign != null)
            //{
            //    return tempProjectDesign;
            //}

            using (var process = new GetProjectDesignById(projectDesignId))
            {
                tempProjectDesign = await process.ExecuteAsync();
                ProjectDesigns.Add(tempProjectDesign);
                return tempProjectDesign;
            }
        }

        public static async Task<IEnumerable<ProjectDesign>> GetListByProjectAsync(Project project)
        {
            using (var process = new GetProjectDesignListByProject(project))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<ProjectDesign> InsertAsync(ProjectDesign projectDesign)
        {
            using (var process = new InsertProjectDesign(projectDesign))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<ProjectDesign>> GetListForApprovalAsync()
        {
            using (var process = new GetProjectDesignListForApproval())
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<ProjectDesign> ApproveAsync(ProjectDesign projectDesign)
        {
            using (var process = new ApproveProjectDesign(projectDesign))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<List<ProjectDesign>> GetListByPurchaseOrderAsync(PurchaseOrder purchaseOrder)
        {
            using (var process = new GetProjectDesignListByPurchaseOrder(purchaseOrder))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<List<ProjectDesign>> GetListWithNoPurchaseOrderByProjectAsync(Project project)
        {
            if (project != null)
            {
                using (var process = new GetProjectDesignListWithNoPurchaseOrderByProject(project))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<List<ProjectDesign>> SetPurchaseOrderAsync(PurchaseOrder purchaseOrder, List<ProjectDesign> projectDesignList)
        {
            if (purchaseOrder != null && projectDesignList != null && projectDesignList.Count > 0)
            {
                using (var process = new SetProjectDesignPurchaseOrder(purchaseOrder, projectDesignList))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<ProjectDesign>> GetApprovedListByProjectAsync(Project project)
        {
            if (project != null)
            {
                using (var process = new GetApprovedProjectDesignListByProject(project))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
