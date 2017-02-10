using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;

namespace Citicon.DataManager
{
    public class JobPositionManager
    {
        static JobPositionManager()
        {
            JobPositions = new Dictionary<long, JobPosition>();
        }

        private static Dictionary<long, JobPosition> JobPositions;

        public static JobPosition GetById(long id)
        {
            if (JobPositions.ContainsKey(id))
            {
                return JobPositions[id];
            }
            else
            {
                using (var getJobPositionById = new GetJobPositionById(id))
                {
                    var jobPosition = getJobPositionById.Return();
                    if (jobPosition != null)
                    {
                        JobPositions.Add(id, jobPosition);
                    }
                    return jobPosition;
                }
            }
        }
    }
}
