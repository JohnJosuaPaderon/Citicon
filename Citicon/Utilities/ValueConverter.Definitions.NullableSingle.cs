using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into nullable version of <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float? ToNullableSingle(object value)
        {
            return NullableConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into nullable version of <see cref="float"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return NullableConversionBase(value, formatProvider, Convert.ToSingle);
        }
    }
}
