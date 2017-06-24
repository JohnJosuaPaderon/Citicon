using Citicon.Data;
using Citicon.DataProcess;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public static Task<IEnumerable<JobPosition>> GetListAsync()
        {
            using (var process = new GetJobPositionList())
            {
                return process.ExecuteAsync();
            }
        }

        public static async Task<JobPosition> InsertAsync(JobPosition jobPosition)
        {
            if (jobPosition != null)
            {
                using (var process = new InsertJobPosition(jobPosition))
                {
                    jobPosition = await process.ExecuteAsync();

                    if (jobPosition != null && !JobPositions.ContainsKey(jobPosition.Id))
                    {
                        JobPositions.Add(jobPosition.Id, jobPosition);
                    }
                }
            }

            return jobPosition;
        }

        public static async Task<JobPosition> UpdateAsync(JobPosition jobPosition)
        {
            if (jobPosition != null)
            {
                using (var process = new UpdateJobPosition(jobPosition))
                {
                    jobPosition = await process.ExecuteAsync();

                    if (jobPosition != null && JobPositions.ContainsKey(jobPosition.Id))
                    {
                        JobPositions[jobPosition.Id] = jobPosition;
                    }
                }
            }

            return jobPosition;
        }
    }
}
