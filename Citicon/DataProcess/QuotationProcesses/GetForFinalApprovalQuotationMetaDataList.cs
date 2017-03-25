using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetForFinalApprovalQuotationMetaDataList : DataProcessBase
    {
        public async Task<IEnumerable<Quotation>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var command = new MySqlCommand("GetQuotationMetaDataListForFinalApproval", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
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
                                        QuotationNumber = reader.GetString("QuotationNumber"),
                                        QuotationDate = reader.GetDateTime("QuotationDate"),
                                        RevisionNumber = reader.GetUInt32("RevisionNumber"),
                                        Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                                        NoteDetails = reader.GetString("NoteDetails")
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
