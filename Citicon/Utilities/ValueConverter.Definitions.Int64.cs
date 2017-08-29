using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(bool value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(byte value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(char value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(decimal value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(double value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(short value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(int value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(long value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(object value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static long ToInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(sbyte value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(float value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(string value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="fromBase"></param>
        /// <returns></returns>
        public static long ToInt64(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static long ToInt64(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(ushort value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(uint value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long ToInt64(ulong value)
        {
            return ConversionBase(value, Convert.ToInt64);
        }
    }
}
