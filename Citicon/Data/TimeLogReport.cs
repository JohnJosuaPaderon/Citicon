using System.Collections.Generic;

namespace Citicon.Data
{
    public class TimeLogReport
    {
        public DateTimeRange TimeLogRange { get; set; }
        public List<EmployeeTimeLogList> EmployeeTimeLogLists { get; } = new List<EmployeeTimeLogList>();
    }
}
