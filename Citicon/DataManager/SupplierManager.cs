using Citicon.Data;
using Citicon.DataProcess;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class SupplierManager : DataManager<Supplier>, IDataManager<Supplier>
    {
        static SupplierManager()
        {
            SupplierDict = new Dictionary<ulong, Supplier>();
        }

        private static Dictionary<ulong, Supplier> SupplierDict { get; }

        public void Add(Supplier data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_suppliers_add"))
            {
                query.AddParameter("@_SupplierId");
                query.AddParameter("@_Address", data.Address);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_ContactNumber", data.ContactNumber);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_SupplierId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Supplier data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public Supplier ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                var supplier = new Supplier
                {
                    Address = dictionary.GetString("Address"),
                    Code = dictionary.GetString("Code"),
                    ContactNumber = dictionary.GetString("ContactNumber"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("SupplierId")
                };

                if (!SupplierDict.ContainsKey(supplier.Id))
                {
                    SupplierDict.Add(supplier.Id, supplier);
                }

                return supplier;
            }
            else
            {
                return null;
            }
        }

        public string GenerateCode()
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _suppliers_generatecode();", CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                return query.GetValue().ToString();
            }
        }

        public Supplier GetById(ulong id)
        {
            if (SupplierDict.ContainsKey(id))
            {
                return SupplierDict[id];
            }

            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_suppliers_getbyid"))
                {
                    query.AddParameter("@_SupplierId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public async Task<Supplier> GetByIdAsync(ulong id)
        {
            if (id > 0)
            {
                if (SupplierDict.ContainsKey(id))
                {
                    return SupplierDict[id];
                }
                else
                {
                    using (var process = new GetSupplierById(id))
                    {
                        var result = await process.ExecuteAsync();

                        if (result != null)
                        {
                            SupplierDict.Add(result.Id, result);
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

        public Supplier[] GetList()
        {
            List<Supplier> suppliers = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_suppliers_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    suppliers = new List<Supplier>();
                    foreach (var item in result)
                    {
                        suppliers.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return suppliers?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public async Task<Supplier[]> GetListAsync()
        {
            var process = new GetSupplierList();
            return (await process.ExecuteAsync()).ToArray();
        }

        public void Remove(Supplier data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_suppliers_remove"))
            {
                query.AddParameter("@_SupplierId", data.Id);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Supplier data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Supplier data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_suppliers_update"))
            {
                query.AddParameter("@_SupplierId", data.Id);
                query.AddParameter("@_Address", data.Address);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_ContactNumber", data.ContactNumber);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Supplier data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
