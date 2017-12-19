using System;
using System.IO;
using System.Security;

namespace Citicon.Utilities
{
    public static partial class DbValueConverter
    {
        private static bool Convertible<TArgument>(TArgument value)
        {
            return !DBNull.Value.Equals(value);
        }

        private static TResult ConversionBase<TArgument, TResult>(TArgument value, Func<TArgument, TResult> converter)
        {
            return Convertible(value) ? converter(value) : default(TResult);
        }

        private static TResult ConversionBase<TArgument, TResult>(TArgument value, int fromToBase, Func<TArgument, int, TResult> converter)
        {
            return Convertible(value) ? converter(value, fromToBase) : default(TResult);
        }

        private static TResult ConversionBase<TArgument, TResult>(TArgument value, IFormatProvider formatProvider, Func<TArgument, IFormatProvider, TResult> converter)
        {
            return Convertible(value) ? converter(value, formatProvider) : default(TResult);
        }

        public static byte[] ToByteArray(object value)
        {
            return ConversionBase(value, ValueConverter.ToByteArray);
        }

        public static Stream ToStream(object value)
        {
            return ConversionBase(value, ValueConverter.ToStream);
        }

        public static TimeSpan ToTimeSpan(object value)
        {
            return ConversionBase(value, ValueConverter.ToTimeSpan);
        }

        public static TimeSpan? ToNullableTimeSpan(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableTimeSpan);
        }
    }
}
