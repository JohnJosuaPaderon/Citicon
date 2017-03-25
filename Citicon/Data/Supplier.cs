namespace Citicon.Data
{
    public sealed class Supplier
    {
        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public static bool operator ==(Supplier left, Supplier right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Supplier left, Supplier right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Supplier)
            {
                return (Supplier)arg == this;
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
