using Citicon.Data;
using Citicon.DataProcess;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PurchaseOrderManager
    {
        static PurchaseOrderManager()
        {
            PurchaseOrderList = new List<PurchaseOrder>();
        }

        private static List<PurchaseOrder> PurchaseOrderList { get; }

        private static PurchaseOrder Manage(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder != null)
            {
                if (PurchaseOrderList.Contains(purchaseOrder))
                {
                    var index = PurchaseOrderList.IndexOf(purchaseOrder);
                    PurchaseOrderList[index] = purchaseOrder;
                }
                else
                {
                    PurchaseOrderList.Add(purchaseOrder);
                }
            }

            return purchaseOrder;
        }

        #region GetById
        public static PurchaseOrder GetById(ulong purchaseOrderId)
        {
            if (purchaseOrderId > 0)
            {
                //var purchaseOrder = PurchaseOrderList.FirstOrDefault(x => x.Id == purchaseOrderId);
                PurchaseOrder purchaseOrder = null;
                //if (purchaseOrder == null)
                //{
                    using (var process = new GetPurchaseOrderById(purchaseOrderId))
                    {
                        purchaseOrder = Manage(process.Execute());
                    }
                //}

                return purchaseOrder;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Insert
        public static PurchaseOrder _Insert(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder != null)
            {
                using (var process = new _InsertPurchaseOrder(purchaseOrder))
                {
                    purchaseOrder = Manage(process.Execute());
                }
            }

            return purchaseOrder;
        }
        #endregion

        public static async Task<bool> NumberExistsAsync(string purchaseOrderNumber)
        {
            if (!string.IsNullOrWhiteSpace(purchaseOrderNumber))
            {
                using (var process = new PurchaseOrderNumberExists(purchaseOrderNumber))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return true;
            }
        }

        public static async Task<PurchaseOrder> InsertAsync(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder != null)
            {
                using (var process = new InsertPurchaseOrder(purchaseOrder))
                {
                    purchaseOrder = await process.ExecuteAsync();
                }
            }

            return purchaseOrder;
        }

        public static async Task<PurchaseOrder> InsertAsync(PurchaseOrder purchaseOrder, MySqlConnection connection, MySqlTransaction transaction)
        {
            if (purchaseOrder != null)
            {
                using (var process = new InsertPurchaseOrder(purchaseOrder))
                {
                    purchaseOrder = await process.ExecuteAsync();
                }
            }

            return purchaseOrder;
        }

        #region GetByNumber
        public static PurchaseOrder GetByNumber(string purchaseOrderNumber)
        {
            if (!string.IsNullOrWhiteSpace(purchaseOrderNumber))
            {
                using (var process = new GetPurchaseOrderByNumber(purchaseOrderNumber))
                {
                    return Manage(process.Execute());
                }
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
