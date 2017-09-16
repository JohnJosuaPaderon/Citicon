using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class BranchManager : DataManager<Branch>//, IDataManager<Branch>
    {
        static BranchManager()
        {
            BranchDict = new Dictionary<ulong, Branch>();
        }

        private static Dictionary<ulong, Branch> BranchDict { get; }

        public void Add(Branch data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_branches_add"))
            {
                query.AddParameter("@_BranchId");
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_BranchId");
                    OnAdded(data);
                    BranchDict.Add(data.Id, data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Branch data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public static Branch ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Branch
                {
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("BranchId")
                };
            }
            return null;
        }

        public string GenerateCode()
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _branches_generatecode();", CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                return query.GetValue().ToString();
            }
        }

        public static Branch GetById(ulong id)
        {
            if (BranchDict.ContainsKey(id))
            {
                return BranchDict[id];
            }

            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_branches_getbyid"))
                {
                    query.AddParameter("@_BranchId", id);
                    //query.ExceptionCatched += OnExceptionCatched;
                    var branch = ExtractFromDictionary(query.GetRecord());

                    if (branch != null && !BranchDict.ContainsKey(branch.Id))
                    {
                        BranchDict.Add(branch.Id, branch);
                    }

                    return branch;
                }
            }
            return null;
        }

        public Task<Branch> GetByIdAsync(ulong id)
        {
            return Task.Run(() => GetById(id));
        }

        public Branch[] GetList()
        {
            List<Branch> branches = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_branches_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    branches = new List<Branch>();
                    foreach (var item in result)
                    {
                        var branch = ExtractFromDictionary(item);
                        branches.Add(branch);

                        if (branch != null && !BranchDict.ContainsKey(branch.Id))
                        {
                            BranchDict.Add(branch.Id, branch);
                        }
                    }
                }
            }
            return branches?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Branch[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Branch data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_branches_remove"))
            {
                query.AddParameter("@_BranchId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Branch data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Branch data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_branches_update"))
            {
                query.AddParameter("@_BranchId", data.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Branch data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
