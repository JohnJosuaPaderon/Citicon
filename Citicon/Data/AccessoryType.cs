namespace Citicon.Data
{
    public sealed class AccessoryType
    {
        public ulong Id { get; set; }
        public string Value { get; set; }

        public static bool operator ==(AccessoryType left, AccessoryType right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(AccessoryType left, AccessoryType right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is AccessoryType)
            {
                return (AccessoryType)arg == this;
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
