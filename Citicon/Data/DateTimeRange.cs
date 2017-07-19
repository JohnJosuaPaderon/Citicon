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
            if (Start.Date == End.Date)
            {
                return string.Format("{0:MMMM dd, yyyy}", Start);
            }
            else if (Start.Month == End.Month)
            {
                return string.Format("{0:MMM} {0:dd}-{1:dd}, {0:yyyy}", Start, End);
            }
            else
            {
                return string.Concat(Start.ToString("MMM dd, yyyy"), " - ", End.ToString("MMM dd, yyyy"));
            }
        }
    }
}
