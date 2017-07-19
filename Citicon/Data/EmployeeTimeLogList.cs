using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class EmployeeTimeLogList
    {
        public EmployeeTimeLogList(Employee owner)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
        }

        public Employee Owner { get; }
        public List<TimeLog> TimeLogs { get; } = new List<TimeLog>();
    }
}
