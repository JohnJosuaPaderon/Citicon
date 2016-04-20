﻿using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class VehicleTypeManager : DataManager<VehicleType>, IDataManager<VehicleType>
    {
        public void Add(VehicleType data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicletypes_add"))
            {
                query.AddParameter("@_VehicleTypeId");
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_VehicleTypeId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(VehicleType data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public VehicleType ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new VehicleType
                {
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("VehicleTypeId")
                };
            }
            return null;
        }
        public VehicleType GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicletypes_getbyid"))
                {
                    query.AddParameter("@_VehicleTypeId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<VehicleType> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public VehicleType[] GetList()
        {
            List<VehicleType> vehicleTypes = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicletypes_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    vehicleTypes = new List<VehicleType>();
                    foreach (var item in result)
                    {
                        vehicleTypes.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return vehicleTypes?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<VehicleType[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(VehicleType data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicletypes_remove"))
            {
                query.AddParameter("@_VehicleTypeId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(VehicleType data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(VehicleType data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_vehicletypes_update"))
            {
                query.AddParameter("@_VehicleTypeId", data.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }
        public Task UpdateAsync(VehicleType data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
