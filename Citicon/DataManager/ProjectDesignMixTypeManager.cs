using Citicon.Data;
using System;

namespace Citicon.DataManager
{
    public static class ProjectDesignMixTypeManager
    {
        public static ProjectDesignMixType Parse(string arg)
        {
            ProjectDesignMixType mixType;
            Enum.TryParse(arg, out mixType);
            return mixType;
        }
    }
}
