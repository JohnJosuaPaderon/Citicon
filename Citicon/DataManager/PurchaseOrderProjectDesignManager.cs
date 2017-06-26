using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
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

        public static Task<IEnumerable<PurchaseOrderProjectDesign>> GetListByPurchaseOrderAsync(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder != null)
            {
                using (var process = new GetPurchaseOrderProjectDesignListByPurchaseOrder(purchaseOrder))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
