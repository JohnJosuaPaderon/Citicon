using System;
using System.Configuration;

namespace Citicon.Data
{
    public sealed class Payable
    {
        public ulong Id { get; set; }
        public Stock Stock { get; set; }
        public Expense Expense { get; set; }
        public bool VariableCost { get; set; }
        public string Description { get; set; }
        public Supplier Supplier { get; set; }
        public Branch Branch { get; set; }
        public Company Company { get; set; }
        public DateTime SalaryPeriodStart { get; set; }
        public DateTime SalaryPeriodEnd { get; set; }
        public BankAccount BankAccount { get; set; }
        public string ChequeVoucherNumber { get; set; }
        public string ChequeNumber { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Remarks { get; set; }
        public DateTime TransactionDate { get; set; }
        public string AccountType { get; set; }
        public DateTime ChequeDate { get; set; }
        public decimal Value
        {
            get { return Credit != 0 ? Credit : Debit; }
        }

        public static string InputTax => ConfigurationManager.AppSettings["Payable.Description.InputTax"];

        public static bool operator ==(Payable left, Payable right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Payable left, Payable right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Payable)
            {
                return (Payable)arg == this;
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
