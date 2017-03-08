using Citicon.Data;
using Citicon.DataProcess.AccessoryTypeProcesses;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class AccessoryTypeManager
    {
        static AccessoryTypeManager()
        {
            AccessoryTypes = new List<AccessoryType>();
        }

        private static List<AccessoryType> AccessoryTypes { get; }

        private static AccessoryType Manage(AccessoryType accessoryType)
        {
            if (AccessoryTypes.Contains(accessoryType))
            {
                var index = AccessoryTypes.IndexOf(accessoryType);
                AccessoryTypes[index] = accessoryType;
            }
            else
            {
                AccessoryTypes.Add(accessoryType);
            }

            return accessoryType;
        }

        private static IEnumerable<AccessoryType> Manage(IEnumerable<AccessoryType> accessoryTypes)
        {
            foreach (AccessoryType accessoryType in accessoryTypes)
            {
                Manage(accessoryType);
            }

            return accessoryTypes;
        }

        public static AccessoryType FromDbDataReader(DbDataReader reader)
        {
            return new AccessoryType()
            {
                Id = reader.GetUInt64("Id"),
                Value = reader.GetString("Value")
            };
        }

        #region GetList
        public static async Task<IEnumerable<AccessoryType>> GetListAsync()
        {
            using (var process = new GetAccessoryTypeList())
            {
                return Manage(await process.ExecuteAsync());
            }
        }
        #endregion
    }
}
