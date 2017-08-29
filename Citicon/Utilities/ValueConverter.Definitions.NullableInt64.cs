using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into nullable version of <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static long? ToNullableInt64(object value)
        {
            return NullableConversionBase(value, Convert.ToInt64);
        }

        /// <summary>
        /// Converts value into nullable version of <see cref="long"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToInt64);
        }
    }
}
