namespace Citicon.Data
{
    public sealed class PumpSize
    {
        public ulong Id { get; set; }
        public string Value { get; set; }


        public static bool operator ==(PumpSize left, PumpSize right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(PumpSize left, PumpSize right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is PumpSize)
            {
                return (PumpSize)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
