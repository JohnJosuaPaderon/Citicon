using Citicon.Data;
using Citicon.DataProcess;
using Citicon.DataProcess.ProjectProcesses;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class ProjectManager
    {
        private static List<Project> Projects;

        static ProjectManager()
        {
            Projects = new List<Project>();
        }

        private static void ManageProject(Project project)
        {
            if (!Projects.Contains(project))
            {
                Projects.Add(project);
            }
            else
            {
                var index = Projects.IndexOf(project);
                Projects[index] = project;
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
                Type = reader.GetString("Type")
            };
        }

        public static async Task<Project> GetByIdAsync(ulong projectId)
        {
            foreach (var item in Projects)
            {
                if (item.Id == projectId)
                {
                    return item;
                }
            }

            using (var getProjectById = new GetProjectById(projectId))
            {
                var project = await getProjectById.GetAsync();
                ManageProject(project);
                return project;
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
            using (var getProjectListWithoutBillingSiNumberByClient = new GetProjectListWithoutBIllingSiNumberByClient(client))
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
    }
}
