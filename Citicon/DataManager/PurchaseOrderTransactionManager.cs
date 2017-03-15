using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PurchaseOrderTransactionManager
    {
        public static async Task<PurchaseOrderTransaction> InsertAsync(PurchaseOrderTransaction purchaseOrderTransaction)
        {
            if (purchaseOrderTransaction != null)
            {
                using (var process = new InsertPurchaseOrderTransaction(purchaseOrderTransaction))
                {
                    purchaseOrderTransaction = await process.ExecuteAsync();
                }
            }

            return purchaseOrderTransaction;
        }
    }
}
