namespace Citicon.Data
{
    public sealed class PaymentTerm
    {
        public ulong Id { get; set; }
        public string Description { get; set; }
        public uint DayCount { get; set; }

        public static bool operator ==(PaymentTerm left, PaymentTerm right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(PaymentTerm left, PaymentTerm right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is PaymentTerm)
            {
                return (PaymentTerm)arg == this;
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
