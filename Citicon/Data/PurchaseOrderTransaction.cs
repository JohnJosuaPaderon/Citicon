using System.Collections.Generic;

namespace Citicon.Data
{
    public class PurchaseOrderTransaction
    {
        public PurchaseOrderTransaction()
        {
            PurchaseOrderProjectDesigns = new List<PurchaseOrderProjectDesign>();
        }

        public PurchaseOrder PurchaseOrder { get; set; }
        public List<PurchaseOrderProjectDesign> PurchaseOrderProjectDesigns { get; }
    }
}
