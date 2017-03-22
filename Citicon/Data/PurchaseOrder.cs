namespace Citicon.Data
{
    public sealed class PurchaseOrder
    {
        public ulong Id { get; set; }
        public Project Project { get; set; }
        public string Number { get; set; }
        public decimal RunningBalance { get; set; }

        public static bool operator ==(PurchaseOrder left, PurchaseOrder right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(PurchaseOrder left, PurchaseOrder right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is PurchaseOrder)
            {
                return (PurchaseOrder)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return Number;
        }
    }
}
