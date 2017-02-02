using System;

namespace Citicon.Data
{
    public sealed class OperationTimeFrame
    {
        public ulong Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public static bool operator ==(OperationTimeFrame left, OperationTimeFrame right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }
        public static bool operator !=(OperationTimeFrame left, OperationTimeFrame right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is OperationTimeFrame)
            {
                return (OperationTimeFrame)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
