using System;
using System.Configuration;

namespace Citicon.Payables.Data
{
    public sealed class Expense
    {
        static Expense()
        {
            CashInBank = new Expense()
            {
                Id = Convert.ToUInt64(ConfigurationManager.AppSettings["Expense[CashInBank].Id"])
            };
        }

        public static Expense CashInBank { get; }
        
        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public static bool operator ==(Expense left, Expense right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Expense left, Expense right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Expense)
            {
                return (Expense)arg == this;
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
