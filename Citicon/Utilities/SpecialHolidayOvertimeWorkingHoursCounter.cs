using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citicon.Utilities
{
    public static class SpecialHolidayOvertimeWorkingHoursCounter
    {
        public static async Task<decimal> CountAsync(Employee employee, DateTimeRange cutOff)
        {
            if (employee == null || cutOff == null)
            {
                throw new ArgumentException("Employee or Cut-Off is null.");
            }

            var timeLogs = await PayrollManager.GetTimeLogListAsync(employee, TimeLogType.SpecialHolidayOvertimeWorkingHours, cutOff);

            if (timeLogs != null && timeLogs.Any())
            {
                var cleansed = Cleanse(timeLogs);

                if (cleansed == null)
                {
                    return -1;
                }
                else
                {
                    var result = 0M;

                    foreach (var timeLog in cleansed)
                    {
                        var totalHours = timeLog.Difference?.TotalHours ?? 0D;
                        result += Convert.ToDecimal(totalHours <= 0 ? 0 : Math.Round(totalHours, 2));
                    }

                    return result;
                }
            }
            else
            {
                return 0;
            }
        }

        private static IEnumerable<TimeLog> Cleanse(IEnumerable<TimeLog> timeLogs)
        {
            var result = new List<TimeLog>();
            var offset = new TimeSpan(2, 0, 0);

            foreach (var timeLog in timeLogs)
            {
                var login = GetLoginDate(timeLog.Login);
                var logout = GetLogoutDate(timeLog.Login);
                var timeLogin = timeLog.Login ?? default(DateTime);
                var timeLogout = timeLog.Logout ?? default(DateTime);

                if (timeLogin == default(DateTime) || timeLogout == default(DateTime))
                {
                    return null;
                }
                else if (login == default(DateTime) || logout == default(DateTime))
                {
                    return null;
                }
                else if (timeLog.Login?.IsBetweenDateTimes(login, logout, offset) ?? false)
                {
                    if (timeLogin < login)
                    {
                        timeLog.Login = login;
                    }

                    if (timeLogout > logout)
                    {
                        timeLog.Logout = logout;
                    }

                    if (result.Any(tl => tl.Login.Value.Date == timeLog.Login.Value.Date))
                    {
                        return null;
                    }
                    else
                    {
                        result.Add(timeLog);
                    }
                }
                else
                {
                    return null;
                }
            }

            return result;
        }

        private static DateTime GetLoginDate(DateTime? loginDate)
        {
            return loginDate?.Date.AddHours(17) ?? default(DateTime);
        }

        private static DateTime GetLogoutDate(DateTime? loginDate)
        {
            return loginDate?.Date.AddHours(22) ?? default(DateTime);
        }
    }
}
