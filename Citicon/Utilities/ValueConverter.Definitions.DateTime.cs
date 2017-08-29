using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="DateTime"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static DateTime ToDateTime(object value)
        {
            return ConversionBase(value, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts value into <see cref="DateTime"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts value into <see cref="DateTime"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static DateTime ToDateTime(string value)
        {
            return ConversionBase(value, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts value into <see cref="DateTime"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static DateTime ToDateTime(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToDateTime);
        }
    }
}
