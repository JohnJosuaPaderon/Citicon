using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into nullable version of <see cref="DateTime"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static DateTime? ToNullableDateTime(object value)
        {
            return NullableConversionBase(value, Convert.ToDateTime);
        }

        /// <summary>
        /// Converts value into nullable version of <see cref="DateTime"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToDateTime);
        }
    }
}
