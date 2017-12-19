using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static char? ToNullableChar(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableChar);
        }
    }
}
