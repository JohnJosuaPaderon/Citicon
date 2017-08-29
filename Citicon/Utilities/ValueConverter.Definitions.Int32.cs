using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(bool value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(byte value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(char value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(decimal value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(double value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(short value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(int value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(long value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(object value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static int ToInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(sbyte value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(float value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(string value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="fromBase"></param>
        /// <returns></returns>
        public static int ToInt32(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static int ToInt32(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(ushort value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(uint value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }

        /// <summary>
        /// Converts value into <see cref="int"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static int ToInt32(ulong value)
        {
            return ConversionBase(value, Convert.ToInt32);
        }
    }
}
