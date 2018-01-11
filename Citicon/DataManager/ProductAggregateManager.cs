using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;

namespace Citicon.DataManager
{
    public class ProductAggregateManager
    {
        static ProductAggregateManager()
        {
            Dictionary = new Dictionary<long, ProductAggregate>();
        }

        private static Dictionary<long, ProductAggregate> Dictionary { get; }

        public static ProductAggregate GetById(long id)
        {
            if (Dictionary.ContainsKey(id))
            {
                return Dictionary[id];
            }

            var getById = new GetProductAggregateById(id);
            var aggregate = getById.Return();

            if (aggregate != null)
            {
                Dictionary.Add(id, aggregate);
            }

            return aggregate;
        }

        public static IEnumerable<ProductAggregate> GetList()
        {
            var process = new GetProductAggregateList();
            return process.ExecuteReturn();
        }
    }
}
