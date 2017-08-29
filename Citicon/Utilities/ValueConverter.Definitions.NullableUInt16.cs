using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into nullable version of <see cref="ushort"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static ushort? ToNullableUInt16(object value)
        {
            return NullableConversionBase(value, Convert.ToUInt16);
        }

        /// <summary>
        /// Converts value into nullable version of <see cref="ushort"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToUInt16);
        }
    }
}
