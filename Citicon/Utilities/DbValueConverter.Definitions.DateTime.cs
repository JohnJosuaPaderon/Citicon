using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static DateTime ToDateTime(object value)
        {
            return ConversionBase(value, ValueConverter.ToDateTime);
        }

        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToDateTime);
        }

        public static DateTime ToDateTime(string value)
        {
            return ConversionBase(value, ValueConverter.ToDateTime);
        }

        public static DateTime ToDateTime(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToDateTime);
        }
    }
}
