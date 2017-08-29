using Citicon.Utilities;
using System;
using System.Collections.Specialized;

namespace Citicon.Extensions
{
    public static class NameValueCollectionExtension
    {
        private static void Validate(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException(nameof(key), "Key is invalid.");
            }
        }

        private static T GetValueBase<T>(NameValueCollection nameValues, string key, Func<object, T> converter)
        {
            Validate(key);
            return converter(nameValues[key]);
        }

        public static bool GetBoolean(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToBoolean);
        }

        public static byte GetByte(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToByte);
        }

        public static char GetChar(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToChar);
        }

        public static DateTime GetDateTime(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToDateTime);
        }

        public static decimal GetDecimal(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToDecimal);
        }

        public static double GetDouble(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToDouble);
        }

        public static short GetInt16(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToInt16);
        }

        public static int GetInt32(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToInt32);
        }

        public static long GetInt64(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToInt64);
        }

        public static bool? GetNullableBoolean(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableBoolean);
        }

        public static byte? GetNullableByte(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableByte);
        }

        public static char? GetNullableChar(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableChar);
        }

        public static DateTime? GetNullableDateTime(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableDateTime);
        }

        public static decimal? GetNullableDecimal(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableDecimal);
        }

        public static double? GetNullableDouble(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableDouble);
        }

        public static short? GetNullableInt16(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableInt16);
        }

        public static int? GetNullableInt32(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableInt16);
        }

        public static long? GetNullableInt64(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableInt64);
        }

        public static sbyte? GetNullableSByte(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableSByte);
        }

        public static float? GetNullableSingle(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableSingle);
        }

        public static TimeSpan? GetNullableTimeSpan(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableTimeSpan);
        }

        public static ushort? GetNullableUInt16(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableUInt16);
        }

        public static uint? GetNullableUInt32(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableUInt32);
        }

        public static ulong? GetNullableUInt64(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToNullableUInt64);
        }

        public static sbyte GetSByte(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToSByte);
        }

        public static float GetSingle(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToSingle);
        }

        public static string GetString(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToString);
        }

        public static TimeSpan GetTimeSpan(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToTimeSpan);
        }

        public static ushort GetUInt16(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToUInt16);
        }

        public static uint GetUInt32(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToUInt32);
        }

        public static ulong GetUInt64(this NameValueCollection instance, string key)
        {
            return GetValueBase(instance, key, ValueConverter.ToUInt64);
        }
    }
}
