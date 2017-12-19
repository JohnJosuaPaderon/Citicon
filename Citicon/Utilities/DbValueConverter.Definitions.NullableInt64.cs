using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static long? ToNullableInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt64);
        }
    }
}
