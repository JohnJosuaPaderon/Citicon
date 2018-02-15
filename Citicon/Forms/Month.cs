namespace Citicon.Forms
{
    public sealed class Month
    {
        static Month()
        {
            January = new Month(1, nameof(January));
            February = new Month(2, nameof(February));
            March = new Month(3, nameof(March));
            April = new Month(4, nameof(April));
            May = new Month(5, nameof(May));
            June = new Month(6, nameof(June));
            July = new Month(7, nameof(July));
            August = new Month(8, nameof(August));
            September = new Month(9, nameof(September));
            October = new Month(10, nameof(October));
            November = new Month(11, nameof(November));
            December = new Month(12, nameof(December));

            AllMonths = new Month[]
            {
                January,
                February,
                March,
                April,
                May,
                June,
                July,
                August,
                September,
                October,
                November,
                December
            };

            FirstQuarterMonths = new Month[]
            {
                January, February, March
            };

            SecondQuarterMonths = new Month[]
            {
                April, May, June
            };

            ThirdQuarterMonths = new Month[]
            {
                July, August, September
            };

            FourthQuarterMonths = new Month[]
            {
                October, November, December
            };
        }

        public static Month January { get; }
        public static Month February { get; }
        public static Month March { get; }
        public static Month April { get; }
        public static Month May { get; }
        public static Month June { get; }
        public static Month July { get; }
        public static Month August { get; }
        public static Month September { get; }
        public static Month October { get; }
        public static Month November { get; }
        public static Month December { get; }

        public static Month[] AllMonths { get; }
        public static Month[] FirstQuarterMonths { get; }
        public static Month[] SecondQuarterMonths { get; }
        public static Month[] ThirdQuarterMonths { get; }
        public static Month[] FourthQuarterMonths { get; }

        private Month(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static bool operator ==(Month left, Month right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Month left, Month right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is Month value)
            {
                return (Equals(Id, default(int)) || Equals(value.Id, default(int))) ? false : Equals(Id, value.Id);
            }
            else
            {
                return false;
            }
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
