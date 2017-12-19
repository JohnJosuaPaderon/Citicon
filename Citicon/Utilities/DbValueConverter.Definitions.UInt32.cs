using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static uint ToUInt32(bool value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(byte value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(char value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(double value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(short value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(int value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(long value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(float value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(string value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(uint value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }
    }
}
