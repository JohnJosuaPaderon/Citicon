using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class SalesInvoiceManager
    {
        public static async Task<IEnumerable<SalesInvoice>> GetUnpaidListByProject(Project project)
        {
            using (var getUnpaidSalesInvoiceListByProject = new GetUnpaidSalesInvoiceListByProject(project))
            {
                return await getUnpaidSalesInvoiceListByProject.GetAsync();
            }
        }
    }
}
