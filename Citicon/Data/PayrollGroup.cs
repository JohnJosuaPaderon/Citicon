using Citicon.DataManager;
using Citicon.Extensions;
using System;
using System.Configuration;

namespace Citicon.Data
{
    public sealed class PayrollGroup : EntityBase<ushort>
    {
        static PayrollGroup()
        {
            _OfficeId = GetIdFromConfig(nameof(Office));
        }

        private static ushort GetIdFromConfig(string key)
        {
            var formattedKey = $"PayrollGroup.{key}.Id";
            var result = ConfigurationManager.AppSettings.GetUInt16(formattedKey);

            if (result == 0)
            {
                throw new InvalidOperationException($"Application Setting '{formattedKey}' was not found or had an invalid value.");
            }

            return result;
        }

        private static ushort _OfficeId;

        private static PayrollGroup _Office;

        public static PayrollGroup Office
        {
            get
            {
                if (_Office == null)
                {
                    _Office = PayrollGroupManager.Get(_OfficeId);
                }

                return _Office;
            }
        }

        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
