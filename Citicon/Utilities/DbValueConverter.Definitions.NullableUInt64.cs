using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static ulong? ToNullableUInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt64);
        }
    }
}
