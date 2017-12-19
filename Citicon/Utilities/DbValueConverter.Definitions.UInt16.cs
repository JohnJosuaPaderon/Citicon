using System;

namespace Citicon.Utilities
{
    partial class DbValueConverter
    {
        public static ushort ToUInt16(bool value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(byte value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(char value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(decimal value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(double value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(short value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(int value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(long value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(object value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(sbyte value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(float value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(string value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(ushort value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(uint value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(ulong value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }
    }
}
