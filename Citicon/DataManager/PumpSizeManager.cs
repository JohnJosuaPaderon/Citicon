using Citicon.Data;
using Citicon.DataProcess.PumpSizeProcesses;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class PumpSizeManager
    {
        static PumpSizeManager()
        {
            PumpSizes = new List<PumpSize>();
        }

        private static List<PumpSize> PumpSizes { get; }
        private static void Manage(PumpSize pumpSize)
        {
            if (pumpSize == null)
            {
                return;
            }

            if (PumpSizes.Contains(pumpSize))
            {
                var index = PumpSizes.IndexOf(pumpSize);
                PumpSizes[index] = pumpSize;
            }
            else
            {
                PumpSizes.Add(pumpSize);
            }
        }
        private static void Manage(IEnumerable<PumpSize> pumpSizes)
        {
            if (pumpSizes == null)
            {
                return;
            }

            foreach (PumpSize pumpSize in pumpSizes)
            {
                Manage(pumpSize);
            }
        }

        #region FromDbDataReader
        public static PumpSize FromDbDataReader(DbDataReader reader)
        {
            return new PumpSize()
            {
                Id = reader.GetUInt64("Id"),
                Value = reader.GetString("Value")
            };
        }
        #endregion

        #region GetList
        public static async Task<IEnumerable<PumpSize>> GetListAsync()
        {
            using (var process = new GetPumpSizeList())
            {
                var pumpSizes = await process.ExecuteAsync();
                Manage(pumpSizes);
                return pumpSizes;
            }
        }
        #endregion
    }
}
