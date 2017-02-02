using Citicon.Data;
using CTPMO.Extensions;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetBillingStructureTypeList : IDisposable
    {
        private MySqlConnectionHelper ConnectionHelper;

        public GetBillingStructureTypeList()
        {
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<BillingStructureType>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetBillStructureTypeList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    List<BillingStructureType> billingStructureTypes = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                billingStructureTypes = new List<BillingStructureType>();
                                while (await reader.ReadAsync())
                                {
                                    billingStructureTypes.Add(new BillingStructureType()
                                    {
                                        Id = reader.GetUInt64("Id"),
                                        Name = reader.GetString("Name")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        billingStructureTypes = null;
                    }
                    return billingStructureTypes;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
