using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(bool value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(byte value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(decimal value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(double value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(short value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(int value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(long value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(object value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static decimal ToDecimal(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(sbyte value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(float value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(string value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static decimal ToDecimal(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(ushort value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(uint value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal ToDecimal(ulong value)
        {
            return ConversionBase(value, Convert.ToDecimal);
        }
    }
}
