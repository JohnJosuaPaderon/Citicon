using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GenerateQuotationNumberByType : DataProcessBase
    {
        public GenerateQuotationNumberByType(QuotationType quotationType)
        {
            QuotationType = quotationType;
        }

        private QuotationType QuotationType;
        private const string Parameter_Type = "@_Type";

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = new MySqlCommand()
            {
                Connection = connection,
                CommandText = string.Format("SELECT GenerateQuotationNumberByType({0});", Parameter_Type)
            };
            command.Parameters.AddWithValue(Parameter_Type, QuotationType.ToString());

            return command;
        }

        public Task<uint> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteScalarAsync(CreateCommand, Convert.ToUInt32);
        }
    }
}
