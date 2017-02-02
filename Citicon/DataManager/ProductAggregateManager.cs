using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class ProductAggregateManager
    {
        public static ProductAggregate GetById(long id)
        {
            var getById = new GetProductAggregateById(id);
            return getById.Return();
        }

        public static IEnumerable<ProductAggregate> GetList()
        {
            var process = new GetProductAggregateList();
            return process.ExecuteReturn();
        }
    }
}
