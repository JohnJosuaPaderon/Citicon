using Citicon.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class SetProjectDesignPurchaseOrder : DataProcessBase
    {
        public SetProjectDesignPurchaseOrder(PurchaseOrder purchaseOrder, List<ProjectDesign> projectDesignList)
        {
            if (projectDesignList == null)
            {
                throw new ArgumentNullException(nameof(projectDesignList));
            }

            if (projectDesignList.Count == 0)
            {
                throw new ArgumentException("Cannot be empty.", nameof(projectDesignList));
            }

            PurchaseOrder = purchaseOrder ?? throw new ArgumentNullException(nameof(purchaseOrder));
            ProjectDesignList = projectDesignList;
        }

        private List<ProjectDesign> ProjectDesignList;
        private PurchaseOrder PurchaseOrder;

        private MySqlCommand CreateCommand(ProjectDesign projectDesign, MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand("SetProjectDesignPurchaseOrderId", connection, transaction)
            {
                CommandType = CommandType.StoredProcedure
            };
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
        
        public async Task<List<ProjectDesign>> ExecuteAsync(MySqlConnection connection, MySqlTransaction transaction)
        {
            var projectDesignList = new List<ProjectDesign>();

            foreach (ProjectDesign projectDesign in ProjectDesignList)
            {
                projectDesignList.Add(await ExecuteSingleAsync(projectDesign, connection, transaction));
            }
            
            return projectDesignList;
        }

        public Task<List<ProjectDesign>> ExecuteAsync()
        {
            return ProcessUtility.HandleExecuteAsync(ExecuteAsync);
        }
    }
}
