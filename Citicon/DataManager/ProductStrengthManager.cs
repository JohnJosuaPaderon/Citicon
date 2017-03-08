using Citicon.DataProcess;
using System.Collections.Generic;

namespace Citicon.DataManager
{
    public class ProductStrengthManager
    {
        static ProductStrengthManager()
        {
            Dictionary = new Dictionary<long, ProductStrength>();
        }

        private static Dictionary<long, ProductStrength> Dictionary { get; }

        public static ProductStrength GetById(long id)
        {
            if (Dictionary.ContainsKey(id))
            {
                return Dictionary[id];
            }

            var getById = new GetProductStrengthById(id);
            var strength = getById.Return();

            if (strength != null)
            {
                Dictionary.Add(id, strength);
            }

            return strength;
        }

        public static IEnumerable<ProductStrength> GetList()
        {
            var process = new GetProductStrengthList();
            return process.ExecuteReturn();
        }
    }
}
