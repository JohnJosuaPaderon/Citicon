using System;

namespace Citicon.Data
{
    public class Holiday
    {
        public ulong Id { get; set; }
        public HolidayType Type { get; set; }
        public string Name { get; set; }
        public DateTime DateOccur { get; set; }

        public static bool operator ==(Holiday left, Holiday right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Holiday left, Holiday right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Holiday)
            {
                return (Holiday)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
