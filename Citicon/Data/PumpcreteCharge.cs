namespace Citicon.Data
{
    public sealed class PumpcreteCharge : EntityBase<ulong>
    {
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
    }
}
