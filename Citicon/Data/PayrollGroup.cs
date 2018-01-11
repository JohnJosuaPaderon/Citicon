using System;

namespace Citicon.Data
{
    public class PayrollGroup : EntityBase<uint>, IComparable<PayrollGroup>
    {
        public string Description { get; set; }
        public uint SortCode { get; set; }

        public int CompareTo(PayrollGroup other)
        {
            if (SortCode > other.SortCode)
            {
                return 1;
            }
            else if (SortCode < other.SortCode)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
