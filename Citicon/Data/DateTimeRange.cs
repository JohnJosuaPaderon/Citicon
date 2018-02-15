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


        public static bool operator ==(DateTimeRange left, DateTimeRange right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DateTimeRange left, DateTimeRange right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is DateTimeRange value)
            {
                return (
                    Equals(Begin, default(DateTime)) ||
                    Equals(value.Begin, default(DateTime)) ||
                    Equals(End, default(DateTime)) || 
                    Equals(value.End, default(DateTime)))
                    ? false : Equals(Begin, value.Begin) && Equals(End, value.End);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Begin.GetHashCode();
        }

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
