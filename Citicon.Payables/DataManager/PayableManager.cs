using Citicon.Data;
using Citicon.DataManager;
using Citicon.Inventory.Data;
using Citicon.Inventory.DataManager;
using Citicon.Payables.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.Payables.DataManager
{
    public sealed class PayableManager : DataManager<Payable>, IDataManager<Payable>
    {
        public static string ChequeVoucherTemplate { get { return ConfigurationManager.AppSettings["ChequeVoucherTemplate"]; } }
        public static string ChequeTemplate { get { return ConfigurationManager.AppSettings["ChequeTemplate"]; } }
        public static string ChequeVoucherDirectory
        {
            get
            {
                var directory = ConfigurationManager.AppSettings["ChequeVoucherDirectory"];
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                return directory;
            }
        }
        public static string ChequeDirectory
        {
            get
            {
                var directory = ConfigurationManager.AppSettings["ChequeDirectory"];
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                return directory;
            }
        }
        public event DataManagerEventHandler<Payable> NewItemByChequeVoucherNumber;
        public static string ChequeVoucherSignatories(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(ConfigurationManager.AppSettings["ChequeVoucherSignatories"]);
            return doc.GetElementsByTagName("Signatories").Cast<XmlNode>().FirstOrDefault(x => x.Attributes["Key"].Value == key).Attributes["Value"].Value;
        }
        public event DataManagerEventHandler<string> NewChequeVoucherNumber;

        public void Add(Payable data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payables_add"))
            {
                query.AddParameter("@_PayableId");
                query.AddParameter("@_BankAccountId", data.BankAccount?.Id);
                query.AddParameter("@_BranchId", data.Branch?.Id);
                query.AddParameter("@_ChequeNumber", data.ChequeNumber);
                query.AddParameter("@_ChequeVoucherNumber", data.ChequeVoucherNumber);
                query.AddParameter("@_CompanyId", data.Company?.Id);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ExpenseId", data.Expense?.Id);
                query.AddParameter("@_SalaryPeriodEnd", data.SalaryPeriodEnd);
                query.AddParameter("@_SalaryPeriodStart", data.SalaryPeriodStart);
                query.AddParameter("@_StockId", data.Stock?.Id);
                query.AddParameter("@_SupplierId", data.Supplier?.Id);
                query.AddParameter("@_TotalAmount", data.TotalAmount);
                query.AddParameter("@_VariableCost", data.VariableCost);
                query.AddParameter("@_Remarks", data.Remarks);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_PayableId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Payable data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public void ExportChequeVoucher(Payable[] payables)
        {
            if (File.Exists(ChequeVoucherTemplate))
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(ChequeVoucherTemplate);
                Excel.Worksheet sheet = book.ActiveSheet;
                try
                {
                    Supplier payee = null;
                    string chequeVoucherNumber = null;
                    decimal totalAmount = 0.00M;
                    var startingIndex = 10;
                    foreach (var item in payables)
                    {
                        if (payee == null) payee = item.Supplier;
                        if (chequeVoucherNumber == null) chequeVoucherNumber = item.ChequeVoucherNumber;
                        totalAmount += item.TotalAmount;
                        sheet.Cells[startingIndex++, 1] = item.Description;
                    }
                    sheet.Cells[2, 7] = $"C.V. NO. {chequeVoucherNumber}";
                    sheet.Cells[5, 1] = payee?.Description;
                    sheet.Cells[4, 8] = DateTime.Now.ToString("MMM dd, yyyy").ToUpper();
                    sheet.Cells[5, 8] = chequeVoucherNumber;
                    sheet.Cells[7, 1] = Sorschia.Supports.CurrencyToWords(totalAmount);
                    sheet.Cells[7, 7] = totalAmount.ToString("#,##0.00");
                    sheet.Cells[34, 8] = ChequeVoucherSignatories("PreparedBy");
                    sheet.Cells[36, 8] = ChequeVoucherSignatories("CheckedBy");
                    sheet.Cells[38, 8] = ChequeVoucherSignatories("ApprovedBy");
                    sheet.Cells[39, 1] = ChequeVoucherSignatories("AuditedBy");
                    sheet.Cells[39, 2] = ChequeVoucherSignatories("PostedBy");
                    sheet.Cells[39, 3] = ChequeVoucherSignatories("RecordedBy");
                    book.SaveAs($@"{ChequeVoucherDirectory}/{payee.Code}_{DateTime.Now.ToString("yyyyMMddhhmmss")}.xlsx");
                }
                catch (Exception ex) { throw ex; }
                finally
                {
                    book.Close();
                    app.Quit();
                }
            }
            else throw new FileNotFoundException("Template file for Check Voucher printing was not found!", ChequeVoucherTemplate);
        }
        public void ExportCheque(decimal grandTotalAmount, Supplier payee)
        {
            if (File.Exists(ChequeTemplate))
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(ChequeTemplate);
                Excel.Worksheet sheet = book.ActiveSheet;
                try
                {
                    sheet.Cells[4, 7] = grandTotalAmount.ToString("#,##0.00");
                    sheet.Cells[4, 2] = payee.Description;
                    sheet.Cells[5, 2] = Sorschia.Supports.CurrencyToWords(grandTotalAmount);
                    book.SaveAs($@"{ChequeDirectory}/{payee.Code}_{DateTime.Now.ToString("yyyyMMddhhmmss")}.xlsx");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    book.Close(false, ChequeTemplate);
                    app.Quit();
                }
            }
            else throw new FileNotFoundException("Template file for Cheques was not found!", ChequeTemplate);
        }
        public Payable ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Payable
                {
                    BankAccount = (new BankAccountManager()).GetById(dictionary.GetUInt64("BankAccountId")),
                    Branch = (new BranchManager()).GetById(dictionary.GetUInt64("BranchId")),
                    ChequeNumber = dictionary.GetString("ChequeNumber"),
                    ChequeVoucherNumber = dictionary.GetString("ChequeVoucherNumber"),
                    Company = (new CompanyManager()).GetById(dictionary.GetUInt64("CompanyId")),
                    Description = dictionary.GetString("Description"),
                    Expense = (new ExpenseManager()).GetById(dictionary.GetUInt64("ExpenseId")),
                    Id = dictionary.GetUInt64("PayableId"),
                    SalaryPeriodEnd = dictionary.GetDateTime("SalaryPeriodEnd"),
                    SalaryPeriodStart = dictionary.GetDateTime("SalaryPeriodStart"),
                    Stock = (new StockManager()).GetById(dictionary.GetUInt64("StockId")),
                    Supplier = (new SupplierManager()).GetById(dictionary.GetUInt64("SupplierId")),
                    TotalAmount = dictionary.GetDecimal("TotalAmount"),
                    VariableCost = dictionary.GetBoolean("VariableCost"),
                    Remarks = dictionary.GetString("Remarks")
                };
            }
            return null;
        }

        public string GenerateChequeVoucherNumber()
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _payables_generatechequevouchernumber();", System.Data.CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                return uint.Parse(query.GetValue().ToString()).ToString("0000000");
            }
        }

        public string[] GetChequeVoucherNumber(bool withChequeNumber)
        {
            List<string> chequeVoucherNumbers = null;
            using (var chequeVoucherNumberQuery = new MySqlQuery(Supports.ConnectionString, "_payables_getchequevouchernumbers"))
            {
                chequeVoucherNumberQuery.AddParameter("@_WithChequeNumber", withChequeNumber);
                chequeVoucherNumberQuery.ExceptionCatched += OnExceptionCatched;
                chequeVoucherNumberQuery.ActiveRecordChanged += ChequeVoucherNumberQuery_ActiveRecordChanged;
                var result = chequeVoucherNumberQuery.GetResult();
                if (result != null)
                {
                    chequeVoucherNumbers = new List<string>();
                    foreach (var item in result) chequeVoucherNumbers.Add(item.GetString("ChequeVoucherNumber"));
                }
            }
            return chequeVoucherNumbers?.ToArray();
        }

        public Task<string[]> GetChequeVoucherNumberAsync(bool withChequeNumber)
        {
            return Task.Factory.StartNew(() => GetChequeVoucherNumber(withChequeNumber));
        }

        private void ChequeVoucherNumberQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            if (NewChequeVoucherNumber != null) NewChequeVoucherNumber(e.GetString("ChequeVoucherNumber"));
        }

        public Payable[] GetListByChequeVoucherNumber(string chequeVoucherNumber)
        {
            List<Payable> payables = null;
            using (var listByChequeVoucherNumberQuery = new MySqlQuery(Supports.ConnectionString, "_payables_getlistbychequevouchernumber"))
            {
                listByChequeVoucherNumberQuery.AddParameter("@_ChequeVoucherNumber", chequeVoucherNumber);
                listByChequeVoucherNumberQuery.ExceptionCatched += OnExceptionCatched;
                listByChequeVoucherNumberQuery.ActiveRecordChanged += ListByChequeVoucherNumberQuery_ActiveRecordChanged;
                var result = listByChequeVoucherNumberQuery.GetResult();
                if (result != null)
                {
                    payables = new List<Payable>();
                    foreach (var item in result) payables.Add(ExtractFromDictionary(item));
                }
            }
            return payables?.ToArray();
        }

        public Task<Payable[]> GetListByChequeVoucherNumberAsync(string chequeVoucherNumber)
        {
            return Task.Factory.StartNew(() => GetListByChequeVoucherNumber(chequeVoucherNumber));
        }

        private void ListByChequeVoucherNumberQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            if (NewItemByChequeVoucherNumber != null) NewItemByChequeVoucherNumber(ExtractFromDictionary(e));
        }

        public Payable GetById(ulong id)
        {
            if (id > 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_payables_getbyid"))
                {
                    query.AddParameter("@_PayableId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<Payable> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public Payable[] GetList()
        {
            List<Payable> payables = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payables_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var collection = query.GetResult();
                if (collection != null)
                {
                    foreach (var item in collection) payables.Add(ExtractFromDictionary(item));
                }
            }
            return payables?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Payable[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Payable data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payables_remove"))
            {
                query.AddParameter("@_PayableId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Payable data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Payable data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payables_update"))
            {
                query.AddParameter("@_PayableId", data.Id);
                query.AddParameter("@_BankAccountId", data.BankAccount?.Id);
                query.AddParameter("@_BranchId", data.Branch?.Id);
                query.AddParameter("@_ChequeNumber", data.ChequeNumber);
                query.AddParameter("@_ChequeVoucherNumber", data.ChequeVoucherNumber);
                query.AddParameter("@_CompanyId", data.Company?.Id);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ExpenseId", data.Expense?.Id);
                query.AddParameter("@_SalaryPeriodEnd", data.SalaryPeriodEnd);
                query.AddParameter("@_SalaryPeriodStart", data.SalaryPeriodStart);
                query.AddParameter("@_StockId", data.Stock?.Id);
                query.AddParameter("@_SupplierId", data.Supplier?.Id);
                query.AddParameter("@_TotalAmount", data.TotalAmount);
                query.AddParameter("@_VariableCost", data.VariableCost);
                query.AddParameter("@_Remarks", data.Remarks);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Payable data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
