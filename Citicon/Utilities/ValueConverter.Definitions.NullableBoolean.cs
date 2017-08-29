using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into nullable version of <see cref="bool"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static bool? ToNullableBoolean(object value)
        {
            return NullableConversionBase(value, Convert.ToBoolean);
        }

        /// <summary>
        /// Converts value into nullable version of <see cref="bool"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToBoolean);
        }
    }
}
