using System;
using System.IO;

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

        public static bool ToBoolean(object value)
        {
            return ConversionBase(value, ValueConverter.ToBoolean);
        }

        public static bool ToBoolean(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToBoolean);
        }

        public static byte ToByte(object value)
        {
            return ConversionBase(value, ValueConverter.ToByte);
        }

        public static byte ToByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToByte);
        }

        public static char ToChar(object value)
        {
            return ConversionBase(value, ValueConverter.ToChar);
        }

        public static char ToChar(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToChar);
        }
        public static DateTime ToDateTime(object value)
        {
            return ConversionBase(value, ValueConverter.ToDateTime);
        }

        public static DateTime ToDateTime(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToDateTime);
        }

        public static decimal ToDecimal(object value)
        {
            return ConversionBase(value, ValueConverter.ToDecimal);
        }

        public static decimal ToDecimal(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToDecimal);
        }

        public static double ToDouble(object value)
        {
            return ConversionBase(value, ValueConverter.ToDouble);
        }

        public static double ToDouble(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToDouble);
        }

        public static short ToInt16(object value)
        {
            return ConversionBase(value, ValueConverter.ToInt16);
        }

        public static short ToInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToInt16);
        }

        public static int ToInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToInt32);
        }

        public static int ToInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToInt32);
        }

        public static long ToInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToInt64);
        }

        public static long ToInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToInt64);
        }

        public static bool? ToNullableBoolean(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableBoolean);
        }

        public static bool? ToNullableBoolean(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableBoolean);
        }

        public static byte? ToNullableByte(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableByte);
        }

        public static byte? ToNullableByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableByte);
        }

        public static char? ToNullableChar(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableChar);
        }

        public static char? ToNullableChar(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableChar);
        }

        public static DateTime? ToNullableDateTime(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDateTime);
        }

        public static DateTime? ToNullableDateTime(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDateTime);
        }

        public static decimal? ToNullableDecimal(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDecimal);
        }

        public static decimal? ToNullableDecimal(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDecimal);
        }

        public static double? ToNullableDouble(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableDouble);
        }

        public static double? ToNullableDouble(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableDouble);
        }

        public static short? ToNullableInt16(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt16);
        }

        public static short? ToNullableInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt16);
        }

        public static int? ToNullableInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt32);
        }

        public static int? ToNullableInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt32);
        }

        public static long? ToNullableInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableInt64);
        }

        public static long? ToNullableInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableInt64);
        }

        public static sbyte? ToNullableSByte(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSByte);
        }

        public static sbyte? ToNullableSByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableSByte);
        }

        public static float? ToNullableSingle(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableSingle);
        }

        public static float? ToNullableSingle(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableSingle);
        }

        public static ushort? ToNullableUInt16(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt16);
        }

        public static ushort? ToNullableUInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt16);
        }

        public static uint? ToNullableUInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt32);
        }

        public static uint? ToNullableUInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt32);
        }

        public static ulong? ToNullableUInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToNullableUInt64);
        }

        public static ulong? ToNullableUInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToNullableUInt64);
        }

        public static sbyte ToSByte(object value)
        {
            return ConversionBase(value, ValueConverter.ToSByte);
        }

        public static sbyte ToSByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToSByte);
        }

        public static float ToSingle(object value)
        {
            return ConversionBase(value, ValueConverter.ToSingle);
        }

        public static float ToSingle(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToSingle);
        }

        public static string ToString(object value)
        {
            return ConversionBase(value, ValueConverter.ToString);
        }

        public static string ToString(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToString);
        }

        public static ushort ToUInt16(object value)
        {
            return ConversionBase(value, ValueConverter.ToUInt16);
        }

        public static ushort ToUInt16(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToUInt16);
        }

        public static uint ToUInt32(object value)
        {
            return ConversionBase(value, ValueConverter.ToUInt32);
        }

        public static uint ToUInt32(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToUInt32);
        }

        public static ulong ToUInt64(object value)
        {
            return ConversionBase(value, ValueConverter.ToUInt64);
        }

        public static ulong ToUInt64(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, ValueConverter.ToUInt64);
        }
    }
}
