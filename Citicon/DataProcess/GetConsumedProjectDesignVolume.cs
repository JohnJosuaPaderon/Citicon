using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetConsumedProjectDesignVolume : DataProcessBase
    {
        public GetConsumedProjectDesignVolume(ProjectDesign projectDesign)
        {
            ProjectDesign = projectDesign ?? throw new ArgumentNullException(nameof(projectDesign));
        }

        private ProjectDesign ProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                Connection = connection,
                CommandText = $"SELECT GetConsumedProjectDesignVolume({ProjectDesign.Id})"
            };

            return command;
        }

        public Task<decimal> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, Convert.ToDecimal);
        }
    }
}
