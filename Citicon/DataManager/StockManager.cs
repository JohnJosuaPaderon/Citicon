using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataProcess;
using Citicon.Payables.DataManager;
using MySql.Data.MySqlClient;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
            NewItemStockGenerated?.Invoke(stock);
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
                query.AddParameter("@_SiNumber", data.SiNumber);
                query.AddParameter("@_DrNumber", data.DrNumber);
                query.AddParameter("@_MrisNumber", data.MrisNumber);
                query.AddParameter("@_PaymentTermId", data.PaymentTerm?.Id);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_SupplierId", data.Supplier?.Id);
                query.AddParameter("@_UnitPrice", data.UnitPrice);
                query.AddParameter("@_VehicleId", data.Vehicle?.Id);
                query.AddParameter("@_Paid", data.Paid);
                query.AddParameter("@_Remarks", data.Remarks);
                query.AddParameter("@_MeasurementDescription", data.MeasurementDescription);
                query.AddParameter("@_CementSuppliedClientId", data.CementSuppliedClient?.Id);
                query.AddParameter("@_IncludeWithHoldingTax", data.IncludeWithHoldingTax);
                query.AddParameter("@_WithHoldingTax", data.WithHoldingTax);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (data.CementSuppliedProjects?.Length > 0)
                {
                    data.Id = (ulong)query.ParameterValues["@_StockId"];
                    var saveCementSuppliedStockProject = new SaveCementSuppliedStockProject(data, data.CementSuppliedProjects);
                    var saveCementSuppliedStockProjectTask = saveCementSuppliedStockProject.ExecuteAsync(); 
                }
                //if (query.AffectedRows == 1)
                //{
                //    data.Id = query.ParameterValues.GetUInt64("@_StockId");
                    OnAdded(data);
                //}
                //else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Stock data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        private uint GetColumnIndex(string excelName, string fieldName)
        {
            uint.TryParse(ConfigurationManager.AppSettings[$"{excelName}.ColumnIndex[{fieldName}]"], out uint value);
            return value;
        }

        private uint MrisRowStartIndex(string fieldName)
        {
            uint.TryParse(ConfigurationManager.AppSettings[$"Mris.RowStartIndex[{fieldName}]"], out uint value);
            return value;
        }

        private uint MrisColumnIndex(string fieldName)
        {
            return GetColumnIndex("Mris", fieldName);
        }

        private uint MrisMaxCount(string fieldName)
        {
            uint.TryParse(ConfigurationManager.AppSettings[$"Mris.MaxCount[{fieldName}]"], out uint value);
            return value;
        }

        private Point MrisLocation(string field)
        {
            var raw = ConfigurationManager.AppSettings[$"Mris.Location[{field}]"];
            int x = 0, y = 0;
            var pair = raw.Split(',');
            if (pair.Length == 2)
            {
                int.TryParse(pair[0], out x);
                int.TryParse(pair[1], out y);
            }
            return new Point(x, y);
        }

        private string MrisDefault(string field)
        {
            return ConfigurationManager.AppSettings[$"Mris.Default[{field}]"];
        }

        public void ExportMrisReport(Stock[] stocks, string usage = "", string receivedStoredBy = "", string inspectedAcceptedBy = "", string approvedBy = "")
        {
            if (File.Exists(MrisReportTemplate))
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(MrisReportTemplate);
                Excel.Worksheet sheet = book.ActiveSheet;
                Excel.Sheets sheets = book.Sheets;
                try
                {
                    string mrisNumber = null;
                    Supplier supplier = null;
                    string deliveryDate = null;
                    var itemNumberColumn = MrisColumnIndex("ItemNumber");
                    var siDrColumn = MrisColumnIndex("SiDr");
                    var itemCodeColumn = MrisColumnIndex("ItemCode");
                    var itemDescriptionColumn = MrisColumnIndex("ItemDescription");
                    var unitColumn = MrisColumnIndex("Unit");
                    var quantityColumn = MrisColumnIndex("Quantity");
                    var unitCostColumn = MrisColumnIndex("UnitCost");
                    var amountColumn = MrisColumnIndex("Amount");
                    var itemRowStart = MrisRowStartIndex("Item");
                    var itemMaxCount = MrisMaxCount("Item");
                    var usageLocation = MrisLocation("Usage");
                    var receivedStoredByLocation = MrisLocation("ReceivedStoredBy");
                    var inspectedAcceptedByLocation = MrisLocation("InspectedAcceptedBy");
                    var approvedByLocation = MrisLocation("ApprovedBy");
                    var mrisNumberLocation = MrisLocation("MrisNumber");
                    var deliveryDateLocation = MrisLocation("DeliveryDate");
                    var nameAddressLocation = MrisLocation("NameAddress");
                    var defaultUsage = MrisDefault("Usage");
                    var defaultReceivedStoredBy = MrisDefault("ReceivedStoredBy");
                    var defaultInspectedAcceptedBy = MrisDefault("InspectedAcceptedBy");
                    var defaultApprovedBy = MrisDefault("ApprovedBy");
                    var dateLocation = MrisLocation("Date");
                    uint lastRow = 0;
                    decimal totalQuantity = 0.00M;
                    //decimal totalCost = 0.00M;
                    decimal totalAmount = 0.00M;
                    decimal totalVat = 0.00M;

                    for (uint i = 0; i < stocks.Length; i++)
                    {
                        var stock = stocks[i];

                        if (stock.IncludeWithHoldingTax && stock.WithHoldingTax != 0)
                        {
                            totalVat += ((stock.UnitPrice * stock.AddedStockValue) / stock.WithHoldingTax.Value) * 0.12M;
                        }

                        if (mrisNumber == null) mrisNumber = stock.MrisNumber;
                        if (supplier == null) supplier = stock.Supplier;
                        if (deliveryDate == null) deliveryDate = stock.DeliveryDate.ToString("MMMM dd, yyyy");
                        if (i < itemMaxCount)
                        {
                            lastRow = itemRowStart + i;
                            sheet.Cells[lastRow, itemNumberColumn] = i + 1;
                            sheet.Cells[lastRow, siDrColumn] = $"SI={stock.SiNumber}/DR={stock.DrNumber}";
                            sheet.Cells[lastRow, itemCodeColumn] = stock.Item?.Code;
                            sheet.Cells[lastRow, itemDescriptionColumn] = string.IsNullOrEmpty(stock.MeasurementDescription) ? stock.Item?.ToString() : stock.MeasurementDescription;
                            //sheet.Cells[lastRow, itemDescriptionColumn] = $"{(string.IsNullOrEmpty(stock.Item?.ToString()) ? "" : $"{stock.Item.ToString()} ")}{stock.MeasurementDescription}";
                            sheet.Cells[lastRow, unitColumn] = stock.Item?.MeasurementUnit?.Symbol;
                            sheet.Cells[lastRow, quantityColumn] = stock.AddedStockValue.ToString("#,##0.00");
                            sheet.Cells[lastRow, unitCostColumn] = stock.UnitPrice.ToString("#,##0.00");
                            sheet.Cells[lastRow, amountColumn] = (stock.AddedStockValue * stock.UnitPrice).ToString("#,##0.00");

                            totalQuantity += stock.AddedStockValue;
                            //totalCost += stock.UnitPrice;
                            totalAmount += (stock.AddedStockValue * stock.UnitPrice);
                        }
                    }
                    lastRow++;
                    Excel.Range quantityRange = sheet.Cells[lastRow, quantityColumn];
                    quantityRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                    sheet.Cells[lastRow, quantityColumn] = totalQuantity.ToString("#,##0.00");
                    Excel.Range amountRange = sheet.Cells[lastRow, amountColumn];
                    amountRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                    sheet.Cells[lastRow, amountColumn] = totalAmount.ToString("#,##0.00");

                    sheet.Cells[24, unitCostColumn] = "Total Amount Due";
                    sheet.Cells[24, amountColumn] = totalAmount.ToString("#,##0.00");

                    //if (totalVat != 0)
                    //{
                        lastRow++;
                        sheet.Cells[21, unitCostColumn] = "VAT";
                        sheet.Cells[21, amountColumn] = totalVat.ToString("#,##0.00");

                        sheet.Cells[22, unitCostColumn] = "Net Amount";
                        sheet.Cells[22, amountColumn] = (totalAmount - totalVat).ToString("#,##0.00");
                    //}

                    sheet.Cells[mrisNumberLocation.X, mrisNumberLocation.Y] = mrisNumber;
                    sheet.Cells[deliveryDateLocation.X, deliveryDateLocation.Y] = deliveryDate;
                    sheet.Cells[usageLocation.X, usageLocation.Y] = usage;
                    sheet.Cells[receivedStoredByLocation.X, receivedStoredByLocation.Y] = receivedStoredBy;
                    sheet.Cells[inspectedAcceptedByLocation.X, inspectedAcceptedByLocation.Y] = inspectedAcceptedBy;
                    sheet.Cells[approvedByLocation.X, approvedByLocation.Y] = approvedBy;
                    sheet.Cells[nameAddressLocation.X, nameAddressLocation.Y] = supplier?.Description;
                    sheet.Cells[dateLocation.X, dateLocation.Y] = DateTime.Now.ToString("MMMM dd, yyyy");
                    //foreach (var item in stocks)
                    //{
                    //    if (mrisNumber == null) mrisNumber = item.MrisNumber;
                    //    if (supplier == null) supplier = item.Supplier;
                    //    if (deliveryDate == null) deliveryDate = item.DeliveryDate.ToString("MMMM dd, yyyy");
                    //    sheet.Cells[startingIndex, 1] = startingIndex - 9;
                    //    sheet.Cells[startingIndex, 2] = item.SiNumber;
                    //    sheet.Cells[startingIndex, 3] = item.Item.Code;
                    //    sheet.Cells[startingIndex, 4] = item.Item.Description;
                    //    sheet.Cells[startingIndex, 6] = item.AddedStockValue;
                    //    sheet.Cells[startingIndex, 7] = item.UnitPrice.ToString("#,##0.00");
                    //    sheet.Cells[startingIndex, 8] = (item.AddedStockValue * item.UnitPrice).ToString("#,##0.00");
                    //    startingIndex++;
                    //}
                    //sheet.Cells[3, 1] = mrisNumber;
                    //sheet.Cells[4, 7] = DateTime.Now.ToString("MMMM dd, yyyy");
                    //sheet.Cells[7, 1] = supplier.Description;
                    //sheet.Cells[7, 7] = deliveryDate;
                    book.SaveAs($@"{MrisReportDirectory}/{DateTime.Now.ToString("yyyyMMddhhmm")}_{supplier.Code}.xlsx");
                    book.PrintOutEx();
                }
                catch (Exception)
                { throw; }
                finally
                {
                    book.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(sheet);
                    Marshal.ReleaseComObject(sheets);
                    Marshal.ReleaseComObject(book);
                    Marshal.ReleaseComObject(app);
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
                    AddedStockValue = dictionary.GetDecimal("AddedStockValue"),
                    Branch = (new BranchManager()).GetById(dictionary.GetUInt64("BranchId")),
                    Company = (new CompanyManager()).GetById(dictionary.GetUInt64("CompanyId")),
                    DeliveryDate = dictionary.GetDateTime("DeliveryDate"),
                    DueDate = dictionary.GetDateTime("DueDate"),
                    Id = dictionary.GetUInt64("StockId"),
                    Item = (new ItemManager()).GetById(dictionary.GetUInt64("ItemId")),
                    LastStockValue = dictionary.GetDecimal("LastStockValue"),
                    MrisNumber = dictionary.GetString("MrisNumber"),
                    PaymentTerm = (new PaymentTermManager()).GetById(dictionary.GetUInt64("PaymentTermId")),
                    SiNumber = dictionary.GetUInt32("SiNumber"),
                    DrNumber = dictionary.GetUInt32("DrNumber"),
                    UnitPrice = dictionary.GetDecimal("UnitPrice"),
                    Vehicle = (new VehicleManager()).GetById(dictionary.GetUInt64("VehicleId")),
                    Supplier = (new SupplierManager()).GetById(dictionary.GetUInt64("SupplierId")),
                    Paid = dictionary.GetBoolean("Paid"),
                    Remarks = dictionary.GetString("Remarks"),
                    MeasurementDescription = dictionary.GetString("MeasurementDescription"),
                    Expense = (new ExpenseManager()).GetById(dictionary.GetUInt64("ExpenseId")),
                    IncludeWithHoldingTax = dictionary.GetBoolean("IncludeWithHoldingTax"),
                    WithHoldingTax = dictionary.GetDecimal("WithHoldingTax")
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
            NewUnpaidMrisNumberGenerated?.Invoke(e.GetString("MrisNumber"));
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

        public Stock[] GetListByMrisNumber_Reprint(string mrisNumber)
        {
            List<Stock> stocks = null;
            using (var byMrisNumberQuery = new MySqlQuery(Supports.ConnectionString, "_inventorystocks_getlistbymrisnumber_reprint"))
            {
                byMrisNumberQuery.AddParameter("@_MrisNumber", mrisNumber);
                byMrisNumberQuery.ExceptionCatched += OnExceptionCatched;
                var collection = byMrisNumberQuery.GetResult();
                if (collection != null)
                {
                    stocks = new List<Stock>();
                    foreach (var item in collection) stocks.Add(ExtractFromDictionary(item));
                }
                return stocks?.ToArray(); ;
            }
        }

        public Task<Stock[]> GetListByMrisNumberAsync(string mrisNumber)
        {
            return Task.Factory.StartNew(() => GetListByMrisNumber(mrisNumber));
        }

        private void ByMrisNumberQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            NewItemByMrisNumberGenerated?.Invoke(ExtractFromDictionary(e));
        }

        public async Task<IEnumerable<Stock>> GetFilteredUnpaidListAsyc(
            bool filterByItem, Item item,
            bool filterBySupplier, Supplier supplier,
            bool filterByBranch, Branch branch,
            bool filterByDeliveryDate, DateTime deliveryDate,
            bool filterBySiNumber, uint siNumber,
            bool filterByDrNumber, uint drNumber)
        {
            using (var connection = new MySqlConnection(Supports.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                }
                catch (Exception)
                {
                    return null;
                }
                using (var command = new MySqlCommand("_inventorystocks_getfilteredunpaidlist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_FilterByItemId", filterByItem);
                    command.Parameters.AddWithValue("@_ItemId", item?.Id);
                    command.Parameters.AddWithValue("@_FilterBySupplierId", filterBySupplier);
                    command.Parameters.AddWithValue("@_SupplierId", supplier?.Id);
                    command.Parameters.AddWithValue("@_FilterByBranchId", filterByBranch);
                    command.Parameters.AddWithValue("@_BranchId", branch?.Id);
                    command.Parameters.AddWithValue("@_FilterByDeliveryDate", filterByDeliveryDate);
                    command.Parameters.AddWithValue("@_DeliveryDate", deliveryDate);
                    command.Parameters.AddWithValue("@_FilterBySiNumber", filterBySiNumber);
                    command.Parameters.AddWithValue("@_SiNumber", siNumber);
                    command.Parameters.AddWithValue("@_FilterByDrNumber", filterByDrNumber);
                    command.Parameters.AddWithValue("@_DrNumber", drNumber);
                    List<Stock> stocks = null;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                stocks = new List<Stock>();
                                while (await reader.ReadAsync())
                                {
                                    var dict = new Dictionary<string, object>();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        dict.Add(reader.GetName(i), reader.GetValue(i));
                                    }
                                    stocks.Add(ExtractFromDictionary(dict));
                                }
                            }
                        }
                        return stocks;
                    }
                    catch (Exception e)
                    {
                        OnExceptionCatched(e);
                        return null;
                    }
                    
                }
            }
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
            NewUnpaidStockGenerated?.Invoke(ExtractFromDictionary(e));
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
                query.AddParameter("@_ExpenseId", data.Expense?.Id);
                query.AddParameter("@_LastStockValue", data.LastStockValue);
                query.AddParameter("@_MrisNumber", data.MrisNumber);
                query.AddParameter("@_SiNumber", data.SiNumber);
                query.AddParameter("@_DrNumber", data.DrNumber);
                query.AddParameter("@_PaymentTermId", data.PaymentTerm?.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_SupplierId", data.Supplier?.Id);
                query.AddParameter("@_UnitPrice", data.UnitPrice);
                query.AddParameter("@_VehicleId", data.Vehicle?.Id);
                query.AddParameter("@_Paid", data.Paid);
                query.AddParameter("@_Remarks", data.Remarks);
                query.AddParameter("@_MeasurementDescription", data.MeasurementDescription);
                query.AddParameter("@_IncludeWithHoldingTax", data.IncludeWithHoldingTax);
                query.AddParameter("@_WithHoldingTax", data.WithHoldingTax);
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
