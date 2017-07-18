using Citicon.Data;
using Citicon.Data.Converters;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetForApprovalQuotationMetaDataListByProject : DataProcessBase
    {
        public GetForApprovalQuotationMetaDataListByProject(Project project)
        {
            Project = project;
        }

        private Project Project { get; set; }

        public async Task<IEnumerable<Quotation>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var command = new MySqlCommand("GetForApprovalQuotationMetaDataListByProjectId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_ProjectId", Project.Id);
                        List<Quotation> quotations = null;
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                quotations = new List<Quotation>();

                                while (await reader.ReadAsync())
                                {
                                    quotations.Add(new Quotation()
                                    {
                                        Id = reader.GetUInt64("Id"),
                                        Number = reader.GetUInt32("Number"),
                                        QuotationDate = reader.GetDateTime("QuotationDate"),
                                        RevisionNumber = reader.GetUInt32("RevisionNumber"),
                                        NoteDetails = reader.GetString("NoteDetails"),
                                        Type = QuotationTypeConverter.Parse(reader.GetString("Type")),
                                        VatExcluded = reader.GetNullableDecimal("VatExcluded")
                                    });
                                }
                            }
                        }
                        return quotations;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
