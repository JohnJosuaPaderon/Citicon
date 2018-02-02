using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;

namespace Citicon.DataManager
{
    public static class PayrollGroupManager
    {
        static PayrollGroupManager()
        {
            _Source = new Dictionary<ushort, PayrollGroup>();
        }

        private static Dictionary<ushort, PayrollGroup> _Source;

        public static PayrollGroup Get(ushort payrollGroupId)
        {
            if (payrollGroupId > 0)
            {
                if (_Source.ContainsKey(payrollGroupId))
                {
                    return _Source[payrollGroupId];
                }
                else
                {
                    using (var process = new GetPayrollGroup(payrollGroupId))
                    {
                        var result = process.Execute();

                        if (result != null)
                        {
                            _Source.Add(payrollGroupId, result);
                        }

                        return result;
                    }
                }
            }
            else
            {
                return null;
            }
        }
    }
}
