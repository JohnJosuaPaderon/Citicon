using Citicon.Data;
using Citicon.DataProcess.OtherChargeTypeProcesses;
using CTPMO.Extensions;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class OtherChargeTypeManager
    {
        static OtherChargeTypeManager()
        {
            OtherChargeTypes = new List<OtherChargeType>();
        }

        private static List<OtherChargeType> OtherChargeTypes { get; }
        private static OtherChargeType Manage(OtherChargeType otherChargeType)
        {
            if (OtherChargeTypes.Contains(otherChargeType))
            {
                var index = OtherChargeTypes.IndexOf(otherChargeType);
                OtherChargeTypes[index] = otherChargeType;
            }
            else
            {
                OtherChargeTypes.Add(otherChargeType);
            }

            return otherChargeType;
        }
        private static IEnumerable<OtherChargeType> Manage(IEnumerable<OtherChargeType> otherChargeTypes)
        {
            foreach (OtherChargeType otherChargeType in otherChargeTypes)
            {
                Manage(otherChargeType);
            }

            return otherChargeTypes;
        }

        #region FromDbDataReader
        public static OtherChargeType FromDbDataReader(DbDataReader reader)
        {
            return new OtherChargeType()
            {
                Id = reader.GetUInt64("Id"),
                Value = reader.GetString("Value")
            };
        }
        #endregion

        #region GetList
        public static async Task<IEnumerable<OtherChargeType>> GetListAsync()
        {
            using (var process = new GetOtherChargeTypeList())
            {
                return Manage(await process.ExecuteAsync());
            }
        }
        #endregion
    }
}
