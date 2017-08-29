using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(bool value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(byte value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(char value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(decimal value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(double value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(short value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(int value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(long value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(object value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static ushort ToUInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(sbyte value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(float value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(string value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="fromBase"></param>
        /// <returns></returns>
        public static ushort ToUInt16(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static ushort ToUInt16(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(ushort value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(uint value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort ToUInt16(ulong value)
        {
            return ConversionBase(value, Convert.ToUInt16);
        }
    }
}
