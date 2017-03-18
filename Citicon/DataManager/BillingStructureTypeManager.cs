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
    }
}
