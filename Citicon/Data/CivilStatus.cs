using System;

namespace Citicon.Data
{
    [Flags]
    public enum CivilStatus
    {
        NotSet = 0,
        Single = 1,
        Married = 2,
        Separated = 4,
        Widow = 8
    }
}
