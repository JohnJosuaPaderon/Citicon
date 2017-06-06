using Citicon.Data;
using System;

namespace Citicon.DataManager
{
    public static class CivilStatusManager
    {
        public static CivilStatus Parse(string value)
        {
            Enum.TryParse(value, out CivilStatus result);
            return result;
        }
    }
}
