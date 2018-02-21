using System;

namespace Citicon.Data
{
    public class SystemUserStatus : EntityBase<ushort>
    {
        static SystemUserStatus()
        {
            throw new NotImplementedException("Set static properties.");
        }

        public static SystemUserStatus Active { get; }
        public static SystemUserStatus Inactive { get; }

        public SystemUserStatus(ushort id, string key, string name)
        {
            Id = id;
            Key = key;
            Name = name;
        }

        public string Key { get; }
        public string Name { get; }
    }
}
