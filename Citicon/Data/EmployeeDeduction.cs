using System;

namespace Citicon.Data
{
    public sealed class EmployeeDeduction : EntityBase<ulong>
    {
        public EmployeeDeduction(Employee employee)
        {
            Employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }

        public Employee Employee { get; }
        public decimal? WithholdingTax { get; set; }
        public decimal? Sss { get; set; }
        public decimal? SssEr { get; set; }
        public decimal? SssEc { get; set; }
        public decimal? Pagibig { get; set; }
        public decimal? PhilHealth { get; set; }
    }
}
