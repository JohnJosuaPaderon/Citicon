using Citicon.Data;
using Citicon.Data.Converters;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetQuotationById : DataProcessBase
    {
        public GetQuotationById(ulong quotationId)
        {
            QuotationId = quotationId;
        }
        
        private ulong QuotationId { get; }
        
        public async Task<Quotation> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
                                    Cost = 0,
                                    Type = QuotationTypeConverter.Parse(reader.GetString("Type")),
                                    Number = reader.GetUInt32("Number"),
                                    VatExcluded = reader.GetNullableDecimal("VatExcluded")
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
    }
}
