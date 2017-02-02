using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Linq;

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
                var purchaseOrder = PurchaseOrderList.FirstOrDefault(x => x.Id == purchaseOrderId);

                if (purchaseOrder == null)
                {
                    using (var process = new GetPurchaseOrderById(purchaseOrderId))
                    {
                        purchaseOrder = Manage(process.Execute());
                    }
                }

                return purchaseOrder;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Insert
        public static PurchaseOrder Insert(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder != null)
            {
                using (var process = new InsertPurchaseOrder(purchaseOrder))
                {
                    purchaseOrder = Manage(process.Execute());
                }
            }

            return purchaseOrder;
        }
        #endregion

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
