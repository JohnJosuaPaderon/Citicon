using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.Inventory.DataManager
{
    public sealed class StockManager : DataManager<Stock>, IDataManager<Stock>
    {
        public static string MrisReportTemplate { get { return ConfigurationManager.AppSettings["MrisReportTemplate"]; } }
        public static string MrisReportDirectory
        {
            get
            {
                var directory = ConfigurationManager.AppSettings["MrisReportDirectory"];
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                return directory;
            }
        }
        public event DataManagerEventHandler<Stock> NewItemStockGenerated;
        public event DataManagerEventHandler<Stock> NewUnpaidStockGenerated;
        public event DataManagerEventHandler<string> NewUnpaidMrisNumberGenerated;
        public event DataManagerEventHandler<Stock> NewItemByMrisNumberGenerated;
        private void OnNewItemStockGenerated(Stock stock)
        {
            if (NewItemStockGenerated != null) NewItemStockGenerated(stock);
        }

        public void Add(Stock data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_add"))
            {
                query.AddParameter("@_StockId");
                query.AddParameter("@_AcceptedBy", data.AcceptedBy);
                query.AddParameter("@_AddedStockValue", data.AddedStockValue);
                query.AddParameter("@_BranchId", data.Branch?.Id);
                query.AddParameter("@_CompanyId", data.Company?.Id);
                query.AddParameter("@_DeliveryDate", data.DeliveryDate);
                query.AddParameter("@_DueDate", data.DueDate);
                query.AddParameter("@_ItemId", data.Item?.Id);
                query.AddParameter("@_LastStockValue", data.LastStockValue);
                query.AddParameter("@_SidrNumber", data.SidrNumber);
                query.AddParameter("@_MrisNumber", data.MrisNumber);
                query.AddParameter("@_PaymentTermId", data.PaymentTerm?.Id);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_SupplierId", data.Supplier?.Id);
                query.AddParameter("@_UnitPrice", data.UnitPrice);
                query.AddParameter("@_VehicleId", data.Vehicle?.Id);
                query.AddParameter("@_Paid", data.Paid);
                query.AddParameter("@_Remarks", data.Remarks);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_StockId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Stock data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public void ExportMrisReport(Stock[] stocks)
        {
            if (File.Exists(MrisReportTemplate))
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(MrisReportTemplate);
                Excel.Worksheet sheet = book.ActiveSheet;
                try
                {
                    string mrisNumber = null;
                    Supplier supplier = null;
                    string deliveryDate = null;
                    var startingIndex = 10;
                    foreach (var item in stocks)
                    {
                        if (mrisNumber == null) mrisNumber = item.MrisNumber;
                        if (supplier == null) supplier = item.Supplier;
                        if (deliveryDate == null) deliveryDate = item.DeliveryDate.ToString("MMMM dd, yyyy");
                        sheet.Cells[startingIndex, 1] = startingIndex - 9;
                        sheet.Cells[startingIndex, 2] = item.SidrNumber;
                        sheet.Cells[startingIndex, 3] = item.Item.Code;
                        sheet.Cells[startingIndex, 4] = item.Item.Description;
                        sheet.Cells[startingIndex, 6] = item.AddedStockValue;
                        sheet.Cells[startingIndex, 7] = item.UnitPrice.ToString("#,##0.00");
                        sheet.Cells[startingIndex, 8] = (item.AddedStockValue * item.UnitPrice).ToString("#,##0.00");
                        startingIndex++;
                    }
                    sheet.Cells[3, 1] = mrisNumber;
                    sheet.Cells[4, 7] = DateTime.Now.ToString("MMMM dd, yyyy");
                    sheet.Cells[7, 1] = supplier.Description;
                    sheet.Cells[7, 7] = deliveryDate;
                    book.SaveAs($@"{MrisReportDirectory}/{supplier.Code}-{DateTime.Now.ToString("yyyyMMddhhmmss")}.xlsx");
                }
                catch (Exception ex) { throw ex; }
                finally
                {
                    book.Close();
                    app.Quit();
                }
            }
            else throw new FileNotFoundException("Template file for MRIS Reports was not found!", MrisReportTemplate);
        }

        public Stock ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Stock
                {
                    AcceptedBy = dictionary.GetString("AcceptedBy"),
                    AddedStockValue = dictionary.GetUInt32("AddedStockValue"),
                    Branch = (new BranchManager()).GetById(dictionary.GetUInt64("BranchId")),
                    Company = (new CompanyManager()).GetById(dictionary.GetUInt64("CompanyId")),
                    DeliveryDate = dictionary.GetDateTime("DeliveryDate"),
                    DueDate = dictionary.GetDateTime("DueDate"),
                    Id = dictionary.GetUInt64("StockId"),
                    Item = (new ItemManager()).GetById(dictionary.GetUInt64("ItemId")),
                    LastStockValue = dictionary.GetUInt32("LastStockValue"),
                    MrisNumber = dictionary.GetString("MrisNumber"),
                    PaymentTerm = (new PaymentTermManager()).GetById(dictionary.GetUInt64("PaymentTermId")),
                    SidrNumber = dictionary.GetString("SidrNumber"),
                    UnitPrice = dictionary.GetDecimal("UnitPrice"),
                    Vehicle = (new VehicleManager()).GetById(dictionary.GetUInt64("VehicleId")),
                    Supplier = (new SupplierManager()).GetById(dictionary.GetUInt64("SupplierId")),
                    Paid = dictionary.GetBoolean("Paid"),
                    Remarks = dictionary.GetString("Remarks")
                };
            }
            return null;
        }

        public string GenerateMrisNumber()
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _inventorystocks_generatemrisnumber();", System.Data.CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                return query.GetValue().ToString();
            }
        }

        public string[] GetUnpaidMrisNumberList()
        {
            List<string> mrisNumbers = null;
            using (var unpaidMrisNumberQuery = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_unpaidmrisnumber"))
            {
                unpaidMrisNumberQuery.ExceptionCatched += OnExceptionCatched;
                unpaidMrisNumberQuery.ActiveRecordChanged += UnpaidMrisNumberQuery_ActiveRecordChanged;
                var collection = unpaidMrisNumberQuery.GetResult();
                if (collection != null)
                {
                    mrisNumbers = new List<string>();
                    foreach (var item in collection) mrisNumbers.Add(item.GetString("MrisNumber"));
                }
            }
            return mrisNumbers?.ToArray();
        }

        public Task<string[]> GetUnpaidMrisNumberListAsync()
        {
            return Task.Factory.StartNew(GetUnpaidMrisNumberList);
        }

        private void UnpaidMrisNumberQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            if (NewUnpaidMrisNumberGenerated != null) NewUnpaidMrisNumberGenerated(e.GetString("MrisNumber"));
        }

        public Stock GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_getbyid"))
                {
                    query.AddParameter("@_StockId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<Stock> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public Stock[] GetList()
        {
            List<Stock> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<Stock>();
                    foreach (var item in result)
                    {
                        paymentTerms.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return paymentTerms?.ToArray();
        }

        public Task<Stock[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public Stock[] GetListByItem(Item item)
        {
            List<Stock> stocks = null;
            using (var itemStockQuery = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_getlistbyitemid"))
            {
                itemStockQuery.AddParameter("@_ItemId", item?.Id);
                itemStockQuery.ExceptionCatched += OnExceptionCatched;
                itemStockQuery.ActiveRecordChanged += ItemStockQuery_ActiveRecordChanged;
                var result = itemStockQuery.GetResult();
                if (result != null)
                {
                    stocks = new List<Stock>();
                    foreach (var stock in result) stocks.Add(ExtractFromDictionary(stock));
                }
            }
            return stocks?.ToArray();
        }

        public Task<Stock[]> GetListByItemAsync(Item item)
        {
            return Task.Factory.StartNew(() => GetListByItem(item));
        }

        public Stock[] GetListByMrisNumber(string mrisNumber)
        {
            List<Stock> stocks = null;
            using (var byMrisNumberQuery = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_getlistbymrisnumber"))
            {
                byMrisNumberQuery.AddParameter("@_MrisNumber", mrisNumber);
                byMrisNumberQuery.ExceptionCatched += OnExceptionCatched;
                byMrisNumberQuery.ActiveRecordChanged += ByMrisNumberQuery_ActiveRecordChanged;
                var collection = byMrisNumberQuery.GetResult();
                if (collection != null)
                {
                    stocks = new List<Stock>();
                    foreach (var item in collection) stocks.Add(ExtractFromDictionary(item));
                }
            }
            return stocks?.ToArray();
        }

        public Task<Stock[]> GetListByMrisNumberAsync(string mrisNumber)
        {
            return Task.Factory.StartNew(() => GetListByMrisNumber(mrisNumber));
        }

        private void ByMrisNumberQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            if (NewItemByMrisNumberGenerated != null) NewItemByMrisNumberGenerated(ExtractFromDictionary(e));
        }

        public Stock[] GetUnpaidList()
        {
            List<Stock> stocks = null;
            using (var unpaidStockQuery = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_getunpaidlist"))
            {
                unpaidStockQuery.ExceptionCatched += OnExceptionCatched;
                unpaidStockQuery.ActiveRecordChanged += UnpaidStockQuery_ActiveRecordChanged;
                var result = unpaidStockQuery.GetResult();
                if (result != null)
                {
                    stocks = new List<Stock>();
                    foreach (var item in result) stocks.Add(ExtractFromDictionary(item));
                }
            }
            return stocks?.ToArray();
        }

        public Task<Stock[]> GetUnpaidListAsync()
        {
            return Task.Factory.StartNew(GetUnpaidList);
        }

        private void UnpaidStockQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            if (NewUnpaidStockGenerated != null) NewUnpaidStockGenerated(ExtractFromDictionary(e));
        }

        private void ItemStockQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemStockGenerated(ExtractFromDictionary(e));
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public void Remove(Stock data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_remove"))
            {
                query.AddParameter("@_StockId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Stock data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public bool RevokeMrisNumber(string mrisNumber)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_revokemrisnumber"))
            {
                query.AddParameter("@_MrisNumber", mrisNumber);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                return query.AffectedRows > 0;
            }
        }

        public Task<bool> RevokeMrisNumberAsync(string mrisNumber)
        {
            return Task.Factory.StartNew(() => RevokeMrisNumber(mrisNumber));
        }

        public void Update(Stock data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_update"))
            {
                query.AddParameter("@_StockId", data.Id);
                query.AddParameter("@_AcceptedBy", data.AcceptedBy);
                query.AddParameter("@_AddedStockValue", data.AddedStockValue);
                query.AddParameter("@_BranchId", data.Branch?.Id);
                query.AddParameter("@_CompanyId", data.Company?.Id);
                query.AddParameter("@_DeliveryDate", data.DeliveryDate);
                query.AddParameter("@_DueDate", data.DueDate);
                query.AddParameter("@_ItemId", data.Item?.Id);
                query.AddParameter("@_LastStockValue", data.LastStockValue);
                query.AddParameter("@_MrisNumber", data.MrisNumber);
                query.AddParameter("@_SidrNumber", data.SidrNumber);
                query.AddParameter("@_PaymentTermId", data.PaymentTerm?.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_SupplierId", data.Supplier?.Id);
                query.AddParameter("@_UnitPrice", data.UnitPrice);
                query.AddParameter("@_VehicleId", data.Vehicle?.Id);
                query.AddParameter("@_Paid", data.Paid);
                query.AddParameter("@_Remarks", data.Remarks);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Stock data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
