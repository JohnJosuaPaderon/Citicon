namespace Citicon.Data
{
    public class OtherCharge
    {
        public ulong Id { get; set; }
        public Billing Billing { get; set; }
        public OtherChargeType Type { get; set; }
        public decimal Amount { get; set; }
        public decimal Unit { get; set; }
        public string Remarks { get; set; }
        public decimal TotalAmount
        {
            get
            {
                return Amount * Unit;
            }
        }

        public static bool operator ==(OtherCharge left, OtherCharge right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(OtherCharge left, OtherCharge right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is OtherCharge)
            {
                return (OtherCharge)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
