using System;

namespace Citicon.Data
{
    public abstract class PayrollBase : EntityBase<ulong>
    {
        public PayrollBase(PayrollType type)
        {
            Type = type ?? throw new InvalidOperationException("Payroll Type is invalid.");
            CutOff = new DateTimeRange();
        }

        public PayrollType Type { get; }
        public DateTimeRange CutOff { get; }
        public Branch Branch { get; set; }
        public DateTime RunDate { get; set; }
    }
}
