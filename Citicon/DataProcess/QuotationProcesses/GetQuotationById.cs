using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess.QuotationProcesses
{
    public sealed class GetQuotationById : IDisposable
    {
        #region Constructor
        public GetQuotationById(ulong quotationId)
        {
            QuotationId = quotationId;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private ulong QuotationId { get; }
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Execute
        public async Task<Quotation> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var command = new MySqlCommand("GetQuotationById", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_QuotationId", QuotationId);
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                await reader.ReadAsync();

                                return new Quotation()
                                {
                                    Id = QuotationId,
                                    Agent = await EmployeeManager.GetByIdAsync(reader.GetInt64("AgentId")),
                                    EngineerAmount = reader.GetDecimal("EngineerAmount"),
                                    EngineerId = reader.GetUInt64("EngineerId"),
                                    NoteDetails = reader.GetString("NoteDetails"),
                                    Project = await ProjectManager.GetByIdAsync(reader.GetUInt64("ProjectId")),
                                    QuotationDate = reader.GetDateTime("QuotationDate"),
                                    QuotationNumber = reader.GetString("QuotationNumber"),
                                    RevisionNumber = reader.GetUInt32("RevisionNumber"),
                                    Status = QuotationStatusManager.Parse(reader.GetString("Status")),
                                    Cost = 0
                                };
                            }

                            return null;
                        }
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
            ConnectionHelper = null;
        } 
        #endregion
    }
}
