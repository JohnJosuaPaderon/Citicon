using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public class GetBillingStructureTypeList : DataProcessBase
    {
        public async Task<IEnumerable<BillingStructureType>> GetAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
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
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        billingStructureTypes = null;
                    }
                    return billingStructureTypes;
                }
            }
        }
    }
}
