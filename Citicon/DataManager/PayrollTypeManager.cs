using Citicon.Data;
using System;

namespace Citicon.DataManager
{
    public static class PayrollTypeManager
    {
        public static PayrollType Parse(string value)
        {
            Enum.TryParse(value, out PayrollType result);
            return result;
        }
    }
}
