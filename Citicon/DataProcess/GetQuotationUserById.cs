using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetQuotationUserById : DataProcessBase
    {
        public GetQuotationUserById(ulong id)
        {
            Id = id;
        }

        private ulong Id { get; }

        public async Task<QuotationUser> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetQuotationUserById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_Id", Id);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            await reader.ReadAsync();
                            return new QuotationUser((new UserManager()).GetById(Id))
                            {
                                RedirectToFinalApproval = reader.GetBoolean("RedirectToFinalApproval")
                            };
                        }

                        return null;
                    }
                }
            }
        }
    }
}
