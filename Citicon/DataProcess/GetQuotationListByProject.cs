using Citicon.Data;
using Citicon.Data.Converters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetQuotationListByProject : DataProcessBase
    {
        public GetQuotationListByProject(Project project)
        {
            Project = project ?? throw new ArgumentNullException(nameof(project));
        }

        private Project Project;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("GetQuotationListByProject", connection);
            command.Parameters.AddWithValue("@_ProjectId", Project.Id);

            return command;
        }

        public override void Dispose()
        {
            Project = null;
            base.Dispose();
        }

        public Task<IEnumerable<Quotation>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReader);
        }

        private Quotation FromReader(DbDataReader reader)
        {
            return new Quotation()
            {
                Id = reader.GetUInt64("Id"),
                Project = Project,
                QuotationNumber = reader.GetString("QuotationNumber"),
                RevisionNumber = reader.GetUInt32("RevisionNumber"),
                Type = QuotationTypeConverter.Parse(reader.GetString("Type")),
                Number = reader.GetUInt32("Number"),
                VatExcluded = reader.GetNullableDecimal("VatExcluded")
            };
        }
    }
}
