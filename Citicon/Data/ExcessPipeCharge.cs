namespace Citicon.Data
{
    public sealed class ExcessPipeCharge : EntityBase<ulong>
    {
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
    }
}
