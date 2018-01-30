using System;

namespace Citicon.Data
{
    public sealed class CancelledDelivery : EntityBase<ulong>
    {
        public Delivery Delivery { get; set; }
        public DateTime Date { get; set; }
        public string Remarks { get; set; }
    }
}
