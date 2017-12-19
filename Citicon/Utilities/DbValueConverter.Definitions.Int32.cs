using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static int ToInt32(bool value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(byte value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(char value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(double value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(short value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(int value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(long value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToInt32);
        }

        public static int ToInt32(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(float value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(string value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToInt32);
        }

        public static int ToInt32(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToInt32);
        }

        public static int ToInt32(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(uint value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }
    }
}
