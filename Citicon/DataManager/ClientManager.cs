using Citicon.Data;
using Citicon.DataProcess;
using Citicon.DataProcess.ClientProcesses;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class ClientManager
    {
        private static List<Client> Clients = new List<Client>();

        private static void ManageItem(Client client)
        {
            if (Clients.Contains(client))
            {
                var index = Clients.IndexOf(client);
                Clients[index] = client;
            }
            else
            {
                Clients.Add(client);
            }
        }

        public static async Task<Client> GetByIdAsync(ulong clientId)
        {
            foreach (var item in Clients)
            {
                if (item.Id == clientId)
                {
                    return item;
                }
            }

            using (var getClientById = new GetClientById(clientId))
            {
                var client = await getClientById.GetAsync();
                ManageItem(client);
                return client;
            }
        }

        internal static async Task<Client> GetFromDbDataReader(DbDataReader reader)
        {
            return new Client
            {
                Address = reader.GetString("Address"),
                CompanyName = reader.GetString("CompanyName"),
                ContactNumber = reader.GetString("ContactNumber"),
                Designation = reader.GetString("Designation"),
                EmailAddress = reader.GetString("EmailAddress"),
                Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
                FirstName = reader.GetString("FirstName"),
                Id = reader.GetUInt64("Id"),
                LastName = reader.GetString("LastName"),
                MiddleName = reader.GetString("MiddleName"),
                PhotoPath = reader.GetString("PhotoPath"),
                Position = reader.GetString("Position"),
                PresidentMobileNumber = reader.GetString("PresidentMobileNumber"),
                PresidentName = reader.GetString("PresidentName"),
                PresidentTelephoneNumber = reader.GetString("PresidentTelephoneNumber"),
                Tin = reader.GetString("Tin"),
                Title = reader.GetString("Title"),
                Legitimate = reader.GetBoolean("Legitimate")
            };
        }

        public static async Task<IEnumerable<Client>> GetListAsync()
        {
            using (var getClientList = new GetClientList())
            {
                var clients = await getClientList.GetAsync();
                //if (clients != null)
                //{
                //    foreach (var item in clients)
                //    {
                //        ManageItem(item);
                //    }
                //}
                return clients;
            }
        }

        public static async Task<IEnumerable<Client>> GetListWithUnbilledDeliveryAsync()
        {
            using (var process = new GetClientListWithUnbilledDelivery())
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Client>> GetMetaDataListWithQuotationForApprovalAsync()
        {
            using (var process = new GetClientMetaDataListWithQuotationForApproval())
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Client>> GetListWithoutBillingSiNumberAsync()
        {
            using (var getClientListWithoutBillingSiNumber = new GetClientListWithoutBillingSiNumber())
            {
                var clients = await getClientListWithoutBillingSiNumber.GetAsync();
                if (clients != null)
                {
                    foreach (var item in clients)
                    {
                        ManageItem(item);
                    }
                }
                return clients;
            }
        }

        public static async Task<IEnumerable<Client>> GetListWithUnpaidBillingSiNumberAsync()
        {
            using (var getClientListWithUnpaidBillingSiNumber = new GetClientListWithUnpaidBillingSiNumber())
            {
                var clients = await getClientListWithUnpaidBillingSiNumber.GetAsync();
                if (clients != null)
                {
                    foreach (var item in clients)
                    {
                        ManageItem(item);
                    }
                }
                return clients;
            }
        }

        public static async Task<IEnumerable<Client>> GetTallySheetClientListByDeliveryDateAsync(DateTime deliveryDate)
        {
            using (var getTallySheetClientListByDeliveryDate = new GetTallySheetClientListByDeliveryDate(deliveryDate))
            {
                var clients = await getTallySheetClientListByDeliveryDate.GetAsync();
                if (clients != null)
                {
                    foreach (var item in clients)
                    {
                        ManageItem(item);
                    }
                }
                return clients;
            }
        }

        public static async Task<IEnumerable<Client>> GetLegitimateListAsync()
        {
            using (var process = new GetLegitimateClientList())
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<List<Client>> GetListWithProjectDesignNoPurchaseOrderAsync()
        {
            using (var process = new GetClientListWithProjectDesignNoPurchaseOrder())
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Client>> GetListWithApprovedProjectDesignAsync()
        {
            using (var process = new GetClientListWithApprovedProjectDesign())
            {
                return await process.ExecuteAsync();
            }
        }
    }
}
