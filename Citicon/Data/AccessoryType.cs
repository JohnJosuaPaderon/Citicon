namespace Citicon.Data
{
    public sealed class AccessoryType
    {
        public ulong Id { get; set; }
        public string Value { get; set; }

        public static bool operator ==(AccessoryType left, AccessoryType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccessoryType left, AccessoryType right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as AccessoryType;
            return Id.Equals(value.Id);
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
