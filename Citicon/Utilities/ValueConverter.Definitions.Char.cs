using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(byte value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(short value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(int value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(long value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(object value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static char ToChar(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(sbyte value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(string value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static char ToChar(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(ushort value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(uint value)
        {
            return ConversionBase(value, Convert.ToChar);
        }

        /// <summary>
        /// Converts value into <see cref="char"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static char ToChar(ulong value)
        {
            return ConversionBase(value, Convert.ToChar);
        }
    }
}
