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
    public class GetUnpaidSalesInvoiceListByProject : IDisposable
    {
        private Project Project;
        private MySqlConnectionHelper ConnectionHelper;

        public GetUnpaidSalesInvoiceListByProject(Project project)
        {
            Project = project;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        public async Task<IEnumerable<SalesInvoice>> GetAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                using (var command = new MySqlCommand("GetUnpaidSalesInvoiceListByProjectId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_ProjectId", Project.Id);
                    List<SalesInvoice> salesInvoices = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                salesInvoices = new List<SalesInvoice>();
                                while (await reader.ReadAsync())
                                {
                                    salesInvoices.Add(new SalesInvoice
                                    {
                                        Number = reader.GetString("Number"),
                                        TotalAmountDue = reader.GetDecimal("TotalAmountDue")
                                    });
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        salesInvoices = null;
                        throw;
                    }
                    return salesInvoices;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
