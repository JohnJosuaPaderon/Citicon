using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PumpTypeManager
    {
        public static async Task<IEnumerable<PumpType>> GetListAsync()
        {
            using (var getPumpTypeList = new GetPumpTypeList())
            {
                return await getPumpTypeList.GetAsync();
            }
        }

        public static async Task<PumpType> InsertPumpTypeAsync(PumpType pumpType)
        {
            using (var insertPumpType = new InsertPumpType(pumpType))
            {
                return await insertPumpType.ExecuteAsync();
            }
        }

        public static async Task<PumpType> UpdatePumpTypeAsync(PumpType pumpType)
        {
            using (var updatePumpType = new UpdatePumpType(pumpType))
            {
                return await updatePumpType.ExecuteAsync();
            }
        }
    }
}
