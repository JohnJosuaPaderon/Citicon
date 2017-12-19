using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static int? ToNullableInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt32);
        }
    }
}
