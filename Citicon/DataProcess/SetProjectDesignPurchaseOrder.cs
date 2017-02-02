using Citicon.Data;
using CTPMO.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class SetProjectDesignPurchaseOrder : IDisposable
    {
        public SetProjectDesignPurchaseOrder(PurchaseOrder purchaseOrder, List<ProjectDesign> projectDesignList)
        {
            if (purchaseOrder == null)
            {
                throw new ArgumentNullException(nameof(purchaseOrder));
            }

            if (projectDesignList == null)
            {
                throw new ArgumentNullException(nameof(projectDesignList));
            }

            if (projectDesignList.Count == 0)
            {
                throw new ArgumentException("Cannot be empty.", nameof(projectDesignList));
            }

            PurchaseOrder = purchaseOrder;
            ProjectDesignList = projectDesignList;
            ConnectionHelper = new MySqlConnectionHelper(Supports.ConnectionString);
        }

        private List<ProjectDesign> ProjectDesignList;
        private PurchaseOrder PurchaseOrder;
        private MySqlConnectionHelper ConnectionHelper;

        private MySqlCommand CreateCommand(ProjectDesign projectDesign, MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand("SetProjectDesignPurchaseOrderId", connection, transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@_PurchaseOrderId", PurchaseOrder.Id);
            command.Parameters.AddWithValue("@_ProjectDesignId", projectDesign.Id);
            return command;
        }

        private async Task<ProjectDesign> ExecuteSingleAsync(ProjectDesign projectDesign, MySqlConnection connection, MySqlTransaction transaction)
        {
            using (var command = CreateCommand(projectDesign, connection, transaction))
            {
                await command.ExecuteNonQueryAsync();
                return projectDesign;
            }
        }
        
        public async Task<List<ProjectDesign>> ExecuteAsync()
        {
            using (var connection = await ConnectionHelper.EstablishConnectionAsync())
            {
                if (connection.State == ConnectionState.Open)
                {
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        try
                        {
                            var projectDesignList = new List<ProjectDesign>();

                            foreach (ProjectDesign projectDesign in ProjectDesignList)
                            {
                                projectDesignList.Add(await ExecuteSingleAsync(projectDesign, connection, transaction));
                            }

                            transaction.Commit();
                            return projectDesignList;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public void Dispose()
        {
            ConnectionHelper = null;
        }
    }
}
