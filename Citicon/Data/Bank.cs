namespace Citicon.Data
{
    public sealed class Bank
    {
        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public static bool operator ==(Bank left, Bank right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Bank left, Bank right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as Bank;
            return Id.Equals(value.Id);
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
