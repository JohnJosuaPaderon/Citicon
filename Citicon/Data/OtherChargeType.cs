﻿namespace Citicon.Data
{
    public sealed class OtherChargeType : EntityBase<ulong>
    {
        public string Value { get; set; }
        
        public override string ToString()
        {
            return Value;
        }
    }
}
