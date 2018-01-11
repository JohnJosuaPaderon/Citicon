﻿namespace Citicon.Data
{
    public sealed class Company : EntityBase<ulong>
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
