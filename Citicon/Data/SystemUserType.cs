using System;

namespace Citicon.Data
{
    public class SystemUserType : EntityBase<ushort>
    {
        static SystemUserType()
        {
            throw new NotImplementedException("Set static properties.");
        }

        public static SystemUserType Administrator { get; }
        public static SystemUserType Module { get; }

        public SystemUserType(ushort id, string key, string name)
        {
            Id = id;
            Key = key;
            Name = name;
        }

        public string Key { get; }
        public string Name { get; }
    }
}
