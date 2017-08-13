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
            return Equals(left, right);
        }

        public static bool operator !=(BankAccount left, BankAccount right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as BankAccount;
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
