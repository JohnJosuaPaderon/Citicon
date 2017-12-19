using Citicon.Utilities;
using System;
using System.Data.Common;
using System.IO;

namespace Citicon.Extensions
{
    public static class DbParameterCollectionExtension
    {
        private static void ValidateGetterArguments(DbParameterCollection parameters, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(parameterName))
            {
                throw new ArgumentException($"Argument '{nameof(parameterName)}' is either null or white space.");
            }

            if (parameters.Count <= 0)
            {
                throw new ArgumentException($"Argument '{nameof(parameters)}' has no result.");
            }
        }

        private static TResult GetValueBase<TResult>(DbParameterCollection parameters, string parameterName, Func<object, TResult> converter)
        {
            ValidateGetterArguments(parameters, parameterName);
            return converter(parameters[parameterName].Value);
        }

        private static TResult GetValueBase<TResult>(DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider, Func<object, IFormatProvider, TResult> converter)
        {
            ValidateGetterArguments(parameters, parameterName);
            return converter(parameters[parameterName].Value, formatProvider);
        }

        public static bool GetBoolean(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToBoolean);
        }

        public static bool GetBoolean(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToBoolean);
        }

        public static byte GetByte(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToByte);
        }

        public static byte GetByte(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToByte);
        }

        public static char GetChar(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToChar);
        }

        public static char GetChar(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToChar);
        }

        public static DateTime GetDateTime(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToDateTime);
        }

        public static DateTime GetDateTime(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToDateTime);
        }

        public static decimal GetDecimal(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToDecimal);
        }

        public static decimal GetDecimal(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToDecimal);
        }

        public static double GetDouble(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToDouble);
        }

        public static double GetDouble(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToDouble);
        }

        public static short GetInt16(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToInt16);
        }

        public static short GetInt16(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToInt16);
        }

        public static int GetInt32(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToInt32);
        }

        public static int GetInt32(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToInt32);
        }

        public static long GetInt64(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToInt64);
        }

        public static long GetInt64(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToInt64);
        }

        public static bool? GetNullableBoolean(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableBoolean);
        }

        public static bool? GetNullableBoolean(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableBoolean);
        }

        public static byte? GetNullableByte(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableByte);
        }

        public static byte? GetNullableByte(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableByte);
        }

        public static char? GetNullableChar(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableChar);
        }

        public static char? GetNullableChar(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableChar);
        }

        public static DateTime? GetNullableDateTime(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableDateTime);
        }

        public static DateTime? GetNullableDateTime(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableDateTime);
        }

        public static decimal? GetNullableDecimal(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableDecimal);
        }

        public static decimal? GetNullableDecimal(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableDecimal);
        }

        public static double? GetNullableDouble(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableDouble);
        }

        public static double? GetNullableDouble(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableDouble);
        }

        public static short? GetNullableInt16(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableInt16);
        }

        public static short? GetNullableInt16(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableInt16);
        }

        public static int? GetNullableInt32(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableInt32);
        }

        public static int? GetNullableInt32(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableInt32);
        }

        public static long? GetNullableInt64(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableInt64);
        }

        public static long? GetNullableInt64(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableInt64);
        }

        public static sbyte? GetNullableSByte(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableSByte);
        }

        public static sbyte? GetNullableSByte(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableSByte);
        }

        public static float? GetNullableSingle(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableSingle);
        }

        public static float? GetNullableSingle(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableSingle);
        }

        public static ushort? GetNullableUInt16(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableUInt16);
        }

        public static ushort? GetNullableUInt16(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableUInt16);
        }

        public static uint? GetNullableUInt32(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableUInt32);
        }

        public static uint? GetNullableUInt32(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableUInt32);
        }

        public static ulong? GetNullableUInt64(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToNullableUInt64);
        }

        public static ulong? GetNullableUInt64(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToNullableUInt64);
        }

        public static sbyte GetSByte(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToSByte);
        }

        public static sbyte GetSByte(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToSByte);
        }

        public static float GetSingle(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToSingle);
        }

        public static float GetSingle(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToSingle);
        }

        public static string GetString(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToString);
        }

        public static string GetString(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToString);
        }

        public static ushort GetUInt16(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToUInt16);
        }

        public static ushort GetUInt16(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToUInt16);
        }

        public static uint GetUInt32(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToUInt32);
        }

        public static uint GetUInt32(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToUInt32);
        }

        public static ulong GetUInt64(this DbParameterCollection parameters, string parameterName)
        {
            return GetValueBase(parameters, parameterName, DbValueConverter.ToUInt64);
        }

        public static ulong GetUInt64(this DbParameterCollection parameters, string parameterName, IFormatProvider formatProvider)
        {
            return GetValueBase(parameters, parameterName, formatProvider, DbValueConverter.ToUInt64);
        }

        public static Stream GetStream(this DbParameterCollection parameters, string fieldName)
        {
            return GetValueBase(parameters, fieldName, DbValueConverter.ToStream);
        }

        public static TimeSpan GetTimeSpan(this DbParameterCollection parameters, string fieldName)
        {
            return GetValueBase(parameters, fieldName, DbValueConverter.ToTimeSpan);
        }

        public static TimeSpan? GetNullableTimeSpan(this DbParameterCollection parameters, string fieldName)
        {
            return GetValueBase(parameters, fieldName, DbValueConverter.ToNullableTimeSpan);
        }
    }
}
