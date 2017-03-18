using System;
using System.Data.Common;

namespace Citicon
{
    public static class DbDataReaderExtension
    {
        private static bool GetBoolean(object dbValue)
        {
            return Convert.ToBoolean(dbValue);
        }

        public static bool GetBoolean(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetBoolean);
        }

        private static byte GetByte(object dbValue)
        {
            byte.TryParse(dbValue.ToString(), out byte byteValue);
            return byteValue;
        }

        public static byte GetByte(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetByte);
        }

        private static char GetChar(object dbValue)
        {
            char.TryParse(dbValue.ToString(), out char charValue);
            return charValue;
        }

        public static char GetChar(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetChar);
        }

        private static DateTime GetDateTime(object dbValue)
        {
            DateTime.TryParse(dbValue.ToString(), out DateTime dateTimeValue);
            return dateTimeValue;
        }

        public static DateTime GetDateTime(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetDateTime);
        }

        private static decimal GetDecimal(object dbValue)
        {
            decimal.TryParse(dbValue.ToString(), out decimal decimalValue);
            return decimalValue;
        }

        public static decimal GetDecimal(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetDecimal);
        }

        private static double GetDouble(object dbValue)
        {
            double.TryParse(dbValue.ToString(), out double doubleValue);
            return doubleValue;
        }

        public static double GetDouble(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetDouble);
        }

        private static short GetInt16(object dbValue)
        {
            short.TryParse(dbValue.ToString(), out short shortValue);
            return shortValue;
        }

        public static short GetInt16(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetInt16);
        }

        private static int GetInt32(object dbValue)
        {
            int.TryParse(dbValue.ToString(), out int intValue);
            return intValue;
        }

        public static int GetInt32(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetInt32);
        }

        private static long GetInt64(object dbValue)
        {
            long.TryParse(dbValue.ToString(), out long longValue);
            return longValue;
        }

        public static long GetInt64(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetInt64);
        }

        private static sbyte GetSByte(object dbValue)
        {
            sbyte.TryParse(dbValue.ToString(), out sbyte sbyteValue);
            return sbyteValue;
        }

        public static sbyte GetSByte(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetSByte);
        }

        private static float GetSingle(object dbValue)
        {
            float.TryParse(dbValue.ToString(), out float floatValue);
            return floatValue;
        }

        public static float GetSingle(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetSingle);
        }

        public static string GetString(this DbDataReader dataReader, string fieldName)
        {

            var dbValue = dataReader[fieldName];

            if (dbValue == null || dbValue == DBNull.Value)
            {
                return default(string);
            }

            return Convert.ToString(dbValue);
        }

        private static ushort GetUInt16(object dbValue)
        {
            ushort.TryParse(dbValue.ToString(), out ushort ushortValue);
            return ushortValue;
        }

        public static ushort GetUInt16(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetUInt16);
        }

        private static uint GetUInt32(object dbValue)
        {
            uint.TryParse(dbValue.ToString(), out uint uintValue);
            return uintValue;
        }

        public static uint GetUInt32(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetUInt32);
        }

        public static ulong GetUInt64(this DbDataReader reader, string fieldName)
        {
            return GetValue(reader, fieldName, GetUInt64);
        }

        private static ulong GetUInt64(object dbValue)
        {
            ulong.TryParse(dbValue.ToString(), out ulong ulongValue);
            return ulongValue;
        }

        private static T GetValue<T>(DbDataReader reader, string fieldName, Func<object, T> getValue)
        {
            var dbValue = reader[fieldName];

            if (dbValue == null || dbValue == DBNull.Value)
            {
                return default(T);
            }
            else
            {
                return getValue(dbValue);
            }
        }

        public static bool? GetNullableBoolean(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetBoolean);
        }

        public static byte? GetNullableByte(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetByte);
        }

        public static char? GetNullableChar(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetChar);
        }

        public static DateTime? GetNullableDateTime(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetDateTime);
        }

        public static decimal? GetNullableDecimal(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetDecimal);
        }

        public static double? GetNullableDouble(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetDouble);
        }

        public static short? GetNullableInt16(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetInt16);
        }

        public static int? GetNullableInt32(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetInt32);
        }

        public static long? GetNullableInt64(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetInt64);
        }

        public static float? GetNullableSingle(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetSingle);
        }

        public static sbyte? GetNullableSByte(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetSByte);
        }

        public static ushort? GetNullableUInt16(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetUInt16);
        }

        public static uint? GetNullableUInt32(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetUInt32);
        }

        public static ulong? GetNullableUInt64(this DbDataReader reader, string fieldName)
        {
            return GetNullableValue(reader, fieldName, GetUInt64);
        }

        private static T? GetNullableValue<T>(DbDataReader reader, string fieldName, Func<object, T> getValue)
            where T : struct
        {
            var dbvalue = reader[fieldName];

            if (dbvalue == null || dbvalue == DBNull.Value)
            {
                return null;
            }
            else
            {
                return getValue(dbvalue);
            }
        }
    }
}
