using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class VehicleManager : DataManager<Vehicle>, IDataManager<Vehicle>
    {
        public void Add(Vehicle data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicles_add"))
            {
                query.AddParameter("@_VehicleId");
                query.AddParameter("@_PhysicalNumber", data.PhysicalNumber);
                query.AddParameter("@_PlateNumber", data.PlateNumber);
                query.AddParameter("@_TypeId", data.Type?.Id);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_VehicleId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Vehicle data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public Vehicle ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Vehicle
                {
                    Id = dictionary.GetUInt64("VehicleId"),
                    PhysicalNumber = dictionary.GetString("PhysicalNumber"),
                    PlateNumber = dictionary.GetString("PlateNumber"),
                    Type = (new VehicleTypeManager()).GetById(dictionary.GetUInt64("TypeId"))
                };
            }
            return null;
        }

        public Vehicle GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicles_getbyid"))
                {
                    query.AddParameter("@_VehicleId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<Vehicle> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public Vehicle[] GetList()
        {
            List<Vehicle> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicles_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<Vehicle>();
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

        public Task<Vehicle[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Vehicle data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicles_remove"))
            {
                query.AddParameter("@_VehicleId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Vehicle data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Vehicle data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicles_update"))
            {
                query.AddParameter("@_VehicleId", data.Id);
                query.AddParameter("@_PhysicalNumber", data.PhysicalNumber);
                query.AddParameter("@_PlateNumber", data.PlateNumber);
                query.AddParameter("@_TypeId", data.Type?.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Vehicle data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
