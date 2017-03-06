using System;
using System.Configuration;

namespace Citicon.Payables.Data
{
    public sealed class Expense : Sorschia.Data
    {
        static Expense()
        {
            CashInBank = new Expense()
            {
                Id = Convert.ToUInt64(ConfigurationManager.AppSettings["Expense[CashInBank].Id"])
            };
        }

        public static Expense CashInBank { get; }

        private ulong id;
        private string code;
        private string description;
        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("Expense.Id", value);
                }
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                if (code != value)
                {
                    code = value;
                    OnPropertyChanged("Expense.Code", value);
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
                    OnPropertyChanged("Expense.Description", value);
                }
            }
        }
        public static bool operator ==(Expense x, Expense y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(Expense x, Expense y)
        {
            return !(x == y);
        }
        public static Expense Salary
        {
            get
            {
                return new Expense
                {
                    code = ConfigurationManager.AppSettings["Expense.Salary.Code"],
                    description = ConfigurationManager.AppSettings["Expense.Salary.Description"],
                    id = ulong.Parse(ConfigurationManager.AppSettings["Expense.Salary.Id"])
                };
            }
        }
        public override bool Equals(object obj)
        {
            return (obj is Expense) ? (obj as Expense).id == id : false;
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
