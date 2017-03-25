using System.Configuration;

namespace Citicon.Inventory.Data
{
    public sealed class Classification
    {
        public struct Codes
        {
            private static string GetCode(string key)
            {
                return ConfigurationManager.AppSettings[$"ClassificationCode.{key}"];
            }
            public static string Aggregate { get { return GetCode("Aggregate"); } }
        }

        public ulong Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }

        public static bool operator ==(Classification left, Classification right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Classification left, Classification right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Classification)
            {
                return (Classification)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
