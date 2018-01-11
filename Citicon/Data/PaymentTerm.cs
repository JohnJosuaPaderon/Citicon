namespace Citicon.Data
{
    public sealed class PaymentTerm : EntityBase<ulong>
    {
        public string Description { get; set; }
        public uint DayCount { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
