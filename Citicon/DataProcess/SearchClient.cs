using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class SearchClient : DataProcessBase
    {
        public SearchClient(string searchKey)
        {
            _SearchKey = searchKey;
        }

        private readonly string _SearchKey;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(SearchClient), connection)
                .AddInParameter("@_SearchKey", _SearchKey);
        }

        private async Task<Client> FromReaderAsync(DbDataReader reader)
        {
            return new Client
            {
                Address = reader.GetString("Address"),
                CompanyName = reader.GetString("CompanyName"),
                ContactNumber = reader.GetString("ContactNumber"),
                Credit = reader.GetDecimal("Credit"),
                Designation = reader.GetString("Designation"),
                EmailAddress = reader.GetString("EmailAddress"),
                Employee = await EmployeeManager.GetByIdAsync(reader.GetInt64("EmployeeId")),
                FirstName = reader.GetString("FirstName"),
                Id = reader.GetUInt64("Id"),
                LastName = reader.GetString("LastName"),
                Legitimate = reader.GetBoolean("Legitimate"),
                MiddleName = reader.GetString("MiddleName"),
                PhotoPath = reader.GetString("PhotoPath"),
                Position = reader.GetString("Position"),
                PresidentMobileNumber = reader.GetString("PresidentMobileNumber"),
                PresidentName = reader.GetString("PresidentName"),
                PresidentTelephoneNumber = reader.GetString("PresidentTelephoneNumber"),
                Tin = reader.GetString("Tin"),
                Title = reader.GetString("Title")
            };
        }

        public Task<IEnumerable<Client>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
