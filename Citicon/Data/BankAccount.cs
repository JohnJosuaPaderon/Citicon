namespace Citicon.Data
{
    public sealed class BankAccount
    {
        public ulong Id { get; set; }
        public Bank Bank { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ulong ChequeNumberStart { get; set; }
        public ulong ChequeNumberEnd { get; set; }
        public ulong ChequeNumber { get; set; }


        public static bool operator ==(BankAccount left, BankAccount right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(BankAccount left, BankAccount right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is BankAccount)
            {
                return (BankAccount)arg == this;
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
