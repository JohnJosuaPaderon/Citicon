using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertQuotation : DataProcessBase
    {
        public InsertQuotation(Quotation quotation)
        {
            Quotation = quotation ?? throw new ArgumentNullException(nameof(quotation));
        }

        private Quotation Quotation;
        private const string Parameter_Id = "@_Id";

        private MySqlCommand CreateCommand(MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = Utility.CreateProcedureCommand("InsertQuotation", connection, transaction);
            command.Parameters.Add(Utility.CreateOutParameter(Parameter_Id));
            command.Parameters.AddWithValue("@_ProjectId", Quotation.Project?.Id);
            command.Parameters.AddWithValue("@_QuoteDate", Quotation.QuotationDate);
            command.Parameters.AddWithValue("@_NoteDetails", Quotation.NoteDetails);
            command.Parameters.AddWithValue("@_Status", Quotation.Status.ToString());
            command.Parameters.AddWithValue("@_AgentId", Quotation.Agent?.Id);
            command.Parameters.AddWithValue("@_EngineerId", Quotation.EngineerId);
            command.Parameters.AddWithValue("@_EngineeringAmount", Quotation.EngineerAmount);
            command.Parameters.AddWithValue("@_RevisionNo", Quotation.RevisionNumber);
            command.Parameters.AddWithValue("@_Type", Quotation.Type.ToString());
            command.Parameters.AddWithValue("@_Number", Quotation.Number);

            return command;
        }

        public override void Dispose()
        {
            Quotation = null;
            base.Dispose();
        }

        public async Task<Quotation> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(connection, transaction))
            {
                if (await command.ExecuteNonQueryAsync() == 1)
                {
                    Quotation.Id = Convert.ToUInt64(command.Parameters[Parameter_Id].Value);
                }
                else
                {
                    Quotation = null;
                }

                return Quotation;
            }
        }

        public Task<Quotation> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
