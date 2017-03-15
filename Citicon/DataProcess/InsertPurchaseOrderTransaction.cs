using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertPurchaseOrderTransaction : DataProcess
    {
        public InsertPurchaseOrderTransaction(PurchaseOrderTransaction purchaseOrderTransaction)
        {
            PurchaseOrderTransaction = purchaseOrderTransaction ?? throw new ArgumentNullException(nameof(purchaseOrderTransaction));
        }

        private PurchaseOrderTransaction PurchaseOrderTransaction;

        public async Task<PurchaseOrderTransaction> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            PurchaseOrderTransaction.PurchaseOrder = await PurchaseOrderManager.InsertAsync(PurchaseOrderTransaction.PurchaseOrder, connection, transaction);

            if (PurchaseOrderTransaction.PurchaseOrder != null)
            {
                for (int i = 0; i < PurchaseOrderTransaction.PurchaseOrderProjectDesigns.Count; i++)
                {
                    var purchaseOrderProjectDesign = PurchaseOrderTransaction.PurchaseOrderProjectDesigns[i];
                    purchaseOrderProjectDesign.PurchaseOrder = PurchaseOrderTransaction.PurchaseOrder;

                    purchaseOrderProjectDesign = await PurchaseOrderProjectDesignManager.InsertAsync(purchaseOrderProjectDesign);
                }
            }

            return PurchaseOrderTransaction;
        }

        public Task<PurchaseOrderTransaction> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
