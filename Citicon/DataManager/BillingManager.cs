using Citicon.Data;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class BillingManager
    {
        public static async Task<IEnumerable<Billing>> GetListWithoutSiNumberByProjectAsync(Project project)
        {
            using (var getBillingListWithoutSiNumber = new GetBillingListWithoutSiNumberByProject(project))
            {
                return await getBillingListWithoutSiNumber.GetAsync();
            }
        }

        public static async Task SaveSiNumberAsync(string siNumber, IEnumerable<Billing> billings)
        {
            using (var saveBillingSiNumber = new SaveBillingSiNumber(siNumber, billings))
            {
                await saveBillingSiNumber.ExecuteAsync();
            }
        }

        public static async Task<Billing> InsertBillingAsync(Billing billing)
        {
            using (var process = new InsertBilling(billing))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<IEnumerable<Billing>> GetUnpaidListBySalesInvoiceAsync(SalesInvoice salesInvoice)
        {
            using (var getUnpaidBillingListBySalesInvoice = new GetUnpaidBillingListBySalesInvoice(salesInvoice))
            {
                return await getUnpaidBillingListBySalesInvoice.ExecuteAsync();
            }
        }

        public static void Export(Billing billing, Action onExported, Action<string> onError)
        {
            using (var process = new ExportBilling(billing, onExported, onError))
            {
                process.Export();
            }
        }

        public static async Task<IEnumerable<Billing>> GetListByClientAsync(Client client)
        {
            if (client != null)
            {
                using (var process = new GetBillingsByClient(client))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<IEnumerable<BillingPaymentHistory>> GetPaymentHistoryAsync(Billing billing)
        {
            if (billing != null)
            {
                using (var process = new GetBillingPaymentHistory(billing))
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
