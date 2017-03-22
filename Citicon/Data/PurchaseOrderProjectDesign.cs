namespace Citicon.Data
{
    public class PurchaseOrderProjectDesign
    {
        public PurchaseOrder PurchaseOrder { get; set; }
        public ProjectDesign ProjectDesign { get; set; }
        public decimal MaxVolume { get; set; }
        public decimal ConsumedVolume { get; set; }
        public decimal Balance
        {
            get { return MaxVolume - ConsumedVolume; }
        }

        public static bool operator ==(PurchaseOrderProjectDesign left, PurchaseOrderProjectDesign right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.PurchaseOrder == right.PurchaseOrder && left.ProjectDesign == right.ProjectDesign;
        }

        public static bool operator !=(PurchaseOrderProjectDesign left, PurchaseOrderProjectDesign right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is PurchaseOrderProjectDesign)
            {
                return (PurchaseOrderProjectDesign)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return PurchaseOrder.GetHashCode() ^ ProjectDesign.GetHashCode();
        }
    }
}
