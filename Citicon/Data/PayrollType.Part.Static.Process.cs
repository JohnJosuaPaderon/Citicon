using Citicon.Extensions;
using System;
using System.Configuration;

namespace Citicon.Data
{
    partial class PayrollType
    {
        private static ushort GetIdFromConfig(string key)
        {
            var formattedKey = $"PayrollType.{key}.Id";
            var result = ConfigurationManager.AppSettings.GetUInt16(formattedKey);

            if (result == 0)
            {
                throw new InvalidOperationException($"Application Setting '{formattedKey}' was not found or had an invalid value.");
            }
            else
            {
                return result;
            }
        }
    }
}
