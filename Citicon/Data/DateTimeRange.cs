using System;

namespace Citicon.Data
{
    public sealed class DateTimeRange
    {
        public DateTimeRange()
        {
            Begin = default(DateTime);
            End = default(DateTime);
        }

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
                return string.Format("{0:MMMM dd, yyyy}", Begin).ToUpper();
            }
            else if (Begin.Year == End.Year && Begin.Month == End.Month)
            {
                return string.Format("{0:MMMM} {0:dd}-{1:dd}, {0:yyyy}", Begin, End).ToUpper();
            }
            else
            {
                return string.Concat(Begin.ToString("MMMM dd, yyyy"), " - ", End.ToString("MMMM dd, yyyy")).ToUpper();
            }
        }
    }
}
