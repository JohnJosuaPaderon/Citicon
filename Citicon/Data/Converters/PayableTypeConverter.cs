using System;
using System.Collections.Generic;
using System.Linq;

namespace Citicon.Data.Converters
{
    public static class PayableTypeConverter
    {
        static PayableTypeConverter()
        {
            Displays = new List<Tuple<PayableType, string>>()
            {
                new Tuple<PayableType, string>(PayableType.Trade, "TRADE"),
                new Tuple<PayableType, string>(PayableType.NonTrade, "NON-TRADE")
            };
        }

        private static List<Tuple<PayableType, string>> Displays { get; }

        public static PayableType FromString(string value)
        {
            Enum.TryParse(value, out PayableType result);

            return result;
        }

        public static PayableType FromDisplay(string display)
        {
            return Displays.FirstOrDefault(x => x.Item2 == display)?.Item1 ?? PayableType.Trade;
        }

        public static string ToDisplay(PayableType type)
        {
            return Displays.FirstOrDefault(x => x.Item1 == type)?.Item2 ?? null;
        }
    }
}
