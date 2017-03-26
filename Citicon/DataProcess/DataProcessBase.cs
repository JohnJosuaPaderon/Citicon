using System;

namespace Citicon.DataProcess
{
    public abstract class DataProcessBase : IDisposable
    {
        public DataProcessBase()
        {
            var connectionString = Supports.ConnectionString;
            Utility = new MySqlUtility(connectionString);
            ProcessUtility = new MySqlDataProcessUtility(connectionString);
        }

        protected MySqlUtility Utility { get; private set; }
        protected MySqlDataProcessUtility ProcessUtility { get; private set; }

        public virtual void Dispose()
        {
            Utility = null;
            ProcessUtility = null;
        }
    }
}
