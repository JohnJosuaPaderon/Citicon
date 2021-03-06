﻿using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System;
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

        public static async Task<IEnumerable<ProjectDesign>> GetListByProjectWithCancellableDeliveryAsync(Project project)
        {
            if (project != null)
            {
                using (var process = new GetProjectDesignListByProjectWithCancellableDelivery(project))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
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

        public static async Task<ProjectDesign> InsertAsync(ProjectDesign projectDesign, bool includeToRevisedQuotation = false)
        {
            using (var process = new InsertProjectDesign(projectDesign, includeToRevisedQuotation))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<ProjectDesign> InsertAsync(ProjectDesign projectDesign, MySqlConnection connection, MySqlTransaction transaction, bool includeToRevisedQuotation = false)
        {
            if (projectDesign != null)
            {
                using (var process = new InsertProjectDesign(projectDesign, includeToRevisedQuotation))
                {
                    projectDesign = await process.ExecuteAsync(connection, transaction);
                }
            }

            return projectDesign;
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

        public static async Task<IEnumerable<ProjectDesign>> GetListByQuotationAsync(Quotation quotation)
        {
            if (quotation != null)
            {
                using (var process = new GetProjectDesignListByQuotation(quotation))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static ValidationResult Validate(ProjectDesign projectDesign)
        {
            if (projectDesign != null)
            {
                using (var process = new ValidateProjectDesign(projectDesign))
                {
                    return process.Execute();
                }
            }
            else
            {
                return new ValidationResult(false, "Invalid design.");
            }
        }

        public static async Task<bool> AlreadyDeliveredAsync(ProjectDesign projectDesign)
        {
            if (projectDesign != null)
            {
                using (var process = new ProjectDesignAlreadyDelivered(projectDesign))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return false;
            }
        }

        public static async Task<ProjectDesign> DeleteAsync(ProjectDesign projectDesign, bool includeToRevisedQuotation = false)
        {
            if (projectDesign != null)
            {
                using (var process = new DeleteProjectDesign(projectDesign, includeToRevisedQuotation))
                {
                    projectDesign = await process.ExecuteAsync();
                }
            }

            return projectDesign;
        }

        public static async Task<ProjectDesign> UpdateAsync(ProjectDesign projectDesign, bool includeToRevisedQuotation = false)
        {
            if (projectDesign != null)
            {
                using (var process = new UpdateProjectDesign(projectDesign, includeToRevisedQuotation))
                {
                    projectDesign = await process.ExecuteAsync();
                }
            }

            return projectDesign;
        }

        public static async Task<IEnumerable<ProjectDesign>> GetListByProjectAndDeliveryDateAsync(Project project, DateTime deliveryDate)
        {
            if (project != null)
            {
                using (var process = new GetProjectDesignListByProjectAndDeliveryDate(project, deliveryDate))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<ProjectDesign>> GetListWithDeliveryAsync(DateTime deliveryDate)
        {
            using (var process = new GetProjectDesignListWithDelivery(deliveryDate))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<decimal> GetConsumedVolumeAsync(ProjectDesign projectDesign)
        {
            if (projectDesign != null)
            {
                using (var process = new GetConsumedProjectDesignVolume(projectDesign))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
