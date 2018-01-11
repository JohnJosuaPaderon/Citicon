namespace Citicon.Data
{
    public class OtherCharge : EntityBase<ulong>
    {
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
    }
}
