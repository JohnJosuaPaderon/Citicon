using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static long ToInt64(bool value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(byte value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(char value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(double value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(short value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(int value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(long value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToInt64);
        }

        public static long ToInt64(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(float value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(string value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToInt64);
        }

        public static long ToInt64(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToInt64);
        }

        public static long ToInt64(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(uint value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }
    }
}
