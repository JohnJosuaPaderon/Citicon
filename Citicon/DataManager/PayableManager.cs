using Citicon.Data;
using Citicon.DataProcess;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataManager
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
        public event DataManagerEventHandler<string> NewChequeNumberListItemGenerated;

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
                query.AddParameter("@_Debit", data.Debit);
                query.AddParameter("@_Credit", data.Credit);
                query.AddParameter("@_VariableCost", data.VariableCost);
                query.AddParameter("@_Remarks", data.Remarks);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_TransactionDate", data.TransactionDate);
                query.AddParameter("@_AccountType", data.AccountType);
                query.AddParameter("@_ChequeTransactionDate", data.ChequeTransactionDate);
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

        private Point CellLocation(string excelName, string fieldName)
        {
            var raw = ConfigurationManager.AppSettings[$"{excelName}.Location[{fieldName}]"];
            var pair = raw.Split(',');
            int x = 0, y = 0;
            if (pair.Length == 2)
            {
                int.TryParse(pair[0], out x);
                int.TryParse(pair[1], out y);
            }
            return new Point(x, y);
        }

        private Point ChequeVoucherCellLocation(string fieldName)
        {
            return CellLocation("ChequeVoucher", fieldName);
        }

        private string CellDefault(string excelName, string fieldName)
        {
            return ConfigurationManager.AppSettings[$"{excelName}.Default[{fieldName}]"];
        }

        private string ChequeVoucherCellDefault(string fieldName)
        {
            return CellDefault("ChequeVoucher", fieldName);
        }

        private int CellMaxCount(string excelName, string fieldName)
        {
            int.TryParse(ConfigurationManager.AppSettings[$"{excelName}.MaxCount[{fieldName}]"], out int maxCount);
            return maxCount;
        }

        private int ChequeVoucherCellMaxCount(string fieldName)
        {
            return CellMaxCount("ChequeVoucher", fieldName);
        }

        public void ExportChequeVoucher(Payable[] payables, string accountPayableType)
        {
            if (File.Exists(ChequeVoucherTemplate))
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(ChequeVoucherTemplate);
                Excel.Sheets sheets = book.Sheets;
                Excel.Worksheet sheet = book.ActiveSheet;
                try
                {
                    Supplier payee = new Supplier
                    { };
                    string chequeVoucherNumber = null;
                    decimal totalAmount = 0.00M;
                    var particularLocation = ChequeVoucherCellLocation("Particulars");
                    var accountLocation = ChequeVoucherCellLocation("Accounts");
                    var accountsAmountLocation = ChequeVoucherCellLocation("AccountsAmount");
                    var payeeLocation = ChequeVoucherCellLocation("Payee");
                    var dateLocation = ChequeVoucherCellLocation("Date");
                    var amountInWordsLocation = ChequeVoucherCellLocation("AmountInWords");
                    var totalAmountLocation = ChequeVoucherCellLocation("TotalAmount");
                    var auditedByLocation = ChequeVoucherCellLocation("AuditedBy");
                    var postedByLocation = ChequeVoucherCellLocation("PostedBy");
                    var recordedByLocation = ChequeVoucherCellLocation("RecordedBy");
                    var preparedByLocation = ChequeVoucherCellLocation("PreparedBy");
                    var checkedByLocation = ChequeVoucherCellLocation("CheckedBy");
                    var approvedByLocation = ChequeVoucherCellLocation("ApprovedBy");
                    var chequeVoucherNumberLocation = ChequeVoucherCellLocation("ChequeVoucherNumber");
                    var defaultAuditedBy = ChequeVoucherCellDefault("AuditedBy");
                    var defaultPostedBy = ChequeVoucherCellDefault("PostedBy");
                    var defaultRecordedBy = ChequeVoucherCellDefault("RecordedBy");
                    var defaultPreparedBy = ChequeVoucherCellDefault("PreparedBy");
                    var defaultCheckedBy = ChequeVoucherCellDefault("CheckedBy");
                    var defaultApprovedBy = ChequeVoucherCellDefault("ApprovedBy");
                    var defaultPayee = ChequeVoucherCellDefault("Payee");
                    var maxParticulars = ChequeVoucherCellMaxCount("Particulars");
                    var maxAccounts = ChequeVoucherCellMaxCount("Accounts");
                    var maxAccountsAmounts = ChequeVoucherCellMaxCount("AccountsAmount");
                    var remarks = string.Empty;
                    var mrisAmount = new Dictionary<string, decimal>();
                    var currentRow = accountLocation.X;
                    
                    if (!string.IsNullOrEmpty(accountPayableType))
                    {
                        Payable withHoldingTax = null; 
                        for (int i = 0; i < payables.Length; i++)
                        {
                            var payable = payables[i];
                            if (payee == null) payee = payable.Supplier;
                            if (chequeVoucherNumber == null) chequeVoucherNumber = payable.ChequeVoucherNumber;
                            
                            if (remarks == string.Empty)
                                remarks = payable.Remarks;

                            if (payable.Expense != null && payable.Expense?.Id == Convert.ToUInt64(ConfigurationManager.AppSettings["WithHoldingTax_Id"]))
                            {
                                withHoldingTax = payable;
                            }
                            else
                            {
                                totalAmount += payable.Debit;
                            }

                            if (payable.Stock != null)
                            {
                                if (!mrisAmount.ContainsKey(payable.Stock.MrisNumber))
                                    mrisAmount.Add(payable.Stock.MrisNumber, 0);
                                mrisAmount[payable.Stock.MrisNumber] += payable.Debit;
                            }
                        }
                        sheet.Cells[accountLocation.X++, accountLocation.Y] = $"ACCOUNTS PAYABLE - {accountPayableType}";
                        sheet.Cells[accountsAmountLocation.X++, accountsAmountLocation.Y] = totalAmount;
                        if (withHoldingTax != null)
                        {
                            sheet.Cells[accountLocation.X++, accountLocation.Y] = withHoldingTax.Description;
                            sheet.Cells[accountsAmountLocation.X++, accountsAmountLocation.Y] = withHoldingTax.Debit;
                        }
                        sheet.Cells[accountLocation.X, accountLocation.Y] = $"* CASH IN BANK";
                        sheet.Cells[accountsAmountLocation.X, accountsAmountLocation.Y] = $"({totalAmount})";
                    }
                    else
                    {
                        var cashInBankRowIndex = 0;
                        for (int i = 0; i < payables.Length; i++)
                        {
                            var payable = payables[i];
                            if (payee == null) payee = payable.Supplier;
                            if (chequeVoucherNumber == null) chequeVoucherNumber = payable.ChequeVoucherNumber;
                            //totalAmount += payable.Debit;
                            if (remarks == string.Empty)
                                remarks = payable.Remarks;
                            //if (i + 1 < maxParticulars)
                            //    sheet.Cells[particularLocation.X + i, particularLocation.Y] = payable.Remarks;

                            //if (payable.Expense?.Id == 76)
                            //{
                            //    sheet.Cells[accountLocation.X++, accountLocation.Y] = payable.Description;
                            //    cashInBankRowIndex = accountsAmountLocation.X;
                            //}
                            //else if (i + 1 < maxAccounts && !payable.VariableCost)

                            if (payable.Expense?.Id == Expense.CashInBank?.Id)
                            {
                                totalAmount = payable.Value;
                            }

                            if (i + 1 < maxAccounts && !payable.VariableCost)
                            {
                                sheet.Cells[accountLocation.X++, accountLocation.Y] = $"{payable.Company?.Description} - {payable.Branch?.Description?.Substring(0, 3)}. - {payable.Description}";
                            }
                            if (i + 1 < maxAccountsAmounts && string.IsNullOrEmpty(accountPayableType))
                                sheet.Cells[accountsAmountLocation.X++, accountsAmountLocation.Y] = (payable.Debit <= 0 ? $"({payable.Credit.ToString("#,##0.00")})" : payable.Debit.ToString("#,##0.00"));
                        }
                        if (cashInBankRowIndex > 0)
                        {
                            sheet.Cells[cashInBankRowIndex, accountsAmountLocation.Y] = totalAmount * -1;
                        }
                    }
                    
                    if (mrisAmount.Count > 0)
                    {
                        remarks += "\nMRIS Nos.        AMOUNT";
                        foreach (var item in mrisAmount)
                        {
                            remarks += $"\n{item.Key}          {item.Value.ToString("#,##0.00")}";
                        }
                    }
                    sheet.Cells[particularLocation.X, particularLocation.Y] = remarks.Replace("\t","   ");
                    sheet.Cells[chequeVoucherNumberLocation.X, chequeVoucherNumberLocation.Y] = $"C.V. No. : {chequeVoucherNumber}";
                    sheet.Cells[payeeLocation.X, payeeLocation.Y] = payee?.Description ?? defaultPayee;
                    sheet.Cells[dateLocation.X, dateLocation.Y] = DateTime.Now.ToString("MM-dd-yyyy");
                    sheet.Cells[amountInWordsLocation.X, amountInWordsLocation.Y] = Sorschia.Supports.CurrencyToWords(totalAmount);
                    sheet.Cells[totalAmountLocation.X, totalAmountLocation.Y] = totalAmount.ToString("#,##0.00");
                    sheet.Cells[preparedByLocation.X, preparedByLocation.Y] = defaultPreparedBy;
                    sheet.Cells[checkedByLocation.X, checkedByLocation.Y] = defaultCheckedBy;
                    sheet.Cells[approvedByLocation.X, approvedByLocation.Y] = defaultApprovedBy;
                    sheet.Cells[auditedByLocation.X, auditedByLocation.Y] = defaultAuditedBy;
                    sheet.Cells[postedByLocation.X, postedByLocation.Y] = defaultPostedBy;
                    sheet.Cells[recordedByLocation.X, recordedByLocation.Y] = defaultRecordedBy;
                    //var filePath = $@"{ChequeVoucherDirectory}/{DateTime.Now.ToString("yyyyMMddHHmm")}_{payee?.Code ?? defaultPayee}.xlsx";
                    var filePath = Path.Combine(ChequeVoucherDirectory, string.Format("{0}_yyMMddHHmm.xlsx", chequeVoucherNumber));
                    book.SaveAs(filePath);
                    book.PrintOutEx();
                    //if (File.Exists(filePath))
                    //{
                    //    Process.Start(new ProcessStartInfo(filePath) { Verb = "print" });
                    //}
                }
                catch (Exception ex)
                { throw ex; }
                finally
                {
                    book.Close();
                    app.Quit();
                    Marshal.ReleaseComObject(sheet);
                    Marshal.ReleaseComObject(sheets);
                    Marshal.ReleaseComObject(book);
                    Marshal.ReleaseComObject(app);
                }
                //try
                //{
                //    Supplier payee = null;
                //    string chequeVoucherNumber = null;
                //    decimal totalAmount = 0.00M;
                //    var startingIndex = 10;
                //    foreach (var item in payables)
                //    {
                //        if (payee == null) payee = item.Supplier;
                //        if (chequeVoucherNumber == null) chequeVoucherNumber = item.ChequeVoucherNumber;
                //        totalAmount += item.TotalAmount;
                //        sheet.Cells[startingIndex++, 1] = item.Description;
                //    }
                //    sheet.Cells[2, 7] = $"C.V. NO. {chequeVoucherNumber}";
                //    sheet.Cells[5, 1] = payee?.Description;
                //    sheet.Cells[4, 8] = DateTime.Now.ToString("MMM dd, yyyy").ToUpper();
                //    sheet.Cells[5, 8] = chequeVoucherNumber;
                //    sheet.Cells[7, 1] = Sorschia.Supports.CurrencyToWords(totalAmount);
                //    sheet.Cells[7, 7] = totalAmount.ToString("#,##0.00");
                //    sheet.Cells[34, 8] = ChequeVoucherSignatories("PreparedBy");
                //    sheet.Cells[36, 8] = ChequeVoucherSignatories("CheckedBy");
                //    sheet.Cells[38, 8] = ChequeVoucherSignatories("ApprovedBy");
                //    sheet.Cells[39, 1] = ChequeVoucherSignatories("AuditedBy");
                //    sheet.Cells[39, 2] = ChequeVoucherSignatories("PostedBy");
                //    sheet.Cells[39, 3] = ChequeVoucherSignatories("RecordedBy");
                //    book.SaveAs($@"{ChequeVoucherDirectory}/{payee.Code}_{DateTime.Now.ToString("yyyyMMddhhmmss")}.xlsx");
                //}
                //catch (Exception ex) { throw ex; }
                //finally
                //{
                //    book.Close();
                //    app.Quit();
                //}
            }
            else throw new FileNotFoundException("Template file for Check Voucher printing was not found!", ChequeVoucherTemplate);
        }
        public void ExportCheque(decimal grandTotalAmount, Supplier payee, DateTime chequeDate)
        {
            if (File.Exists(ChequeTemplate))
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook book = app.Workbooks.Open(ChequeTemplate);
                Excel.Worksheet sheet = book.ActiveSheet;
                var file = $@"{ChequeDirectory}/{DateTime.Now.ToString("yyyyMMddhhmmss")}_{payee.Code}.xlsx";
                try
                {
                    sheet.Cells[4, 7] = grandTotalAmount.ToString("#,##0.00");
                    sheet.Cells[4, 2] = payee.Description;
                    sheet.Cells[1, 7] = chequeDate.ToString("MM/dd/yyyy");
                    sheet.Cells[5, 2] = Sorschia.Supports.CurrencyToWords(grandTotalAmount);
                    book.SaveAs(file);
                    book.PrintOutEx();
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
                    Debit = dictionary.GetDecimal("Debit"),
                    Credit = dictionary.GetDecimal("Credit"),
                    VariableCost = dictionary.GetBoolean("VariableCost"),
                    Remarks = dictionary.GetString("Remarks"),
                    TransactionDate = dictionary.GetDateTime("TransactionDate")
                };
            }
            return null;
        }

        public Task ExportChequeVoucherAsync(ChequeVoucher chequeVoucher)
        {
            if (chequeVoucher != null)
            {
                using (var process = new ExportChequeVoucher(chequeVoucher))
                {
                    return process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public string GenerateChequeVoucherNumber()
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _payables_generatechequevouchernumber();", System.Data.CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                return query.GetValue().ToString();
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
            NewChequeVoucherNumber?.Invoke(e.GetString("ChequeVoucherNumber"));
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
            NewItemByChequeVoucherNumber?.Invoke(ExtractFromDictionary(e));
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
        
        public string[] GetChequeNumberList(BankAccount bankAccount)
        {
            List<string> chequeNumbers = null;
            using (var chequeNumberListQuery = new MySqlQuery(Supports.ConnectionString, "_payables_getchequenumbers"))
            {
                chequeNumberListQuery.AddParameter("@_BankAccountId", bankAccount?.Id);
                chequeNumberListQuery.ExceptionCatched += OnExceptionCatched;
                chequeNumberListQuery.ActiveRecordChanged += ChequeNumberListQuery_ActiveRecordChanged;
                var result = chequeNumberListQuery.GetResult();
                if (result != null)
                {
                    chequeNumbers = new List<string>();
                    foreach (var item in result) chequeNumbers.Add(item.GetString("ChequeNumber"));
                }
            }
            return chequeNumbers?.ToArray();
        }

        public Task<string[]> GetChequeNumberListAsync(BankAccount bankAccount)
        {
            return Task.Factory.StartNew(() => GetChequeNumberList(bankAccount));
        }

        public async Task<IEnumerable<Payable>> GetChequeVoucherNumberDetailsAsync(string chequeVoucherNumber)
        {
            if (!string.IsNullOrWhiteSpace(chequeVoucherNumber))
            {
                using (var process = new GetChequeVoucherNumberDetails(chequeVoucherNumber))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<List<Payable>> GetTransactionsAsync(
            bool byTransactionDateRange = false, DateTime transactionDateStart = default(DateTime), DateTime transactionDateEnd = default(DateTime),
            bool byCompany = false, Company company = null,
            bool byBranch = false, Branch branch = null,
            bool byItemClassification = false, Classification itemClassification = null,
            bool byExpense = false, Expense expense = null,
            bool bySupplier = false, Supplier supplier = null)
        {
            List<Payable> payables = null;
            using (var transactionsQuery = new MySqlQuery(Supports.ConnectionString, "_payables_gettransactions"))
            {
                transactionsQuery.AddParameter("@_ByTransactionDateRange", byTransactionDateRange);
                transactionsQuery.AddParameter("@_TransactionDateStart", transactionDateStart.ToString("yyyy-MM-dd"));
                transactionsQuery.AddParameter("@_TransactionDateEnd", transactionDateEnd.ToString("yyyy-MM-dd"));
                transactionsQuery.AddParameter("@_ByCompanyId", byCompany);
                transactionsQuery.AddParameter("@_CompanyId", company?.Id);
                transactionsQuery.AddParameter("@_ByBranchId", byBranch);
                transactionsQuery.AddParameter("@_BranchId", branch?.Id);
                transactionsQuery.AddParameter("@_ByItemClassificationId", byItemClassification);
                transactionsQuery.AddParameter("@_ItemClassificationId", itemClassification?.Id);
                transactionsQuery.AddParameter("@_ByExpenseId", byExpense);
                transactionsQuery.AddParameter("@_ExpenseId", expense?.Id);
                transactionsQuery.AddParameter("@_BySupplierId", bySupplier);
                transactionsQuery.AddParameter("@_SupplierId", supplier?.Id);
                var result = await transactionsQuery.GetResultAsync();
                if (result != null)
                {
                    payables = new List<Payable>();
                    foreach (var item in result) payables.Add(ExtractFromDictionary(item));
                }
            }
            return payables;
        }

        public event DataManagerEventHandler<int> RevokeChequeNumberExecuted;

        public void RevokeChequeNumber(BankAccount bankAccount, string chequeNumber)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payables_revokechequenumber"))
            {
                query.AddParameter("@_BankAccountId", bankAccount?.Id);
                query.AddParameter("@_ChequeNumber", chequeNumber);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                RevokeChequeNumberExecuted?.Invoke(query.AffectedRows);
            }
        }

        private void ChequeNumberListQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            NewChequeNumberListItemGenerated?.Invoke(e.GetString("ChequeNumber"));
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
                query.AddParameter("@_Debit", data.Debit);
                query.AddParameter("@_Credit", data.Credit);
                query.AddParameter("@_VariableCost", data.VariableCost);
                query.AddParameter("@_Remarks", data.Remarks);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_TransactionDate", data.TransactionDate);
                query.AddParameter("@_ChequeDate", data.ChequeDate);
                query.AddParameter("@_ChequeTransactionDate", data.ChequeTransactionDate);
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
