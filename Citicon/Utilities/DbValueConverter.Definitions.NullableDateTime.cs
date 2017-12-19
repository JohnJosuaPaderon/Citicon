using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static DateTime? ToNullableDateTime(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDateTime);
        }

        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDateTime);
        }

        public static DateTime? ToNullableDateTime(string value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDateTime);
        }

        public static DateTime? ToNullableDateTime(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDateTime);
        }
    }
}
