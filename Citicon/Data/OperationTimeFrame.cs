using System;

namespace Citicon.Data
{
    public sealed class OperationTimeFrame : EntityBase<ulong>
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
