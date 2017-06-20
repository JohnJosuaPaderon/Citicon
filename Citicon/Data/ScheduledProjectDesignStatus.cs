using System;
using System.Configuration;

namespace Citicon.Data
{
    public class ScheduledProjectDesignStatus
    {
        static ScheduledProjectDesignStatus()
        {
            Rejected = GetFromConfig(nameof(Rejected));
            Approved = GetFromConfig(nameof(Approved));
            FinalApproved = GetFromConfig(nameof(FinalApproved));
            Pending = GetFromConfig(nameof(Pending));
        }

        private static ScheduledProjectDesignStatus GetFromConfig(string key)
        {
            return ConfigurationManager.AppSettings[$"{nameof(ScheduledProjectDesignStatus)}.{key}"];
        }

        public static ScheduledProjectDesignStatus Rejected { get; }
        public static ScheduledProjectDesignStatus Approved { get; }
        public static ScheduledProjectDesignStatus FinalApproved { get; }
        public static ScheduledProjectDesignStatus Pending { get; }

        public ScheduledProjectDesignStatus(string value)
        {
            Value = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Value is null or white space.", nameof(value)) : value.Trim();
        }

        public string Value { get; }

        public static implicit operator string(ScheduledProjectDesignStatus argument)
        {
            return argument.Value;
        }

        public static implicit operator ScheduledProjectDesignStatus(string argument)
        {
            return new ScheduledProjectDesignStatus(argument);
        }

        public static bool operator ==(ScheduledProjectDesignStatus left, ScheduledProjectDesignStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScheduledProjectDesignStatus left, ScheduledProjectDesignStatus right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            var value = obj as ScheduledProjectDesignStatus;
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
