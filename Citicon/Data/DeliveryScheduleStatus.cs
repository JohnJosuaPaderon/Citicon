namespace Citicon.Data
{
    public class DeliveryScheduleStatus
    {
        public static DeliveryScheduleStatus Scheduled { get; } = "Scheduled";
        public static DeliveryScheduleStatus Rescue { get; } = "Rescue";
        public static DeliveryScheduleStatus SpecialClient { get; } = "Special Client";

        private DeliveryScheduleStatus(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static implicit operator DeliveryScheduleStatus(string arg)
        {
            return new DeliveryScheduleStatus(arg);
        }

        public static explicit operator string(DeliveryScheduleStatus arg)
        {
            return arg?.Value;
        }

        public static bool operator ==(DeliveryScheduleStatus left, DeliveryScheduleStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeliveryScheduleStatus left, DeliveryScheduleStatus right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as DeliveryScheduleStatus;
            return Value.Equals(value.Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
