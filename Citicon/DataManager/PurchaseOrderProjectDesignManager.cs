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
    }
}
