using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="bool"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(bool value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(byte value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(decimal value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(double value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }
        
        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(short value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(int value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(long value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(object value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static bool ToBoolean(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(sbyte value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(float value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(string value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static bool ToBoolean(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(ushort value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(uint value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool ToBoolean(ulong value)
        {
            return ConversionBase(value, Convert.ToBoolean);
        }
    }
}
