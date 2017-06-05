using System;

namespace Citicon.Data
{
    [Flags]
    public enum EmploymentStatus
    {
        NotSet = 0,
        Active = 1,
        Resigned = 2,
        Retired = 4
    }
}
