using Citicon.Data;
using System;

namespace Citicon.DataManager
{
    public static class EmploymentStatusManager
    {
        public static EmploymentStatus Parse(string value)
        {
            Enum.TryParse(value, out EmploymentStatus result);
            return result;
        }
    }
}
