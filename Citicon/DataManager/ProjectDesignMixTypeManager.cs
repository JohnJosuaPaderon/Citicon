using Citicon.Data;
using System;

namespace Citicon.DataManager
{
    public static class ProjectDesignMixTypeManager
    {
        public static ProjectDesignMixType Parse(string arg)
        {
            Enum.TryParse(arg, out ProjectDesignMixType mixType);
            return mixType;
        }
    }
}
