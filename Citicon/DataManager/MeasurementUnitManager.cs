using Citicon.Data;
using Citicon.Inventory.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.Inventory.DataManager
{
    public sealed class MeasurementUnitManager : DataManager<MeasurementUnit>, IDataManager<MeasurementUnit>
    {
        static MeasurementUnitManager()
        {
            MeasurementUnitDict = new Dictionary<ulong, MeasurementUnit>();
        }

        private static Dictionary<ulong, MeasurementUnit> MeasurementUnitDict { get; }

        public void Add(MeasurementUnit data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorymeasurementunits_add"))
            {
                query.AddParameter("@_MeasurementUnitId");
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_Symbol", data.Symbol);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_MeasurementUnitId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }
        public Task AddAsync(MeasurementUnit data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public MeasurementUnit ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                var measurementUnit = new MeasurementUnit
                {
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("MeasurementUnitId"),
                    Symbol = dictionary.GetString("Symbol")
                };

                if (!MeasurementUnitDict.ContainsKey(measurementUnit.Id))
                {
                    MeasurementUnitDict.Add(measurementUnit.Id, measurementUnit);
                }

                return measurementUnit;
            }
            else
            {
                return null;
            }
        }

        public MeasurementUnit GetById(ulong id)
        {
            if (MeasurementUnitDict.ContainsKey(id))
            {
                return MeasurementUnitDict[id];
            }

            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorymeasurementunits_getbyid"))
                {
                    query.AddParameter("@_MeasurementUnitId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<MeasurementUnit> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public MeasurementUnit[] GetList()
        {
            List<MeasurementUnit> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorymeasurementunits_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<MeasurementUnit>();
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

        public Task<MeasurementUnit[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(MeasurementUnit data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorymeasurementunits_remove"))
            {
                query.AddParameter("@_MeasurementUnitId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(MeasurementUnit data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(MeasurementUnit data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorymeasurementunits_update"))
            {
                query.AddParameter("@_MeasurementUnitId", data.Id);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_Symbol", data.Symbol);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(MeasurementUnit data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
