using System;

namespace Citicon.Data
{
    public class VoidCheque : EntityBase<ulong>
    {
        public string ChequeNumber { get; set; }
        public BankAccount BankAccount { get; set; }
        public DateTime ChequeDate { get; set; }
        public DateTime VoidDate { get; set; }
        public User VoidBy { get; set; }
        public string Remarks { get; set; }
    }
}
