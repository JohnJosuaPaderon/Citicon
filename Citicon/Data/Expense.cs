using System;
using System.Configuration;

namespace Citicon.Data
{
    public sealed class Expense : EntityBase<ulong>
    {
        static Expense()
        {
            CashInBank = new Expense()
            {
                Id = Convert.ToUInt64(ConfigurationManager.AppSettings["Expense[CashInBank].Id"])
            };

            WithHoldingTax = new Expense()
            {
                Id = Convert.ToUInt64(ConfigurationManager.AppSettings["Expense[WithHoldingTax].Id"])
            };
        }

        public static Expense CashInBank { get; }
        public static Expense WithHoldingTax { get; }
        
        public string Code { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
