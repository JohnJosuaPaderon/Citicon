namespace Citicon.Data
{
    public sealed class Item
    {
        public ulong Id { get; set; }
        public Classification Classification { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal StockValue { get; set; }
        public bool CementSupplied { get; set; }

        public static bool operator ==(Item left, Item right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Item left, Item right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Item)
            {
                return (Item)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
