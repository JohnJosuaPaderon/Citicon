using System;
using System.IO;

namespace Citicon.Utilities
{
    /// <summary>
    /// Provides methods for converting value into another type
    /// </summary>
    public static partial class ValueConverter
    {
        /// <summary>
        /// Determines wether the argument is able to be converted; This is only checks if the argument is null, returns true if not
        /// </summary>
        /// <typeparam name="TArgument">The type of the value</typeparam>
        /// <param name="value">The value to be checked</param>
        /// <returns></returns>
        private static bool Convertible<TArgument>(TArgument value)
        {
            return value != null;
        }

        /// <summary>
        /// Base-conversion method for converting value into another type
        /// </summary>
        /// <typeparam name="TArgument">The type of the value</typeparam>
        /// <typeparam name="TResult">The type when the value is converted</typeparam>
        /// <param name="value">The value to be converted</param>
        /// <param name="converter">Function that converts a value into another type</param>
        /// <returns></returns>
        private static TResult ConversionBase<TArgument, TResult>(TArgument value, Func<TArgument, TResult> converter)
        {
            return Convertible(value) ? converter(value) : default(TResult);
        }

        /// <summary>
        /// Base-conversion method for converting value into another type providing <see cref="IFormatProvider"/>
        /// </summary>
        /// <typeparam name="TArgument">The type of the value</typeparam>
        /// <typeparam name="TResult">The type when the value is converted</typeparam>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Provides mechanism for retrieving an object to control formatting</param>
        /// <param name="converter">Function that converts a value into another type</param>
        /// <returns></returns>
        private static TResult ConversionBase<TArgument, TResult>(TArgument value, IFormatProvider formatProvider, Func<TArgument, IFormatProvider, TResult> converter)
        {
            return Convertible(value) ? converter(value, formatProvider) : default(TResult);
        }

        /// <summary>
        /// Base-conversion method for converting value into another type providing from/to base value
        /// </summary>
        /// <typeparam name="TArgument">The type of the value</typeparam>
        /// <typeparam name="TResult">The type when the value is converted</typeparam>
        /// <param name="value">The value to be converted</param>
        /// <param name="fromToBase"></param>
        /// <param name="converter">Function that converts a value into another type</param>
        /// <returns></returns>
        private static TResult ConversionBase<TArgument, TResult>(TArgument value, int fromToBase, Func<TArgument, int, TResult> converter)
        {
            return Convertible(value) ? converter(value, fromToBase) : default(TResult);
        }

        /// <summary>
        /// Base-conversion method for converting nullable value type value into another type
        /// </summary>
        /// <typeparam name="TResult">The type when the value is converted</typeparam>
        /// <typeparam name="TArgument">The type of the value</typeparam>
        /// <param name="value">The value to be converted</param>
        /// <param name="converter">Function that converts a value into another type</param>
        /// <returns></returns>
        private static TResult? NullableConversionBase<TResult, TArgument>(TArgument value, Func<TArgument, TResult> converter) where TResult : struct
        {
            return (value != null) ? new TResult?(converter(value)) : null;
        }

        /// <summary>
        /// Base-conversion method for converting nullable value type value into another type
        /// </summary>
        /// <typeparam name="TArgument">The type of the value</typeparam>
        /// <typeparam name="TResult">The type when the value is converted</typeparam>
        /// <param name="value">The value to be converted</param>
        /// <param name="fromToBase"></param>
        /// <param name="converter">Function that converts a value into another type</param>
        /// <returns></returns>
        private static TResult? NullableConversionBase<TResult, TArgument>(TArgument value, int fromToBase, Func<TArgument, int, TResult> converter) where TResult : struct
        {
            return Convertible(value) ? new TResult?(converter(value, fromToBase)) : null;
        }

        /// <summary>
        /// Base-conversion method for converting nullable value type value into another type
        /// </summary>
        /// <typeparam name="TArgument">The type of the value</typeparam>
        /// <typeparam name="TResult">The type when the value is converted</typeparam>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Provides mechanism for retrieving an object to control formatting</param>
        /// <param name="converter">Function that converts a value into another type</param>
        /// <returns></returns>
        private static TResult? NullableConversionBase<TResult, TArgument>(TArgument value, IFormatProvider formatProvider, Func<TArgument, IFormatProvider, TResult> converter) where TResult : struct
        {
            return Convertible(value) ? new TResult?(converter(value, formatProvider)) : null;
        }

        public static byte[] ToByteArray(object value)
        {
            if (value is byte[] bytes)
            {
                return bytes;
            }
            else
            {
                return null;
            }
        }

        public static Stream ToStream(object value)
        {
            if (value != null)
            {
                return new MemoryStream(ToByteArray(value));
            }
            else
            {
                return null;
            }
        }

        public static TimeSpan ToTimeSpan(object value)
        {
            if (value != null)
            {
                return new TimeSpan(ToInt64(value));
            }
            else
            {
                return default(TimeSpan);
            }
        }

        public static TimeSpan? ToNullableTimeSpan(object value)
        {
            if (value != null)
            {
                return ToTimeSpan(value);
            }
            else
            {
                return null;
            }
        }
    }
}
