using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static byte ToByte(bool value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(byte value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(char value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(double value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(short value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(int value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(long value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(object value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToByte);
        }

        public static byte ToByte(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(float value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(string value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToByte);
        }

        public static byte ToByte(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToByte);
        }

        public static byte ToByte(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(uint value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }
    }
}
