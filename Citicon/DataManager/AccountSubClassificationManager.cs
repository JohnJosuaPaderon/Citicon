using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class AccountSubClassificationManager : DataManager<AccountSubClassification>, IDataManager<AccountSubClassification>
    {
        private AccountTypeManager TypeManager;
        private AccountClassificationManager ClassificationManager;
        public AccountSubClassificationManager()
        {
            TypeManager = new AccountTypeManager();
            TypeManager.ExceptionCatched += OnExceptionCatched;
            ClassificationManager = new AccountClassificationManager();
            ClassificationManager.ExceptionCatched += OnExceptionCatched;
        }
        private MySqlQuery CreateAddQuery(AccountSubClassification data)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountsubclassifications_add");
            query.AddParameter("@_AccountSubClassificationId");
            query.AddParameter("@_Code", data.Code);
            query.AddParameter("@_AccountTypeId", data.Type?.Id);
            query.AddParameter("@_AccountClassificationId", data.Classification?.Id);
            query.AddParameter("@_Name", data.Name);
            query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
            query.ExceptionCatched += OnExceptionCatched;
            return query;
        }
        private void HandleAddEvents(MySqlQuery query, AccountSubClassification data)
        {
            if (query.AffectedRows == 1)
            {
                data.Id = query.ParameterValues.GetUInt64("AccountSubClassificationId");
                OnAdded(data);
            }
            else OnAddedUnsuccessful(data);
        }
        public void Add(AccountSubClassification data)
        {
            using (var query = CreateAddQuery(data))
            {
                query.Execute();
                HandleAddEvents(query, data);
            }
        }

        public async Task AddAsync(AccountSubClassification data)
        {
            using (var query = CreateAddQuery(data))
            {
                await query.ExecuteAsync();
                HandleAddEvents(query, data);
            }
        }

        public AccountSubClassification ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            return dictionary != null ?
                new AccountSubClassification
                {
                    Classification = ClassificationManager.GetById(dictionary.GetUInt64("AccountClassificationId")),
                    Code = dictionary.GetString("Code"),
                    Id = dictionary.GetUInt64("AccountSubClassificationId"),
                    Name = dictionary.GetString("Name"),
                    Type = TypeManager.GetById(dictionary.GetUInt64("AccountTypeId"))
                } : null;
        }

        public async Task<AccountSubClassification> ExtractFromDictionaryAsync(Dictionary<string, object> dict)
        {
            return dict != null ?
                new AccountSubClassification
                {
                    Classification = await ClassificationManager.GetByIdAsync(dict.GetUInt64("AccountClassificationId")),
                    Code = dict.GetString("Code"),
                    Id = dict.GetUInt64("AccountSubClassificationId"),
                    Name = dict.GetString("Name"),
                    Type = TypeManager.GetById(dict.GetUInt64("AccountTypeId"))
                } : null;
        }

        private MySqlQuery CreateGetListQuery()
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountsubclassifications_getlist");
            query.ExceptionCatched += OnExceptionCatched;
            query.ActiveRecordChanged += Query_ActiveRecordChanged;
            return query;
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            var task = ExtractFromDictionaryAsync(e);
            task.ContinueWith(x => OnNewItemGenerated(x.Result));
        }
        
        public AccountSubClassification[] GetList()
        {
            using (var query = CreateGetListQuery())
            {
                var result = query.GetResult(); if (result != null)
                {
                    var list = new List<AccountSubClassification>();
                    foreach (var item in result) list.Add(ExtractFromDictionary(item));
                    return list.ToArray();
                }
                return null;
            }
        }

        public async Task<AccountSubClassification[]> GetListAsync()
        {
            using (var query = CreateGetListQuery())
            {
                var result = await query.GetResultAsync();
                if (result != null)
                {
                    var list = new List<AccountSubClassification>();
                    foreach (var item in result) list.Add(await ExtractFromDictionaryAsync(item));
                    return list.ToArray();
                }
                return null;
            }
        }

        private MySqlQuery CreateRemoveQuery(AccountSubClassification data)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountsubclassifications_remove");
            query.AddParameter("@_AccountSubClassificationId", data.Id);
            query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
            query.ExceptionCatched += OnExceptionCatched;
            return query;
        }
        private void HandleRemoveEvents(MySqlQuery query, AccountSubClassification data)
        {
            if (query.AffectedRows == 1) OnRemoved(data);
            else OnRemovedUnsuccessful(data);
        }
        public void Remove(AccountSubClassification data)
        {
            using (var query = CreateRemoveQuery(data))
            {
                query.Execute();
                HandleRemoveEvents(query, data);
            }
        }

        public async Task RemoveAsync(AccountSubClassification data)
        {
            using (var query = CreateRemoveQuery(data))
            {
                await query.ExecuteAsync();
                HandleRemoveEvents(query, data);
            }
        }
        private MySqlQuery CreateUpdateQuery(AccountSubClassification data)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountsubclassifications_update");
            query.AddParameter("@_AccountSubClassificationId", data.Id);
            query.AddParameter("@_Code", data.Code);
            query.AddParameter("@_AccountTypeId", data.Type?.Id);
            query.AddParameter("@_AccountClassificationId", data.Classification?.Id);
            query.AddParameter("@_Name", data.Name);
            query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
            query.ExceptionCatched += OnExceptionCatched;
            return query;
        }
        private void HandleUpdateEvents(MySqlQuery query, AccountSubClassification data)
        {
            if (query.AffectedRows == 1) OnUpdated(data);
            else OnUpdatedUnsuccessful(data);
        }
        public void Update(AccountSubClassification data)
        {
            using (var query = CreateUpdateQuery(data))
            {
                query.Execute();
                HandleUpdateEvents(query, data);
            }
        }

        public async Task UpdateAsync(AccountSubClassification data)
        {
            using (var query = CreateUpdateQuery(data))
            {
                await query.ExecuteAsync();
                HandleUpdateEvents(query, data);
            }
        }
        private MySqlQuery CreateGetbyIdQuery(ulong id)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accountsubclassifications_getbyid");
            query.AddParameter("@_AccountSubClassificationId", id);
            query.ExceptionCatched += OnExceptionCatched;
            return query;
        }
        public AccountSubClassification GetById(ulong id)
        {
            using (var query = CreateGetbyIdQuery(id))
            {
                return ExtractFromDictionary(query.GetRecord());
            }
        }
        public async Task<AccountSubClassification> GetByIdAsync(ulong id)
        {
            using (var query = CreateGetbyIdQuery(id))
                return await ExtractFromDictionaryAsync(await query.GetRecordAsync());
        }
    }
}
