using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into nullable version of <see cref="decimal"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static decimal? ToNullableDecimal(object value)
        {
            return NullableConversionBase(value, Convert.ToDecimal);
        }

        /// <summary>
        /// Converts value into nullable version of <see cref="decimal"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDecimal);
        }
    }
}
