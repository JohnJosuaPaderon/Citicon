namespace Citicon.Data
{
    public sealed class PumpcreteCharge
    {
        public ulong Id { get; set; }
        public PumpType PumpType { get; set; }
        public Billing Billing { get; set; }
        public PumpSize PumpSize { get; set; }
        public decimal PricePerSetup { get; set; }
        public OperationTimeFrame OperationTimeFrame { get; set; }
        public decimal TotalVolumePumped { get; set; }
        public decimal PricePerCubicMeter { get; set; }
        public string Remarks { get; set; }
        public decimal TotalAmount
        {
            get
            {
                if (TotalVolumePumped <= 50)
                {
                    return PricePerSetup;
                }

                return TotalVolumePumped * PricePerCubicMeter;
            }
        }

        public static bool operator ==(PumpcreteCharge left, PumpcreteCharge right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(PumpcreteCharge left, PumpcreteCharge right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is PumpcreteCharge)
            {
                return (PumpcreteCharge)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
