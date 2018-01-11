using System;

namespace Citicon.Data
{
    public class TimeLog : EntityBase<ulong>
    {
        public EmployeeLogin EmployeeLogin { get; set; }
        public DateTime? Login { get; set; }
        public DateTime? Logout { get; set; }
        public bool LoginEdited { get; set; }
        public bool LogoutEdited { get; set; }
        public TimeLogType Type { get; set; }
        public TimeSpan? Difference => Logout - Login;
    }
}
