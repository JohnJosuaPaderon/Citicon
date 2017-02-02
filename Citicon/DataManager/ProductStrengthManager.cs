using Citicon.DataProcess;
using System.Collections.Generic;

namespace Citicon.DataManager
{
    public class ProductStrengthManager
    {
        public static ProductStrength GetById(long id)
        {
            var getById = new GetProductStrengthById(id);
            return getById.Return();
        }

        public static IEnumerable<ProductStrength> GetList()
        {
            var process = new GetProductStrengthList();
            return process.ExecuteReturn();
        }
    }
}
