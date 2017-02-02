using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class AccountClassificationManager : DataManager<AccountClassification>, IDataManager<AccountClassification>
    {
        private AccountTypeManager TypeManager;
        public AccountClassificationManager()
        {
            TypeManager = new AccountTypeManager();
            TypeManager.ExceptionCatched += OnExceptionCatched;
        }
        private delegate void HandlingEvent(AccountClassification data);
        private MySqlQuery CreateAddQuery(AccountClassification data)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountclassifications_add");
            query.AddParameter("@_AccountClassificationId");
            query.AddParameter("@_AccountTypeId", data.Type?.Id);
            query.AddParameter("@_Code", data.Code);
            query.AddParameter("@_Name", data.Name);
            query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
            query.ExceptionCatched += OnExceptionCatched;
            return query;
        }
        private MySqlQuery CreateRemoveQuery(AccountClassification data)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountclassifications_remove");
            query.AddParameter("@_AccountClassificationId", data.Id);
            query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
            query.ExceptionCatched += OnExceptionCatched;
            return query;
        }
        private MySqlQuery CreateUpdateQuery(AccountClassification data)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountclassifications_update");
            query.AddParameter("@_AccountClassificationId", data.Id);
            query.AddParameter("@_AccountTypeId", data.Type?.Id);
            query.AddParameter("@_Code", data.Code);
            query.AddParameter("@_Name", data.Name);
            query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
            return query;
        }
        private void HandleEvents(bool success, AccountClassification data, HandlingEvent successHandler, HandlingEvent failedHandler)
        {
            if (success) successHandler(data);
            else failedHandler(data);
        }
        private void HandleAddEvents(MySqlQuery query, AccountClassification data)
        {
            data.Id = query.ParameterValues.GetUInt64("@_AccountClassificationId");
            HandleEvents(query.AffectedRows == 1, data, OnAdded, OnAddedUnsuccessful);
        }
        public void Add(AccountClassification data)
        {
            using (var query = CreateAddQuery(data))
            {
                query.Execute();
                HandleAddEvents(query, data);
            }
        }

        public async Task AddAsync(AccountClassification data)
        {
            using (var query = CreateAddQuery(data))
            {
                await query.ExecuteAsync();
                HandleAddEvents(query, data);
            }
        }

        public AccountClassification ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            return dictionary != null ? new AccountClassification
            {
                Code = dictionary.GetString("Code"),
                Id = dictionary.GetUInt64("AccountClassificationId"),
                Name = dictionary.GetString("Name"),
                Type = TypeManager.GetById(dictionary.GetUInt64("AccountTypeId"))
            } : null;
        }

        private MySqlQuery CreateGetListQuery()
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountclassifications_getlist");
            query.ExceptionCatched += OnExceptionCatched;
            query.ActiveRecordChanged += Query_ActiveRecordChanged;
            return query;
        }
        public AccountClassification[] GetList()
        {
            using (var query = CreateGetListQuery())
            {
                var result = query.GetResult();
                if (result != null)
                {
                    var accountClassifications = new List<AccountClassification>();
                    foreach (var item in result) accountClassifications.Add(ExtractFromDictionary(item));
                    return accountClassifications.ToArray();
                }
                return null;
            }
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public async Task<AccountClassification[]> GetListAsync()
        {
            using (var query = CreateGetListQuery())
            {
                var result = await query.GetResultAsync();
                if (result != null)
                {
                    var accountClassifications = new List<AccountClassification>();
                    foreach (var item in result) accountClassifications.Add(ExtractFromDictionary(item));
                    return accountClassifications.ToArray();
                }
                return null;
            }
        }

        public void Remove(AccountClassification data)
        {
            using (var query = CreateRemoveQuery(data))
            {
                query.Execute();
                HandleEvents(query.AffectedRows == 1, data, OnRemoved, OnRemovedUnsuccessful);
            }
        }

        public async Task RemoveAsync(AccountClassification data)
        {
            using (var query = CreateRemoveQuery(data))
            {
                await query.ExecuteAsync();
                HandleEvents(query.AffectedRows == 1, data, OnRemoved, OnRemovedUnsuccessful);
            }
        }

        public void Update(AccountClassification data)
        {
            using (var query = CreateUpdateQuery(data))
            {
                query.Execute();
                HandleEvents(query.AffectedRows == 1, data, OnUpdated, OnUpdatedUnsuccessful);
            }
        }

        public async Task UpdateAsync(AccountClassification data)
        {
            using (var query = CreateUpdateQuery(data))
            {
                await query.ExecuteAsync();
                HandleEvents(query.AffectedRows == 1, data, OnUpdated, OnUpdatedUnsuccessful);
            }
        }

        private MySqlQuery CreateGetByIdQuery(ulong id)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountclassifications_getbyid");
            query.AddParameter("@_AccountClassificationId", id);
            query.ExceptionCatched += OnExceptionCatched;
            return query;
        }

        public AccountClassification GetById(ulong id)
        {
            using (var query = CreateGetByIdQuery(id))
                return ExtractFromDictionary(query.GetRecord());
        }
        public async Task<AccountClassification> GetByIdAsync(ulong id)
        {
            using (var query = CreateGetByIdQuery(id))
                return ExtractFromDictionary(await query.GetRecordAsync());
        }
    }
}
