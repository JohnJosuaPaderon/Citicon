using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class ResetProjectDesignLoadCutOff : DataProcessBase
    {
        public ResetProjectDesignLoadCutOff(ProjectDesign projectDesign)
        {
            _ProjectDesign = projectDesign;
        }

        private readonly ProjectDesign _ProjectDesign;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(ResetProjectDesignLoadCutOff), connection, transaction)
                .AddOutParameter("@_Id")
                .AddOutParameter("@_Begin")
                .AddInParameter("@_DesignId", _ProjectDesign.Id);
        }

        public async Task<ProjectDesignLoadCutOff> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                var result = new ProjectDesignLoadCutOff
                {
                    Id = command.Parameters.GetUInt64("@_Id"),
                    Design = _ProjectDesign,
                    Begin = command.Parameters.GetNullableDateTime("@_Begin")
                };

                return result;
            }
        }

        public Task<ProjectDesignLoadCutOff> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
