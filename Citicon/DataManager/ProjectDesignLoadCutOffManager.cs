using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class ProjectDesignLoadCutOffManager
    {
        public static async Task<ProjectDesignLoadCutOff> ResetAsync(ProjectDesign design)
        {
            if (design != null)
            {
                using (var process = new ResetProjectDesignLoadCutOff(design))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<ProjectDesignLoadCutOff> GetCurrentAsync(ProjectDesign design)
        {
            if (design != null)
            {
                using (var process = new GetCurrentProjectDesignLoadCutOff(design))
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
