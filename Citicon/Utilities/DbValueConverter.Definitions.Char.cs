using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static char ToChar(byte value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(short value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(int value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(long value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(object value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToChar);
        }

        public static char ToChar(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(string value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToChar);
        }

        public static char ToChar(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(uint value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }
    }
}
