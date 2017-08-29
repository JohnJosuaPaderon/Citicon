using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(bool value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type; No actual conversion is performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(byte value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(char value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(decimal value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(double value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(short value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(int value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(long value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(object value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static byte ToByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(sbyte value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(float value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(string value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="fromBase"></param>
        /// <returns></returns>
        public static byte ToByte(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static byte ToByte(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(ushort value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(uint value)
        {
            return ConversionBase(value, Convert.ToByte);
        }

        /// <summary>
        /// Converts value into <see cref="byte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static byte ToByte(ulong value)
        {
            return ConversionBase(value, Convert.ToByte);
        }
    }
}
