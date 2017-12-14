using System;
using System.Collections.Generic;
using System.Linq;

namespace Citicon.Data.Converters
{
    public static class ProjectTypeConverter
    {
        static ProjectTypeConverter()
        {
            ProjectTypeDisplays = new List<Tuple<ProjectType, string>>()
            {
                new Tuple<ProjectType, string>(ProjectType.Straight, "Straight"),
                new Tuple<ProjectType, string>(ProjectType.CementSupplied, "Cement Supplied")
            };
        }

        private static List<Tuple<ProjectType, string>> ProjectTypeDisplays { get; }

        public static ProjectType Parse(string value)
        {
            Enum.TryParse(value, out ProjectType result);

            return result;
        }

        public static string ToDisplay(ProjectType type)
        {
            return ProjectTypeDisplays.FirstOrDefault(pd => pd.Item1 == type)?.Item2;
        }

        public static ProjectType FromDisplay(string display)
        {
            return ProjectTypeDisplays.FirstOrDefault(pd => pd.Item2 == display)?.Item1 ?? ProjectType.Undefined;
        }
    }
}
