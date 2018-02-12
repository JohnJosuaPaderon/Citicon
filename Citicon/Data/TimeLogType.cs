using Citicon.Extensions;
using System.Configuration;

namespace Citicon.Data
{
    public sealed class TimeLogType : EntityBase<ulong>
    {
        private const string CONFIG_PREFIX = "TimeLogType";

        static TimeLogType()
        {
            RegularWorkingHours = GetFromConfig(nameof(RegularWorkingHours));
            RegularOvertimeWorkingHours = GetFromConfig(nameof(RegularOvertimeWorkingHours));
            NightDifferentialWorkingHours = GetFromConfig(nameof(NightDifferentialWorkingHours));
            SundayWorkingHours = GetFromConfig(nameof(SundayWorkingHours));
            SpecialHolidayWorkingHours = GetFromConfig(nameof(SpecialHolidayWorkingHours));
            SpecialHolidayOvertimeWorkingHours = GetFromConfig(nameof(SpecialHolidayOvertimeWorkingHours));
        }

        public static TimeLogType RegularWorkingHours { get; }
        public static TimeLogType RegularOvertimeWorkingHours { get; }
        public static TimeLogType NightDifferentialWorkingHours { get; }
        public static TimeLogType SundayWorkingHours { get; }
        public static TimeLogType SpecialHolidayWorkingHours { get; }
        public static TimeLogType SpecialHolidayOvertimeWorkingHours { get; }

        private static TimeLogType GetFromConfig(string key)
        {
            var id = ConfigurationManager.AppSettings.GetUInt64($"{CONFIG_PREFIX}[{key}].Id");
            var description = ConfigurationManager.AppSettings.GetString($"{CONFIG_PREFIX}[{key}].Description");

            return new TimeLogType
            {
                Id = id,
                Description = description
            };
        }

        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
