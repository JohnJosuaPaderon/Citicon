using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PurchaseOrderProjectDesignManager
    {
        public static async Task<PurchaseOrderProjectDesign> InsertAsync(PurchaseOrderProjectDesign purchaseOrderProjectDesign, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (purchaseOrderProjectDesign != null)
            {
                using (var process = new InsertPurchaseOrderProjectDesign(purchaseOrderProjectDesign))
                {
                    purchaseOrderProjectDesign = await process.ExecuteAsync();
                }
            }

            return purchaseOrderProjectDesign;
        }

        public static async Task<PurchaseOrderProjectDesign> InsertAsync(PurchaseOrderProjectDesign purchaseOrderProjectDesign)
        {
            if (purchaseOrderProjectDesign != null)
            {
                using (var process = new InsertPurchaseOrderProjectDesign(purchaseOrderProjectDesign))
                {
                    purchaseOrderProjectDesign = await process.ExecuteAsync();
                }
            }

            return purchaseOrderProjectDesign;
        }

        public static async Task<PurchaseOrderProjectDesign> GetAvailableAsync(ProjectDesign projectDesign)
        {
            if (projectDesign != null)
            {
                using (var process = new GetAvailablePurchaseOrderProjectDesign(projectDesign))
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
