namespace Citicon.Data
{
    public sealed class ExcessPipeCharge
    {
        public ulong Id { get; set; }
        public Billing Billing { get; set; }
        public AccessoryType AccessoryType { get; set; }
        public OperationTimeFrame OperationTimeFrame { get; set; }
        public uint MaximumCount { get; set; }
        public decimal ChargePerCubicMeter { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount
        {
            get
            {
                return ChargePerCubicMeter * Amount;
            }
        }

        public static bool operator ==(ExcessPipeCharge left, ExcessPipeCharge right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(ExcessPipeCharge left, ExcessPipeCharge right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is ExcessPipeCharge)
            {
                return (ExcessPipeCharge)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
