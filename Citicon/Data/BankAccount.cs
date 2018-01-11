namespace Citicon.Data
{
    public sealed class BankAccount : EntityBase<ulong>
    {
        public Bank Bank { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ulong ChequeNumberStart { get; set; }
        public ulong ChequeNumberEnd { get; set; }
        public ulong ChequeNumber { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
