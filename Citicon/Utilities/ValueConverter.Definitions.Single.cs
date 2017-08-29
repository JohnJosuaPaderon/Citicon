using System;

namespace Citicon.Utilities
{
    partial class ValueConverter
    {
        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(bool value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(byte value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(decimal value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(double value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(short value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(int value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(long value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(object value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static float ToSingle(object value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(sbyte value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type; No actual conversion performed
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(float value)
        {
            return value;
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(string value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type using the specified formatProvider
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <param name="formatProvider">Formatting information to be used</param>
        /// <returns></returns>
        public static float ToSingle(string value, IFormatProvider formatProvider)
        {
            return ConversionBase(value, formatProvider, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(ushort value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(uint value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }

        /// <summary>
        /// Converts value into <see cref="float"/> type
        /// </summary>
        /// <param name="value">The value to be converted</param>
        /// <returns></returns>
        public static float ToSingle(ulong value)
        {
            return ConversionBase(value, Convert.ToSingle);
        }
    }
}
