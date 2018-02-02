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
        public decimal? SssLoan { get; set; }
        public decimal? PagibigLoan { get; set; }
    }
}
