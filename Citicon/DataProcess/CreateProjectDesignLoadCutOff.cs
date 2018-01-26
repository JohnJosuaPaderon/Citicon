using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class CreateProjectDesignLoadCutOff : DataProcessBase
    {
        public CreateProjectDesignLoadCutOff(ProjectDesignLoadCutOff projectDesignLoadCutOff)
        {
            _ProjectDesignLoadCutOff = projectDesignLoadCutOff ?? throw new ArgumentNullException(nameof(projectDesignLoadCutOff));
        }

        private readonly ProjectDesignLoadCutOff _ProjectDesignLoadCutOff;

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            return Utility.CreateProcedureCommand(nameof(CreateProjectDesignLoadCutOff), connection, transaction)
                .AddOutParameter("@_Id")
                .AddInParameter("@_DesignId", _ProjectDesignLoadCutOff.Design?.Id)
                .AddInParameter("@_Begin", _ProjectDesignLoadCutOff.Begin)
                .AddInParameter("@_End", _ProjectDesignLoadCutOff.End);
        }

        public async Task<ProjectDesignLoadCutOff> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                _ProjectDesignLoadCutOff.Id = command.Parameters.GetUInt64("@_Id");
                return _ProjectDesignLoadCutOff;
            }
        }

        public Task<ProjectDesignLoadCutOff> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
