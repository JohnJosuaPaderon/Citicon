using System;

namespace Citicon.Data
{
    public sealed class DateTimeRange
    {
        public DateTimeRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public override string ToString()
        {
            if (Start.Month == End.Month)
            {
                return string.Format("{0:MMMM} {0:dd}-{1:dd}, {0:yyyy}", Start, End);
            }
            else
            {
                return string.Concat(Start.ToString("MMMM dd, yyyy"), " - ", End.ToString("MMMM dd, yyyy"));
            }
        }
    }
}
