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
    public sealed class BankManager : DataManager<Bank>, IDataManager<Bank>
    {
        public void Add(Bank data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_banks_add"))
            {
                query.AddParameter("@_BankId");
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_BankId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        internal Bank GetById(object getUint64)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Bank data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public Bank ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Bank
                {
                     Code = dictionary.GetString("Code"),
                     Description = dictionary.GetString("Description"),
                     Id = dictionary.GetUInt64("BankId")
                };
            }
            return null;
        }

        public Bank GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_banks_getbyid"))
                {
                    query.AddParameter("@_BankId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<Bank> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public Bank[] GetList()
        {
            List<Bank> banks = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_banks_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    banks = new List<Bank>();
                    foreach (var item in result) banks.Add(ExtractFromDictionary(item));
                }
            }
            return banks?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Bank[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Bank data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_banks_remove"))
            {
                query.AddParameter("@_BankId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Bank data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Bank data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_banks_update"))
            {
                query.AddParameter("@_BankId", data.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Bank data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
