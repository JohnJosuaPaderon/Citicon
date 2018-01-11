namespace Citicon.Data
{
    public sealed class PurchaseOrder : EntityBase<ulong>
    {
        public Project Project { get; set; }
        public string Number { get; set; }
        public decimal RunningBalance { get; set; }
        public decimal MaximumCumulativePricePerCubicMeter { get; set; }
        public User Creator { get; set; }
        public User Verifier { get; set; }
        public bool WarningLevelReached
        {
            get
            {
                return (MaximumCumulativePricePerCubicMeter * 0.25M) >= RunningBalance;
            }
        }
        
        public override string ToString()
        {
            return Number;
        }
    }
}
