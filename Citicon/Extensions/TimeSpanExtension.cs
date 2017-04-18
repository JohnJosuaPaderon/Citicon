using System;
using System.Text;

namespace Citicon.Extensions
{
    public static class TimeSpanExtension
    {
        public static string ToWord(this TimeSpan arg)
        {
            var wordBuilder = new StringBuilder();

            var hasDays = arg.Days > 0;
            var hasHours = arg.Hours > 0;
            var hasMinutes = arg.Minutes > 0;

            if (!(hasDays || hasHours || hasMinutes))
            {
                wordBuilder.Append("less than a minute");
            }
            else
            {
                if (hasDays)
                {
                    wordBuilder.AppendFormat("{0} day{1}", arg.Days, arg.Days > 1 ? "s" : string.Empty);

                    if (hasHours || hasMinutes)
                    {
                        wordBuilder.Append(", ");
                    }
                }

                if (hasHours)
                {
                    wordBuilder.AppendFormat("{0} hour{1}", arg.Hours, arg.Hours > 1 ? "s" : string.Empty);

                    if (hasMinutes)
                    {
                        wordBuilder.Append(", ");
                    }
                }

                if (hasMinutes)
                {
                    wordBuilder.AppendFormat("{0} minute{1}", arg.Minutes, arg.Minutes > 1 ? "s" : string.Empty);
                }
            }

            return wordBuilder.ToString();
        }
    }
}
