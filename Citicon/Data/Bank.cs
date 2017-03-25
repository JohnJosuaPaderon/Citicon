namespace Citicon.Data
{
    public sealed class Bank
    {
        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }


        public static bool operator ==(Bank left, Bank right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Bank left, Bank right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Bank)
            {
                return (Bank)arg == this;
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
