using System.Data;
using System.Data.Common;

namespace Citicon
{
    public abstract class RelationalDatabaseUtility
    {
        public RelationalDatabaseUtility(string connectionString)
        {
            _ConnectionString = connectionString;
        }

        private string _ConnectionString;

        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            protected set
            {
                _ConnectionString = value;
            }
        }

        public bool IsConnectionNotNullAndOpen(DbConnection connection)
        {
            return connection != null && connection.State == ConnectionState.Open;
        }
    }
}
