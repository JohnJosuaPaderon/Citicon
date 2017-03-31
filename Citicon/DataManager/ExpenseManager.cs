using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class ExpenseManager : DataManager<Expense>, IDataManager<Expense>
    {
        static ExpenseManager()
        {
            ExpenseDict = new Dictionary<ulong, Expense>();
        }

        private static Dictionary<ulong, Expense> ExpenseDict { get; }

        public void Add(Expense data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payablesexpenses_add"))
            {
                query.AddParameter("@_ExpenseId");
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_ExpenseId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Expense data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public Expense ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                var expense = new Expense
                {
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("ExpenseId")
                };

                if (!ExpenseDict.ContainsKey(expense.Id))
                {
                    ExpenseDict.Add(expense.Id, expense);
                }

                return expense;
            }
            else
            {
                return null; 
            }
        }

        public string GenerateCode()
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _payablesexpenses_generatecode();", CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                return query.GetValue().ToString();
            }
        }

        public Expense GetById(ulong id)
        {
            if (ExpenseDict.ContainsKey(id))
            {
                return ExpenseDict[id];
            }

            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_payablesexpenses_getbyid"))
                {
                    query.AddParameter("@_ExpenseId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<Expense> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public Expense[] GetList()
        {
            List<Expense> expenses = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payablesexpenses_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var collection = query.GetResult();
                if (collection != null)
                {
                    expenses = new List<Expense>();
                    foreach (var item in collection) expenses.Add(ExtractFromDictionary(item));
                }
            }
            return expenses?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Expense[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Expense data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payablesexpenses_remove"))
            {
                query.AddParameter("@_ExpenseId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Expense data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Expense data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_payablesexpenses_update"))
            {
                query.AddParameter("@_ExpenseId", data.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Expense data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
