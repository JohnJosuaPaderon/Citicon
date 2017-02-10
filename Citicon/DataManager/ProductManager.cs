using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class ProductManager
    {
        public static IEnumerable<ProjectDesign> GetListByProjectId(Project project)
        {
            var getListByProjectId = new GetProductListByProjectId(project);
            return getListByProjectId.Return();
        }

        public static async Task SaveEditedProductAsync(ProjectDesign projectDesign)
        {
            using (var saveEditedProduct = new SaveEditedProduct(projectDesign))
            {
                await saveEditedProduct.ExecuteAsync();
            }
        }
    }
}
