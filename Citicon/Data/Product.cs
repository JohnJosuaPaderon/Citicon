using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon
{
    public class Product
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public long DesignId { get; set; }
        public double PricePerCubicMeter { get; set; }
        public int InitialVolume { get; set; }
        public string Remarks { get; set; }
        public bool IsBilled { get; set; }
        public string DesignMixType { get; set; }
        public ProductStrength Strength { get; set; }
        public ProductAggregate Aggregate { get; set; }
        public double Psi { get; set; }
    }

    public class ProductAggregate
    {
        public long Id { get; set; }
        public string Value { get; set; }


        public static bool operator ==(ProductAggregate left, ProductAggregate right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if ((object)left == null || (object)right == null)
            {
                return false;
            }

            return left.Id == right.Id;
        }

        public static bool operator !=(ProductAggregate left, ProductAggregate right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return (obj is ProductAggregate) ? (ProductAggregate)obj == this : false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public class ProductStrength
    {
        public long Id { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }


        public static bool operator ==(ProductStrength left, ProductStrength right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if ((object)left == null || (object)right == null)
            {
                return false;
            }

            return left.Id == right.Id;
        }

        public static bool operator !=(ProductStrength left, ProductStrength right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return (obj is ProductStrength) ? (ProductStrength)obj == this : false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
