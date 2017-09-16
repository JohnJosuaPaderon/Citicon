using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataManager
{
    public sealed class TransactionManager : DataManager<Transaction>, IDataManager<Transaction>
    {
        public static string IssuanceSlipTemplate { get { return ConfigurationManager.AppSettings["IssuanceSlipTemplate"]; } }
        public static string IssuanceSlipDirectory
        {
            get
            {
                var directory = ConfigurationManager.AppSettings["IssuanceSlipDirectory"];
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                return directory;
            }
        }
        public event DataManagerEventHandler<Transaction> NewItemTransactionGenerated;
        private void OnNewItemTransactionGenerated(Transaction transaction)
        {
            NewItemTransactionGenerated?.Invoke(transaction);
        }
        public void Add(Transaction data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorytransactions_add"))
            {
                query.AddParameter("@_TransactionId");
                query.AddParameter("@_BranchId", data.Branch?.Id);
                query.AddParameter("@_CompanyId", data.Company?.Id);
                query.AddParameter("@_ItemId", data.Item?.Id);
                query.AddParameter("@_LastStockValue", data.LastStockValue);
                query.AddParameter("@_Purpose", data.Purpose);
                query.AddParameter("@_ReleasedBy", data.ReleasedBy);
                query.AddParameter("@_RemovedStockValue", data.RemovedStockValue);
                query.AddParameter("@_RequestedBy", data.RequestedBy);
                query.AddParameter("@_TruckID", data.Truck?.Id);
                query.AddParameter("@_TransactionDate", data.TransactionDate);
                query.AddParameter("@_SeriesNumber", data.SeriesNumber);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);

                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_TransactionId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Transaction data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }
        public void ExportIssuanceSlip(Transaction transaction)
        {
            if (File.Exists(IssuanceSlipTemplate))
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(IssuanceSlipTemplate);
                Excel.Worksheet sheet = book.ActiveSheet;
                try
                {
                    sheet.Cells[1, 10] = transaction.Id.ToString("0000000");
                    sheet.Cells[10, 7] = transaction.TransactionDate.ToString("MMMM dd, yyyy");
                    sheet.Cells[11, 1] = transaction.Item?.Description;
                    sheet.Cells[13, 1] = transaction.Item?.Code;
                    sheet.Cells[14, 5] = transaction.Item?.Classification?.Description;
                    sheet.Cells[16, 5] = transaction.Company?.Description;
                    sheet.Cells[17, 5] = transaction.Branch?.Description;
                    sheet.Cells[18, 5] = transaction.Truck?.PlateNumber;
                    sheet.Cells[19, 5] = transaction.RemovedStockValue.ToString("#,##0");
                    sheet.Cells[20, 5] = transaction.Purpose;
                    sheet.Cells[27, 1] = transaction.RequestedBy;
                    sheet.Cells[27, 7] = transaction.ReleasedBy;
                    book.SaveAs($"{IssuanceSlipDirectory}/{transaction.Item?.Code}-{transaction.TransactionDate.ToString("yyyyMMddhhmmss")}.xlsx");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    book.Close();
                    app.Quit();
                }
            }
            else throw new FileNotFoundException("Template file for Issuance slip was not found!", IssuanceSlipTemplate);
        }
        public Transaction ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Transaction
                {
                    Branch = BranchManager.GetById(dictionary.GetUInt64("BranchId")),
                    Company = (new CompanyManager()).GetById(dictionary.GetUInt64("CompanyId")),
                    Id = dictionary.GetUInt64("TransactionId"),
                    Item = (new ItemManager()).GetById(dictionary.GetUInt64("ItemId")),
                    LastStockValue = dictionary.GetDecimal("LastStockValue"),
                    Purpose = dictionary.GetString("Purpose"),
                    ReleasedBy = dictionary.GetString("ReleasedBy"),
                    RemovedStockValue = dictionary.GetDecimal("RemovedStockValue"),
                    RequestedBy = dictionary.GetString("RequestedBy"),
                    TransactionDate = dictionary.GetDateTime("TransactionDate"),
                    SeriesNumber = dictionary.GetUInt32("SeriesNumber"),
                    Truck = (new VehicleManager()).GetById(dictionary.GetUInt64("TruckID"))
                };
            }
            return null;
        }

        public Transaction GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorytransactions_getbyid"))
                {
                    query.AddParameter("@_TransactionId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<Transaction> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public Transaction[] GetList()
        {
            List<Transaction> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorytransactions_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<Transaction>();
                    foreach (var item in result)
                    {
                        paymentTerms.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return paymentTerms?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Transaction[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public Transaction[] GetListByItem(Item item)
        {
            List<Transaction> transactions = null;
            using (var itemTransactionQuery = new MySqlQuery(Supports.ConnectionString, "_inventorytransactions_getlistbyitemid"))
            {
                itemTransactionQuery.AddParameter("@_ItemId", item?.Id);
                itemTransactionQuery.ExceptionCatched += OnExceptionCatched;
                itemTransactionQuery.ActiveRecordChanged += ItemTransactionQuery_ActiveRecordChanged;
                var result = itemTransactionQuery.GetResult();
                if (result != null)
                {
                    transactions = new List<Transaction>();
                    foreach (var transaction in result) transactions.Add(ExtractFromDictionary(transaction));
                }
            }
            return transactions?.ToArray();
        }

        public Task<Transaction[]> GetListByItemAsync(Item item)
        {
            return Task.Factory.StartNew(() => GetListByItem(item));
        }

        private void ItemTransactionQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemTransactionGenerated(ExtractFromDictionary(e));
        }

        public void Remove(Transaction data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorytransactions_remove"))
            {
                query.AddParameter("@_TransactionId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Transaction data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Transaction data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorytransactions_update"))
            {
                query.AddParameter("@_TransactionId", data.Id);
                query.AddParameter("@_BranchId", data.Branch?.Id);
                query.AddParameter("@_CompanyId", data.Company?.Id);
                query.AddParameter("@_ItemId", data.Item?.Id);
                query.AddParameter("@_LastStockValue", data.LastStockValue);
                query.AddParameter("@_Purpose", data.Purpose);
                query.AddParameter("@_ReleasedBy", data.ReleasedBy);
                query.AddParameter("@_RemovedStockValue", data.RemovedStockValue);
                query.AddParameter("@_RequestedBy", data.RequestedBy);
                query.AddParameter("@_TruckID", data.Truck?.Id);
                query.AddParameter("@_TransactionDate", data.TransactionDate);
                query.AddParameter("@_SeriesNumber", data.SeriesNumber);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Transaction data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
