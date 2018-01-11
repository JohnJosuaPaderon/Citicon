using System;

namespace Citicon.Data
{
    public class Holiday : EntityBase<ulong>
    {
        public HolidayType Type { get; set; }
        public string Name { get; set; }
        public DateTime DateOccur { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
