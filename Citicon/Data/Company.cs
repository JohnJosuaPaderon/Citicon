namespace Citicon.Data
{
    public sealed class Company
    {
        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public static bool operator ==(Company left, Company right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Company left, Company right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Company)
            {
                return (Company)arg == this;
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
