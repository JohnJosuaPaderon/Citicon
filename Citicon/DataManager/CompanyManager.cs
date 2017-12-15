using Citicon.Data;
using Citicon.DataProcess;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class CompanyManager : DataManager<Company>, IDataManager<Company>
    {
        static CompanyManager()
        {
            CompanyDict = new Dictionary<ulong, Company>();
        }

        private static Dictionary<ulong, Company> CompanyDict { get; }

        public void Add(Company data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_companies_add"))
            {
                query.AddParameter("@_CompanyId");
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_CompanyId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Company data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public Company ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                var company = new Company
                {
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("CompanyId")
                };

                if (!CompanyDict.ContainsKey(company.Id))
                {
                    CompanyDict.Add(company.Id, company);
                }

                return company;
            }
            else
            {
                return null;
            }
        }

        public string GenerateCode()
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _companies_generatecode();", CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                return query.GetValue().ToString();
            }
        }

        public Company GetById(ulong id)
        {
            if (CompanyDict.ContainsKey(id))
            {
                return CompanyDict[id];
            }

            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_companies_getbyid"))
                {
                    query.AddParameter("@_CompanyId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public async Task<Company> GetByIdAsync(ulong id)
        {
            if (id > 0)
            {
                if (CompanyDict.ContainsKey(id))
                {
                    return CompanyDict[id];
                }
                else
                {
                    using (var process = new GetCompanyById(id))
                    {
                        var result = await process.ExecuteAsync();

                        if (result != null)
                        {
                            CompanyDict.Add(id, result);
                        }

                        return result;
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public Company[] GetList()
        {
            List<Company> companies = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_companies_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    companies = new List<Company>();
                    foreach (var item in result)
                    {
                        companies.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return companies?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Company[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Company data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_companies_remove"))
            {
                query.AddParameter("@_CompanyId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Company data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Company data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_companies_update"))
            {
                query.AddParameter("@_CompanyId", data.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Company data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
