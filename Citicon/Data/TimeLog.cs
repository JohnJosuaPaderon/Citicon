using System;

namespace Citicon.Data
{
    public class TimeLog
    {
        public ulong Id { get; set; }
        public EmployeeLogin EmployeeLogin { get; set; }
        public DateTime? Login { get; set; }
        public DateTime? Logout { get; set; }
        public TimeLogType Type { get; set; }

        public static bool operator ==(TimeLog left, TimeLog right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(TimeLog left, TimeLog right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is TimeLog)
            {
                return (TimeLog)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
