using System;

namespace Citicon.Data
{
    public class EmployeePayrollDeduction : EntityBase<ulong>
    {
        public Employee Employee { get; set; }
        public DateTime EffectivityDate { get; set; }
        public decimal Sss { get; set; }
        public decimal SssEc { get; set; }
        public decimal SssEr { get; set; }
        public decimal PagibigLoan { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal WithholdingTax { get; set; }
    }
}
