using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetForApprovalQuotationMetaDataListByProject : IDisposable
    {
        #region Constructor
        public GetForApprovalQuotationMetaDataListByProject(Project project)
        {
            Project = project;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private Project Project { get; set; }
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Execute
        public async Task<IEnumerable<Quotation>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
                                        QuotationNumber = reader.GetString("QuotationNumber"),
                                        QuotationDate = reader.GetDateTime("QuotationDate"),
                                        RevisionNumber = reader.GetUInt32("RevisionNumber"),
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            Project = null;
            ConnectionHelper = null;
        } 
        #endregion
    }
}
