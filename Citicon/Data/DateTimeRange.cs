using System;

namespace Citicon.Data
{
    public sealed class DateTimeRange
    {
        public DateTimeRange(DateTime begin, DateTime end)
        {
            Begin = begin;
            End = end;
        }

        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public override string ToString()
        {
            if (Begin.Date == End.Date)
            {
                return string.Format("{0:MMMM dd, yyyy}", Begin);
            }
            else if (Begin.Year == End.Year && Begin.Month == End.Month)
            {
                return string.Format("{0:MMM} {0:dd}-{1:dd}, {0:yyyy}", Begin, End);
            }
            else
            {
                return string.Concat(Begin.ToString("MMM dd, yyyy"), " - ", End.ToString("MMM dd, yyyy"));
            }
        }
    }
}
