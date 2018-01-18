using Citicon.Data;
using Citicon.DataManager;
using Citicon.Extensions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class GetFilteredOutgoingStockList : DataProcessBase
    {
        public GetFilteredOutgoingStockList(GetFilteredOutgoingStockListOption option)
        {
            _Option = option;
            _ItemManager = new ItemManager();
            _MeasurementUnitManager = new MeasurementUnitManager();
            _SupplierManager = new SupplierManager();
        }

        private readonly GetFilteredOutgoingStockListOption _Option;
        private readonly ItemManager _ItemManager;
        private readonly MeasurementUnitManager _MeasurementUnitManager;
        private readonly SupplierManager _SupplierManager;

        private MySqlCommand CreateCommand(MySqlConnection connection)
        {
            return Utility.CreateProcedureCommand(nameof(GetFilteredOutgoingStockList), connection)
                .AddInParameter("@_FilterByItem", _Option.FilterByItem)
                .AddInParameter("@_ItemId", _Option.Item?.Id)
                .AddInParameter("@_FilterByBranch", _Option.FilterByBranch)
                .AddInParameter("@_BranchId", _Option.Branch?.Id)
                .AddInParameter("@_FilterByCompany", _Option.FilterByCompany)
                .AddInParameter("@_CompanyId", _Option.Company?.Id)
                .AddInParameter("@_FilterByVehicle", _Option.FilterByVehicle)
                .AddInParameter("@_VehicleId", _Option.Vehicle?.Id)
                .AddInParameter("@_FilterByTransactionDateRange", _Option.FilterByTransactionDateRange)
                .AddInParameter("@_TransactionDateRangeBegin", _Option.TransactionDateRange?.Begin)
                .AddInParameter("@_TransactionDateRangeEnd", _Option.TransactionDateRange?.End);
        }

        private async Task<OutgoingStock> FromReaderAsync(DbDataReader reader)
        {
            return new OutgoingStock
            {
                Id = reader.GetUInt64("Id"),
                IssuanceSlipNumber = reader.GetString("IssuanceSlipNumber"),
                Item = _ItemManager.GetById(reader.GetUInt64("ItemId")),
                MeasurementUnit = _MeasurementUnitManager.GetById(reader.GetUInt64("MeasurementUnitId")),
                Quantity = reader.GetDecimal("Quantity"),
                Supplier = _SupplierManager.GetById(reader.GetUInt64("SupplierId")),
                TransactionDate = reader.GetDateTime("TransactionDate"),
                UnitCost = reader.GetDecimal("UnitCost"),
                Vehicle = await VehicleManager.GetByVehicleIdAsync(reader.GetUInt64("VehicleId"))
            };
        }

        public Task<IEnumerable<OutgoingStock>> ExecuteAsync()
        {
            return ProcessUtility.HandleReadingIEnumerableAsync(CreateCommand, FromReaderAsync);
        }
    }
}
