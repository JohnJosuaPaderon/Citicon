using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class AccountTypeManager : DataManager<AccountType>, IDataManager<AccountType>
    {
        public void Add(AccountType data)
        {
            var task = AddAsync(data);
            task.ContinueWith(x => { });
        }

        public async Task AddAsync(AccountType data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_accounttypes_add"))
            {
                query.AddParameter("@_AccountTypeId");
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Name", data.Name);
                query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                await query.ExecuteAsync();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_AccountTypeId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public AccountType ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new AccountType
                {
                    Code = dictionary.GetString("Code"),
                    Id = dictionary.GetUInt64("AccountTypeId"),
                    Name = dictionary.GetString("Name")
                };
            }
            return null;
        }

        public AccountType[] GetList()
        {
            return GetListAsync().Result;
        }

        public async Task<AccountType[]> GetListAsync()
        {
            var accountTypes = new List<AccountType>();
            using (var query = new MySqlQuery(Supports.ConnectionString, "_accounttypes_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = await query.GetResultAsync();
                if (result != null)
                    foreach (var item in result)
                        accountTypes.Add(ExtractFromDictionary(item));
                return accountTypes.ToArray();
            }
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public void Remove(AccountType data)
        {
            RemoveAsync(data).Wait();
        }

        public async Task RemoveAsync(AccountType data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_accounttypes_remove"))
            {
                query.AddParameter("@_AccountTypeId", data.Id);
                query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                await query.ExecuteAsync();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public void Update(AccountType data)
        {
            UpdateAsync(data).Wait();
        }

        public async Task UpdateAsync(AccountType data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_accounttypes_update"))
            {
                query.AddParameter("@_AccountTypeId", data.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                await query.ExecuteAsync();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public AccountType GetById(ulong id)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_accounttypes_getbyid"))
            {
                query.AddParameter("@_AccountTypeId", id);
                query.ExceptionCatched += OnExceptionCatched;
                var record = query.GetRecord();
                if (record != null)
                    return ExtractFromDictionary(record);
                else return null;
            }
        }
    }
}
