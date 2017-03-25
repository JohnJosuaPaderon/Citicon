using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertScheduledProjectDesignList : DataProcessBase
    {
        public InsertScheduledProjectDesignList(List<ScheduledProjectDesign> scheduledDesigns)
        {
            if (scheduledDesigns == null)
            {
                throw new ArgumentNullException(nameof(scheduledDesigns));
            }

            if (scheduledDesigns.Count == 0)
            {
                throw new ArgumentException("List cannot be empty.", nameof(scheduledDesigns));
            }

            ScheduledDesigns = scheduledDesigns;
            Manager = new ScheduledProjectDesignManager();
        }

        private List<ScheduledProjectDesign> ScheduledDesigns;
        private ScheduledProjectDesignManager Manager;

        public override void Dispose()
        {
            ScheduledDesigns = null;
            Manager = null;
            base.Dispose();
        }

        public async Task<List<ScheduledProjectDesign>> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            for (int i = 0; i < ScheduledDesigns.Count; i++)
            {
                ScheduledDesigns[i] = await Manager.InsertAsync(ScheduledDesigns[i]);
            }

            return ScheduledDesigns;
        }

        public Task<List<ScheduledProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
