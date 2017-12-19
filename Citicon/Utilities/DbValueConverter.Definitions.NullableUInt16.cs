using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static ushort? ToNullableUInt16(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt16);
        }

        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt16);
        }
    }
}
