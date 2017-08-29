using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(bool value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(byte value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(decimal value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(double value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(short value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(int value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(long value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(object value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static double ToDouble(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(sbyte value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(float value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(string value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static double ToDouble(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(ushort value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(uint value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }

        /// <summary>
        /// Converts value into <see cref="double"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static double ToDouble(ulong value)
        {
            return ConversionBase(value, Convert.ToDouble);
        }
    }
}
