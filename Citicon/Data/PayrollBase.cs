using System;

namespace Citicon.Data
{
    public abstract class PayrollBase : EntityBase<ulong>
    {
        public PayrollBase(PayrollType type)
        {
            Type = type ?? throw new InvalidOperationException("Payroll Type is invalid.");
        }

        public PayrollType Type { get; }
        public DateTimeRange CutOff { get; set; }
        public Branch Branch { get; set; }
        public DateTime RunDate { get; set; }
    }
}
