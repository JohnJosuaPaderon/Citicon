using Citicon.Data;
using Citicon.Inventory.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.Inventory.DataManager
{
    public sealed class ClassificationManager : DataManager<Classification>, IDataManager<Classification>
    {
        public void Add(Classification data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryclassifications_add"))
            {
                query.AddParameter("@_ClassificationId");
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_MeasurementUnitId", data.MeasurementUnit?.Id);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_ClassificationId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Classification data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public Classification ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Classification
                {
                     Code = dictionary.GetString("Code"),
                     Description = dictionary.GetString("Description"),
                     Id = dictionary.GetUInt64("ClassificationId"),
                     MeasurementUnit = (new MeasurementUnitManager()).GetById(dictionary.GetUInt64("MeasurementUnitId"))
                };
            }
            return null;
        }

        public Classification GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryclassifications_getbyid"))
                {
                    query.AddParameter("@_ClassificationId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<Classification> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public Classification[] GetList()
        {
            List<Classification> classifications = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryclassifications_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    classifications = new List<Classification>();
                    foreach (var item in result)
                    {
                        classifications.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return classifications?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Classification[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Classification data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryclassifications_remove"))
            {
                query.AddParameter("@_ClassificationId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Classification data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Classification data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryclassifications_update"))
            {
                query.AddParameter("@_ClassificationId", data.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_MeasurementUnitId", data.MeasurementUnit?.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Classification data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
