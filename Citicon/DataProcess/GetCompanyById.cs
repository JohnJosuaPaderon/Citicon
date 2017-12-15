using Citicon.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetCompanyById : DataProcessBase
    {
        public GetCompanyById(ulong companyId)
        {
            _CompanyId = companyId;
        }

        private readonly ulong _CompanyId;

        private Company FromReader(DbDataReader reader)
        {
            return new Company
            {
                Id = _CompanyId,
                Code = reader.GetString("Code"),
                Description = reader.GetString("Description")
            };
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("_companies_getbyid", connection);
            command.Parameters.AddWithValue("@_CompanyId", _CompanyId);
            return command;
        }

        public Task<Company> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingAsync(CreateCommand, FromReader);
        }
    }
}
