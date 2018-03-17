using Citicon.Data;
using Citicon.Extensions;
using Citicon.Utilities;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class ProjectDesignAlreadyDelivered : DataProcessBase
    {
        public ProjectDesignAlreadyDelivered(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign;
        }

        private readonly ProjectDesign ProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(ProjectDesignAlreadyDelivered), connection)
                .AddInParameter("@_ProjectDesignId", ProjectDesign?.Id);
        }

        public Task<bool> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, DbValueConverter.ToBoolean);
        }
    }
}
