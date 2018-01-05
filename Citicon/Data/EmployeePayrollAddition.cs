using System;

namespace Citicon.Data
{
    public class EmployeePayrollAddition : EntityBase<ulong>
    {
        public EmployeePayrollAddition()
        {
            EffectivityDate = DateTime.Now;
        }

        public Employee Employee { get; set; }
        public DateTime EffectivityDate { get; set; }
        public decimal BasicPay { get; set; }
        public decimal DailyRate { get; set; }
        public decimal Allowance { get; set; }
        public decimal OvertimeAllowance { get; set; }
    }
}
