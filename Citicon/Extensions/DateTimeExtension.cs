using System;

namespace Citicon.Extensions
{
    public static class DateTimeExtension
    {
        public static bool IsBetweenDates(this DateTime instance, DateTime dateBegin, DateTime dateEnd)
        {
            return instance.Date >= dateBegin.Date && instance.Date <= dateEnd.Date;
        }

        public static bool IsBetweenDateTimes(this DateTime instance, DateTime dateBegin, DateTime dateEnd)
        {
            return instance >= dateBegin && instance <= dateEnd;
        }

        public static bool IsBetweenDateTimes(this DateTime instance, DateTime dateBegin, DateTime dateEnd, TimeSpan offset)
        {
            return instance >= (dateBegin - offset) && instance <= (dateEnd - offset);
        }
    }
}
