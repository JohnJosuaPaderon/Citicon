using Citicon.Data;
using Citicon.DataManager;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    public sealed class SearchStock : DataProcessBase
    {
        public SearchStock(SearchStockOptions options)
        {
            Options = options;
            _ItemManager = new ItemManager();
            _CompanyManager = new CompanyManager();
            _PaymentTermManager = new PaymentTermManager();
            _SupplierManager = new SupplierManager();
        }

        private SearchStockOptions Options { get; set; }
        private readonly ItemManager _ItemManager;
        private readonly CompanyManager _CompanyManager;
        private readonly PaymentTermManager _PaymentTermManager;
        private readonly SupplierManager _SupplierManager;

        private async Task<Stock> FromReaderAsync(DbDataReader reader)
        {
            return new Stock()
            {
                Item = _ItemManager.GetById(reader.GetUInt64("ItemId")),
                AddedStockValue = reader.GetDecimal("AddedStockValue"),
                Branch = BranchManager.GetById(reader.GetUInt64("BranchId")),
                Company = _CompanyManager.GetById(reader.GetUInt64("CompanyId")),
                DeliveryDate = reader.GetDateTime("DeliveryDate"),
                DrNumber = reader.GetUInt32("DrNumber"),
                Id = reader.GetUInt64("Id"),
                MrisNumber = reader.GetString("MrisNumber"),
                PaymentTerm = _PaymentTermManager.GetById(reader.GetUInt64("PaymentTermId")),
                Remarks = reader.GetString("Remarks"),
                SiNumber = reader.GetUInt32("SiNumber"),
                Supplier = _SupplierManager.GetById(reader.GetUInt64("SupplierId")),
                UnitPrice = reader.GetDecimal("UnitPrice"),
                Vehicle = await VehicleManager.GetByVehicleIdAsync(reader.GetUInt64("VehicleId"))
            };
        }

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            var command = Utility.CreateProcedureCommand("SearchStock", connection);
            command.Parameters.AddWithValue("@_SearchByItem", Options.SearchByItem);
            command.Parameters.AddWithValue("@_ItemId", Options.Item?.Id);
            command.Parameters.AddWithValue("@_SearchBySupplier", Options.SearchBySupplier);
            command.Parameters.AddWithValue("@_SupplierId", Options.Supplier?.Id);
            command.Parameters.AddWithValue("@_SearchByBranch", Options.SearchByBranch);
            command.Parameters.AddWithValue("@_BranchId", Options.Branch?.Id);
            command.Parameters.AddWithValue("@_SearchByDeliveryDateRange", Options.SearchByDeliveryDateRange);
            command.Parameters.AddWithValue("@_DeliveryDateBegin", Options.DeliveryDateRange.Start);
            command.Parameters.AddWithValue("@_DeliveryDateEnd", Options.DeliveryDateRange.End);
            command.Parameters.AddWithValue("@_SearchBySiNumber", Options.SearchBySiNumber);
            command.Parameters.AddWithValue("@_SiNumber", Options.SiNumber);
            command.Parameters.AddWithValue("@_SearchByDrNumber", Options.SearchByDrNumber);
            command.Parameters.AddWithValue("@_DrNumber", Options.DrNumber);

            return command;
        }

        public Task<IEnumerable<Stock>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
