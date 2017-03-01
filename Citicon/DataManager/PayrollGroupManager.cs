using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class PayrollGroupManager
    {
        static PayrollGroupManager()
        {
            Dictionary = new Dictionary<uint, PayrollGroup>();
        }

        private static Dictionary<uint, PayrollGroup> Dictionary { get; }

        public async Task<IEnumerable<PayrollGroup>> GetListAsync()
        {
            var process = new GetPayrollGroupList();
            return await process.ExecuteAsync();
        }

        public async Task<PayrollGroup> GetByIdAsync(uint payrollGroupId)
        {
            if (payrollGroupId > 0)
            {
                if (Dictionary.ContainsKey(payrollGroupId))
                {
                    return Dictionary[payrollGroupId];
                }

                var process = new GetPayrollGroupById(payrollGroupId);
                var payrollGroup = await process.ExecuteAsync();

                if (payrollGroup != null)
                {
                    Dictionary.Add(payrollGroupId, payrollGroup);
                }

                return payrollGroup;
            }
            else
            {
                return null;
            }
        }
    }
}
