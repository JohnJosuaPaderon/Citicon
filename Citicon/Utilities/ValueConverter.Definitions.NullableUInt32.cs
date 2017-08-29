using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into nullable version of <see cref="uint"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static uint? ToNullableUInt32(object value)
        {
            return NullableConversionBase(value, Convert.ToUInt32);
        }

        /// <summary>
        /// Converts value into nullable version of <see cref="uint"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToUInt32);
        }
    }
}
