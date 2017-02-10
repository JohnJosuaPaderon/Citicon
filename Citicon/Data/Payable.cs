using Citicon.Data;
using Citicon.Inventory.Data;
using System;

namespace Citicon.Payables.Data
{
    public sealed class Payable : Sorschia.Data
    {
        private ulong id;
        private Stock stock;
        private Expense expense;
        private bool variablecost;
        private string description;
        private Supplier supplier;
        private Branch branch;
        private Company company;
        private DateTime salaryperiodstart;
        private DateTime salaryperiodend;
        private BankAccount bankaccount;
        private string chequevouchernumber;
        private string chequenumber;
        private decimal debit;
        private decimal credit;
        private string remarks;
        private DateTime transactiondate;
        private string accountType;
        private DateTime chequeDate;

        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("Payable.Id", value);
                }
            }
        } 
        public Stock Stock
        {
            get { return stock; }
            set
            {
                if (stock != value)
                {
                    stock = value;
                    OnPropertyChanged("Payable.Stock", value);
                }
            }
        }
        public Expense Expense
        {
            get { return expense; }
            set
            {
                if (expense != value)
                {
                    expense = value;
                    OnPropertyChanged("Payable.Expense", value);
                }
            }
        }
        public bool VariableCost
        {
            get { return variablecost; }
            set
            {
                if (variablecost != value)
                {
                    variablecost = value;
                    OnPropertyChanged("Payable.VariableCost", value);
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("Payable.Description", value);
                }
            }
        }
        public Supplier Supplier
        {
            get { return supplier; }
            set
            {
                if (supplier != value)
                {
                    supplier = value;
                    OnPropertyChanged("Payable.Supplier", value);
                }
            }
        }
        public Branch Branch
        {
            get { return branch; }
            set
            {
                if (branch != value)
                {
                    branch = value;
                    OnPropertyChanged("Payable.Branch", value);
                }
            }
        }
        public Company Company
        {
            get { return company; }
            set
            {
                if (company != value)
                {
                    company = value;
                    OnPropertyChanged("Payable.Company", value);
                }
            }
        }
        public DateTime SalaryPeriodStart
        {
            get { return salaryperiodstart; }
            set
            {
                if (salaryperiodstart != value)
                {
                    salaryperiodstart = value;
                    OnPropertyChanged("Payable.SalaryPeriodStart", value);
                }
            }
        }
        public DateTime SalaryPeriodEnd
        {
            get { return salaryperiodend; }
            set
            {
                if (salaryperiodend != value)
                {
                    salaryperiodend = value;
                    OnPropertyChanged("Payable.SalaryPeriodEnd", value);
                }
            }
        }
        public BankAccount BankAccount
        {
            get { return bankaccount; }
            set
            {
                if (bankaccount != value)
                {
                    bankaccount = value;
                    OnPropertyChanged("Payable.BankAccount", value);
                }
            }
        }
        public string ChequeVoucherNumber
        {
            get { return chequevouchernumber; }
            set
            {
                if (chequevouchernumber != value)
                {
                    chequevouchernumber = value;
                    OnPropertyChanged("Payable.ChequeVoucherNumber", value);
                }
            }
        }
        public string ChequeNumber
        {
            get { return chequenumber; }
            set
            {
                if (chequenumber != value)
                {
                    chequenumber = value;
                    OnPropertyChanged("Payable.ChequeNumber", value);
                }
            }
        }
        public decimal Debit
        {
            get { return debit; }
            set
            {
                if (debit != value)
                {
                    debit = value;
                    OnPropertyChanged("Payable.Debit", value);
                }
            }
        }
        public decimal Credit
        {
            get { return credit; }
            set
            {
                if (credit != value)
                {
                    credit = value;
                    OnPropertyChanged("Payable.Credit", value);
                }
            }
        }
        public string Remarks
        {
            get { return remarks; }
            set
            {
                if (remarks != value)
                {
                    remarks = value;
                    OnPropertyChanged("Payable.Remarks", value);
                }
            }
        }
        public DateTime TransactionDate
        {
            get { return transactiondate; }
            set
            {
                if (transactiondate != value)
                {
                    transactiondate = value;
                    OnPropertyChanged("Payable.TransactionDate", value);
                }
            }
        }
        public string AccountType
        {
            get { return accountType; }
            set
            {
                if (accountType != value)
                {
                    accountType = value;
                    OnPropertyChanged("Payable.AccountType", value);
                }
            }
        }
        public DateTime ChequeDate
        {
            get { return chequeDate; }
            set
            {
                if (chequeDate != value)
                {
                    chequeDate = value;
                    OnPropertyChanged("Payable.ChequeDate", value);
                }
            }
        }

        public static bool operator ==(Payable x, Payable y)
        {
            return
                x?.stock == y?.stock &&
                x?.expense == y?.expense &&
                x?.description == y?.description &&
                x?.supplier == y?.supplier &&
                x?.branch == y?.branch &&
                x?.company == y?.company &&
                x?.chequevouchernumber == y?.chequevouchernumber &&
                x?.chequenumber == y?.chequenumber;
        }
        public static bool operator !=(Payable x, Payable y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Payable) ? (obj as Payable).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return description;
        }
    }
}
