using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(bool value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(byte value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(char value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(decimal value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(double value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(short value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(int value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(long value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(object value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static sbyte ToSByte(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(sbyte value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(float value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(string value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="long"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="fromBase"></param>
        /// <returns></returns>
        public static sbyte ToSByte(string value, int fromBase)
        {
            return ConversionBase(value, fromBase, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static sbyte ToSByte(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(ushort value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(uint value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }

        /// <summary>
        /// Converts value into <see cref="sbyte"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static sbyte ToSByte(ulong value)
        {
            return ConversionBase(value, Convert.ToSByte);
        }
    }
}
