namespace Citicon.Data
{
    public sealed class Item : EntityBase<ulong>
    {
        public Classification Classification { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal StockValue { get; set; }
        public bool CementSupplied { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
