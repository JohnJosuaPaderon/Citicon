using Citicon.Data;
using Citicon.Inventory.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.Inventory.DataManager
{
    public sealed class SubClassificationManager : DataManager<SubClassification>, IDataManager<SubClassification>
    {
        public void Add(SubClassification data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorysubclassifications_add"))
            {
                query.AddParameter("@_SubClassificationId");
                query.AddParameter("@_ClassificationId", data.Classification?.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_MeasurementUnitId", data.MeasurementUnit?.Id);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_SubClassificationId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(SubClassification data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public SubClassification ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new SubClassification
                {
                    Classification = (new ClassificationManager()).GetById(dictionary.GetUInt64("ClassificationId")),
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("SubClassificationId"),
                    MeasurementUnit = (new MeasurementUnitManager()).GetById(dictionary.GetUInt64("MeasurementUnitId"))
                };
            }
            return null;
        }

        public SubClassification GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorysubclassifications_getbyid"))
                {
                    query.AddParameter("@_SubClassificationId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<SubClassification> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public SubClassification[] GetList()
        {
            List<SubClassification> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorysubclassifications_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<SubClassification>();
                    foreach (var item in result)
                    {
                        paymentTerms.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return paymentTerms?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<SubClassification[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(SubClassification data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorysubclassifications_remove"))
            {
                query.AddParameter("@_SubClassificationId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(SubClassification data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(SubClassification data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorysubclassifications_update"))
            {
                query.AddParameter("@_SubClassificationId", data.Id);
                query.AddParameter("@_ClassificationId", data.Classification?.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_MeasurementUnitId", data.MeasurementUnit?.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(SubClassification data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
