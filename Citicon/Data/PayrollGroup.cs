using System;

namespace Citicon.Data
{
    public class PayrollGroup : IComparable<PayrollGroup>
    {
        public uint Id { get; set; }
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

        public static bool operator ==(PayrollGroup left, PayrollGroup right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(PayrollGroup left, PayrollGroup right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is PayrollGroup)
            {
                return (PayrollGroup)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
