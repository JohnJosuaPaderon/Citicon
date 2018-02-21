using Citicon.Data;
using Citicon.Data.Converters;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class ProjectManager
    {
        private static Dictionary<ulong, Project> Projects;

        static ProjectManager()
        {
            Projects = new Dictionary<ulong, Project>();
        }

        private static void ManageProject(Project project)
        {
            if (project != null)
            {
                if (!Projects.ContainsKey(project.Id))
                {
                    Projects.Add(project.Id, project);
                }
                else
                {
                    Projects[project.Id] = project;
                }
            }
        }

        public static async Task<IEnumerable<Project>> SearchWithCancellableDeliveryAsync(string searchKey, SearchProjectOption option)
        {
            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                using (var process = new SearchProjectWithCancellableDelivery(searchKey, option))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        internal static async Task<Project> FromDbDataReaderAsync(DbDataReader reader)
        {
            return new Project
            {
                Client = await ClientManager.GetByIdAsync(reader.GetUInt64("ClientId")),
                Completed = reader.GetBoolean("Completed"),
                Id = reader.GetUInt64("Id"),
                InitialCement = reader.GetDouble("InitialCement"),
                InitialPayment = reader.GetDecimal("InitialPayment"),
                Location = reader.GetString("Location"),
                Name = reader.GetString("Name"),
                TotalCost = reader.GetDecimal("TotalCost"),
                Type = ProjectTypeConverter.Parse(reader.GetString("Type")),
                QuotationType = QuotationTypeConverter.Parse(reader.GetString("QuotationType"))
            };
        }

        public static async Task<Project> GetByIdAsync(ulong projectId)
        {
            if (Projects.ContainsKey(projectId))
            {
                return Projects[projectId];
            }

            using (var getProjectById = new GetProjectById(projectId))
            {
                var project = await getProjectById.GetAsync();
                ManageProject(project);
                return project;
            }
        }

        public static async Task<IEnumerable<Project>> GetCementSuppliedListByClientAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new GetCementSuppliedProjectListByClient(client))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static Task<IEnumerable<Project>> GetListWithScheduledProjectDesignByClientAsync(Client client, DateTime scheduledDate, ScheduledProjectDesignStatus status)
        {
            if (client != null && scheduledDate != default(DateTime) && status != null)
            {
                using (var process = new GetProjectListWithScheduledProjectDesignByClient(client, scheduledDate, status))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<Project>> GetListByClientAsync(Client client)
        {
            using (var getProjectListByClient = new GetProjectListByClient(client))
            {
                var projects = await getProjectListByClient.GetAsync();
                if (projects != null)
                {
                    foreach (var item in projects)
                    {
                        ManageProject(item);
                    }
                }
                return projects;
            }
        }

        public static async Task<IEnumerable<Project>> GetListWithoutBillingSiNumberByClientAsync(Client client)
        {
            using (var getProjectListWithoutBillingSiNumberByClient = new GetProjectListWithoutBillingSiNumberByClient(client))
            {
                var projects = await getProjectListWithoutBillingSiNumberByClient.GetAsync();
                if (projects != null)
                {
                    foreach (var item in projects)
                    {
                        ManageProject(item);
                    }
                }
                return projects;
            }
        }

        public static Task<IEnumerable<Project>> GetListWithUnbilledDeliveryByClient(Client client)
        {
            using (var process = new GetProjectListWithUnbilledDeliveryByClient(client))
            {
                return process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Project>> GetTallySheetProjectListByClientAndDeliveryDateAsync(Client client, DateTime deliveryDate)
        {
            using (var getTallySheetProjectListByClientAndDeliveryDate = new GetTallySheetProjectListByClientAndDeliveryDate(client, deliveryDate))
            {
                return await getTallySheetProjectListByClientAndDeliveryDate.GetAsync();
            }
        }

        public static async Task<IEnumerable<Project>> SearchApprovedProjectAsync(string searchKey, SearchApprovedProjectPredicate predicate)
        {
            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                using (var process = new SearchApprovedProject(searchKey, predicate))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<Project>> GetListWithUnpaidBillingSiNumberByClientAsync(Client client)
        {
            using (var getProjectListWithUnpaidBillingSiNumberByClient = new GetProjectListWithUnpaidBillingSiNumberByClient(client))
            {
                var projects = await getProjectListWithUnpaidBillingSiNumberByClient.GetAsync();
                if (projects != null)
                {
                    foreach (var item in projects)
                    {
                        ManageProject(item);
                    }
                }
                return projects;
            }
        }

        public static async Task<ProjectBillingInfo> GetBillingInfoAsync(Project project)
        {
            using (var getProjectBillingInfo = new GetProjectBillingInfo(project))
            {
                return await getProjectBillingInfo.GetAsync();
            }
        }

        public static async Task<IEnumerable<Project>> GetListWithQuotationForApprovalByClientAsync(Client client)
        {
            using (var process = new GetProjectListWithQuotationForApprovalByClient(client))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<List<Project>> GetListWithProjectDesignNoPurchaseOrderByClientAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new GetProjectListWithProjectDesignNoPurchaseOrderByClient(client))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<Project>> GetApprovedListAsync()
        {
            using (var process = new GetApprovedProjectList())
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Project>> GetListWithApprovedProjectDesignByClientAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new GetProjectListWithApprovedProjectDesignByClient(client))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<Project> InsertAsync(Project project)
        {
            if (project != null)
            {
                using (var process = new InsertProject(project))
                {
                    project = await process.ExecuteAsync();
                    ManageProject(project);
                }
            }

            return project;
        }

        public static async Task<Project> UpdateAsync(Project project)
        {
            if (project != null)
            {
                using (var process = new UpdateProject(project))
                {
                    project = await process.ExecuteAsync();
                    ManageProject(project);
                }
            }

            return project;
        }

        public static async Task<Project> DeleteAsync(Project project)
        {
            if (project != null)
            {
                using (var process = new DeleteProject(project))
                {
                    project = await process.ExecuteAsync();
                }
            }

            return project;
        }

        public static ValidationResult Validate(Project project)
        {
            if (project != null)
            {
                using (var process = new ValidateProject(project))
                {
                    return process.Execute();
                }
            }
            else
            {
                return new ValidationResult(false, "Invalid project.");
            }
        }
        
        public static async Task<IEnumerable<Project>> GetListByDeliveryDateAsync(DateTime deliveryDate)
        {
            using (var process = new GetProjectListByDeliveryDate(deliveryDate))
            {
                return await process.ExecuteAsync();
            }
        }
    }
}
