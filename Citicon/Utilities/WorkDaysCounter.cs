using Citicon.Data;
using Citicon.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citicon.Utilities
{
    public static class WorkDaysCounter
    {
        public static async Task<(int WorkDays, int Holidays)> CountWorkDaysAsync(DriverPayrollEmployee payrollEmployee)
        {
            if (payrollEmployee == null || payrollEmployee.Employee == null || payrollEmployee.Payroll == null || payrollEmployee.Payroll.CutOff == null)
            {
                throw new ArgumentNullException(nameof(payrollEmployee));
            }

            var timeLogs = await EmployeeManager.GetTimeLogListAsync(payrollEmployee.Employee, payrollEmployee.Payroll.CutOff);

            if (timeLogs != null && timeLogs.Any())
            {
                var workdays = 0;
                var holidays = 0;
                var cleansedWorkdays = new List<TimeLog>();
                var cleansedHolidays = new List<TimeLog>();

                foreach (var timeLog in timeLogs)
                {
                    var date = timeLog.Login?.Date;

                    if (date == null)
                    {
                        if (timeLog.Type == TimeLogType.RegularWorkingHours)
                        {
                            workdays = -1;
                        }
                        else if (timeLog.Type == TimeLogType.SpecialHolidayWorkingHours)
                        {
                            holidays = -1;
                        }

                        return (workdays, holidays);
                    }
                    else if (timeLog.Type == TimeLogType.RegularWorkingHours) 
                    {
                        if (!cleansedWorkdays.Any(tl => tl.Login?.Date == date))
                        {
                            cleansedWorkdays.Add(timeLog);
                            workdays++;
                        }
                    }
                    else if (timeLog.Type == TimeLogType.SpecialHolidayWorkingHours)
                    {
                        if (!cleansedHolidays.Any(tl => tl.Login?.Date == date))
                        {
                            cleansedHolidays.Add(timeLog);
                            holidays++;
                        }
                    }
                }

                return (workdays, holidays);
            }
            else
            {
                return (0, 0);
            }
        }
    }
}
