using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class BillingStructureTypeManager
    {
        public static BillingStructureType DefaultValue
        {
            get
            {
                string name;

                ulong.TryParse(ConfigurationManager.AppSettings["BillingStructureTypeManager.DefaultValue.Id"], out ulong id);
                name = ConfigurationManager.AppSettings["BillingStructureTypeManager.DefaultValue.Name"] ?? $"[{nameof(BillingStructureType)}]";

                return new BillingStructureType()
                {
                    Id = id,
                    Name = name
                };
            }
        }

        public static async Task<IEnumerable<BillingStructureType>> GetListAsync()
        {
            using (var getBillingStructureTypeList = new GetBillingStructureTypeList())
            {
                return await getBillingStructureTypeList.GetAsync();
            }
        }

        public static async Task<bool> ExistsAsync(BillingStructureType structureType)
        {
            if (structureType != null)
            {
                using (var process =new BillingStructureTypeExists(structureType))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return false;
            }
        }

        public static async Task<BillingStructureType> InsertAsync(BillingStructureType structureType)
        {
            if (structureType != null)
            {
                using (var process = new InsertBillingStructureType(structureType))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<BillingStructureType> UpdateAsync(BillingStructureType structureType)
        {
            if (structureType != null)
            {
                using (var process = new UpdateBillingStructureType(structureType))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
