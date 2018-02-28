using Citicon.Data;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class ClientManager
    {
        private static Dictionary<ulong, Client> Clients = new Dictionary<ulong, Client>();

        private static void ManageItem(Client client)
        {
            if (client != null)
            {
                if (Clients.ContainsKey(client.Id))
                {
                    Clients[client.Id] = client;
                }
                else
                {
                    Clients.Add(client.Id, client);
                }
            }
        }

        public static async Task<decimal> GetCreditAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new GetClientCredit(client))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return 0;
            }
        }

        public static Task<IEnumerable<Client>> GetListWithCementSuppliedProjectAsync()
        {
            using (var process = new GetClientListWithCementSuppliedProject())
            {
                return process.ExecuteAsync();
            }
        }

        public static async Task<Client> GetByIdAsync(ulong clientId)
        {
            if (Clients.ContainsKey(clientId))
            {
                return Clients[clientId];
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

        public static async Task<IEnumerable<Client>> SearchAsync(string searchKey)
        {
            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                using (var process = new SearchClient(searchKey))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<ClientAdvancePayment> SaveAsync(ClientAdvancePayment advancePayment)
        {
            if (advancePayment != null)
            {
                using (var process = new SaveClientAdvancePayment(advancePayment))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<ClientAdvancePayment>> GetAdvancePaymentsAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new GetClientAdvancePaymentList(client))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
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

        public static Task<IEnumerable<Client>> GetListWithScheduledProjectDesignAsync(DateTime scheduledDate, ScheduledProjectDesignStatus status)
        {
            if (scheduledDate != default(DateTime) && status != null)
            {
                using (var process = new GetClientListWithScheduledProjectDesign(scheduledDate, status))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
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

        public static async Task<Client> InsertAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new InsertClient(client))
                {
                    client = await process.ExecuteAsync();
                    ManageItem(client);
                }
            }

            return client;
        }

        public static async Task<Client> UpdateAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new UpdateClient(client))
                {
                    client = await process.ExecuteAsync();
                    ManageItem(client);
                }
            }

            return client;
        }

        public static async Task<Client> DeleteAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new DeleteClient(client))
                {
                    client = await process.ExecuteAsync();

                    if (client != null)
                    {
                        Clients.Remove(client.Id);
                    }
                }
            }

            return client;
        }

        public static ValidationResult Validate(Client client)
        {
            if (client != null)
            {
                using (var process = new ValidateClient(client))
                {
                    return process.Execute();
                }
            }
            else
            {
                return new ValidationResult(false, "Invalid client.");
            }
        }
    }
}
