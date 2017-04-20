using Citicon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertDelivery : DataProcessBase
    {
        public InsertDelivery(Delivery delivery)
        {
            Delivery = delivery ?? throw new ArgumentNullException(nameof(delivery));
        }

        private Delivery Delivery;

        public override void Dispose()
        {
            Delivery = null;
            base.Dispose();
        }
    }
}
