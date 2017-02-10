namespace Citicon.DataProcess
{
    public abstract class DataProcess
    {
        public DataProcess()
        {
            var connectionString = Supports.ConnectionString;
            Utility = new MySqlUtility(connectionString);
            ProcessUtility = new MySqlDataProcessUtility(connectionString);
        }

        protected MySqlUtility Utility { get; }
        protected MySqlDataProcessUtility ProcessUtility { get; }
    }
}
