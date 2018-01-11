using System;
using System.Configuration;

namespace Citicon.Data
{
    public sealed class Payable : EntityBase<ulong>
    {
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
        public DateTime? ChequeTransactionDate { get; set; }
        public Company ChequeCompany { get; set; }
        public decimal Value
        {
            get { return Credit != 0 ? -1 * Credit : Debit; }
        }
        public Company ReportingCategory { get; set; }

        public static string InputTax => ConfigurationManager.AppSettings["Payable.Description.InputTax"];

        public override string ToString()
        {
            return Description;
        }
    }
}
