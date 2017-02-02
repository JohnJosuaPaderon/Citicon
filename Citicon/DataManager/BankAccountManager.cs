using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class BankAccountManager : DataManager<BankAccount>, IDataManager<BankAccount>
    {
        public void Add(BankAccount data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_bankaccounts_add"))
            {
                query.AddParameter("@_BankAccountId");
                query.AddParameter("@_BankId", data.Bank?.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ChequeNumber", data.ChequeNumber);
                query.AddParameter("@_ChequeNumberStart", data.ChequeNumberStart);
                query.AddParameter("@_ChequeNumberEnd", data.ChequeNumberEnd);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_BankAccountId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(BankAccount data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public BankAccount ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new BankAccount
                {
                    Bank = (new BankManager()).GetById(dictionary.GetUInt64("BankId")),
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("BankAccountId"),
                    ChequeNumber = dictionary.GetUInt32("ChequeNumber"),
                    ChequeNumberEnd = dictionary.GetUInt32("ChequeNumberEnd"),
                    ChequeNumberStart = dictionary.GetUInt32("ChequeNumberStart")
                };
            }
            return null;
        }

        public string GenerateCode(Bank bank)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _bankaccounts_generatecode(@_BankId);", CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.AddParameter("@_BankId", bank?.Id);
                return query.GetValue().ToString();
            }
        }

        public BankAccount GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_bankaccounts_getbyid"))
                {
                    query.AddParameter("@_BankAccountId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<BankAccount> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public BankAccount[] GetList()
        {
            List<BankAccount> bankAccounts = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_bankaccounts_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var collection = query.GetResult();
                if (collection != null)
                {
                    bankAccounts = new List<BankAccount>();
                    foreach (var item in collection) bankAccounts.Add(ExtractFromDictionary(item));
                }
            }
            return bankAccounts?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<BankAccount[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(BankAccount data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_bankaccounts_remove"))
            {
                query.AddParameter("@_BankAccountId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(BankAccount data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(BankAccount data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_bankaccounts_update"))
            {
                query.AddParameter("@_BankAccountId", data.Id);
                query.AddParameter("@_BankId", data.Bank?.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ChequeNumber", data.ChequeNumber);
                query.AddParameter("@_ChequeNumberStart", data.ChequeNumberStart);
                query.AddParameter("@_ChequeNumberEnd", data.ChequeNumberEnd);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(BankAccount data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
