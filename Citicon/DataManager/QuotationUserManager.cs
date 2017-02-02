using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class QuotationUserManager
    {
        public static async Task<QuotationUser> InsertAsync(QuotationUser quotationUser)
        {
            using (var process = new InsertQuotationUser(quotationUser))
            {
                return await process.ExecuteAsync();
            }
        }

        public static async Task<QuotationUser> GetByIdAsync(ulong id)
        {
            using (var process = new GetQuotationUserById(id))
            {
                return await process.ExecuteAsync();
            }
        }
    }
}
