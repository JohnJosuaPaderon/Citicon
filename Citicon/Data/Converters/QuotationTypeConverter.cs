using System;
using System.Collections.Generic;

namespace Citicon.Data.Converters
{
    public static class QuotationTypeConverter
    {
        static QuotationTypeConverter()
        {
            TypePrefixes = new Dictionary<QuotationType, string>();
            TypePrefixes.Add(QuotationType.Citicon, "313");
            TypePrefixes.Add(QuotationType.Lex, "2011");
        }

        private static Dictionary<QuotationType, string> TypePrefixes { get; }

        public static string GetPrefix(QuotationType type)
        {
            return TypePrefixes[type];
        }

        public static QuotationType Parse(string value)
        {
            QuotationType result;
            Enum.TryParse(value, out result);

            return result;
        }
    }
}
