using Citicon.Data;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCurrentProjectDesignLoadCutOff : DataProcessBase
    {
        public GetCurrentProjectDesignLoadCutOff(ProjectDesign design)
        {
            _Design = design ?? throw new ArgumentNullException(nameof(design));
        }

        private readonly ProjectDesign _Design;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetCurrentProjectDesignLoadCutOff), connection)
                .AddInParameter("@_DesignId", _Design?.Id);
        }

        private ProjectDesignLoadCutOff FromReader(DbDataReader reader)
        {
            return new ProjectDesignLoadCutOff
            {
                Design = _Design,
                Id = reader.GetUInt64("Id"),
                Begin = reader.GetNullableDateTime("Begin"),
                End = reader.GetNullableDateTime("End")
            };
        }

        public Task<ProjectDesignLoadCutOff> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
