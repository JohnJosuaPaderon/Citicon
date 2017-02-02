using Citicon.Data;
using Citicon.DataManager;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class GetQuotationUserById : IDisposable
    {
        #region Constructor
        public GetQuotationUserById(ulong id)
        {
            Id = id;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }
        #endregion

        #region Properties
        private ulong Id { get; }
        private MySqlConnectionHelper ConnectionHelper { get; set; }
        #endregion

        #region Executes
        public async Task<QuotationUser> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
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
        #endregion

        #region IDisposable
        public void Dispose()
        {
            ConnectionHelper = null;
        } 
        #endregion
    }
}
