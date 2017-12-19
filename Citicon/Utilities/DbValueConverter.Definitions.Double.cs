using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static double ToDouble(bool value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(byte value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(double value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(short value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(int value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(long value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(object value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToDouble);
        }

        public static double ToDouble(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(float value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(string value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToDouble);
        }

        public static double ToDouble(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(uint value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }
    }
}
