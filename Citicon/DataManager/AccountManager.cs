using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class AccountManager : DataManager<Account>, IDataManager<Account>
    {
        private AccountTypeManager TypeManager;
        private AccountClassificationManager ClassificationManager;
        private AccountSubClassificationManager SubClassificationManager;
        public AccountManager()
        {
            TypeManager = new AccountTypeManager();
            TypeManager.ExceptionCatched += OnExceptionCatched;
            ClassificationManager = new AccountClassificationManager();
            ClassificationManager.ExceptionCatched += OnExceptionCatched;
            SubClassificationManager = new AccountSubClassificationManager();
            SubClassificationManager.ExceptionCatched += OnExceptionCatched;
        }
        private MySqlQuery CreateAddQuery(Account data)
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accounts_add");
            query.AddParameter("@_AccountId");
            query.AddParameter("@_Code", data.Code);
            query.AddParameter("@_AccountTypeId", data.Type?.Id);
            query.AddParameter("@_AccountClassificationId", data.Classification?.Id);
            query.AddParameter("@_AccountSubClassificationId", data.SubClassification?.Id);
            query.AddParameter("@_Name", data.Name);
            query.AddParameter("@_LogBy", User.CurrentUser?.DisplayName);
            return query;
        }
        private void HandleAddEvents(MySqlQuery query, Account data)
        {
            if (query.AffectedRows == 1)
            {
                data.Id = query.ParameterValues.GetUInt64("@_AccountId");
                OnAdded(data);
            }
            else OnAddedUnsuccessful(data);
        }
        public void Add(Account data)
        {
            using (var query = CreateAddQuery(data))
            {
                query.Execute();
                HandleAddEvents(query, data);
            }
        }

        public async Task AddAsync(Account data)
        {
            using (var query = CreateAddQuery(data))
            {
                await query.ExecuteAsync();
                HandleAddEvents(query, data);
            }
        }

        public Account ExtractFromDictionary(Dictionary<string, object> arg)
        {
            return arg != null ?
                new Account
                {
                    Classification = ClassificationManager.GetById(arg.GetUInt64("AccountClassificationId")),
                    Code = arg.GetString("Code"),
                    Id = arg.GetUInt64("AccountId"),
                    Name = arg.GetString("Name"),
                    SubClassification = SubClassificationManager.GetById(arg.GetUInt64("SubClassificationId")),
                    Type = TypeManager.GetById(arg.GetUInt64("AccountTypeId"))
                } : null;
        }

        public async Task<Account> ExtractFromDictionaryAsync(Dictionary<string, object> arg)
        {
            return arg != null ?
                new Account
                {
                    Classification = await ClassificationManager.GetByIdAsync(arg.GetUInt64("AccountClassificationId")),
                    Code = arg.GetString("Code"),
                    Id = arg.GetUInt64("AccountId"),
                    Name = arg.GetString("Name"),
                    SubClassification = await SubClassificationManager.GetByIdAsync(arg.GetUInt64("AccountSubClassificationId")),
                    Type = TypeManager.GetById(arg.GetUInt64("AccountTypeId"))
                } : null;
        }

        private MySqlQuery CreateGetListQuery()
        {
            var query = new MySqlQuery(Supports.ConnectionString, "_accounts_getlist");
            query.ExceptionCatched += OnExceptionCatched;
            query.ActiveRecordChanged += Query_ActiveRecordChanged;
            return query;
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            var task = ExtractFromDictionaryAsync(e);
            task.ContinueWith(x => OnNewItemGenerated(task.Result));
        }

        public Account[] GetList()
        {
            using (var query = CreateGetListQuery())
            {
                var result = query.GetResult();
                if (result != null)
                {
                    var list = new List<Account>();
                    foreach (var item in result) list.Add(ExtractFromDictionary(item));
                    return list.ToArray();
                }
                return null;
            }
        }

        public async Task<Account[]> GetListAsync()
        {
            using (var query = CreateGetListQuery())
            {
                var result = await query.GetResultAsync();
                if (result != null)
                {
                    var list = new List<Account>();
                    foreach (var item in result) list.Add(await ExtractFromDictionaryAsync(item));
                    return list.ToArray();
                }
                return null;
            }
        }

        public void Remove(Account data)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Account data)
        {
            throw new NotImplementedException();
        }

        public void Update(Account data)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Account data)
        {
            throw new NotImplementedException();
        }
    }
}
