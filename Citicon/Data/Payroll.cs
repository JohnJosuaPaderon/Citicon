using System.Collections.Generic;

namespace Citicon.Data
{
    public class Payroll
    {
        public Payroll()
        {
            Items = new List<EmployeePayroll>();
        }

        public DateTimeRange DateRange { get; set; }
        public Branch Branch { get; set; }
        public List<EmployeePayroll> Items { get; }

    }
}
