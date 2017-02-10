using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class TruckManager : DataManager<Truck>, IDataManager<Truck>
    {
        public void Add(Truck data)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Truck data)
        {
            throw new NotImplementedException();
        }

        public Truck ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Truck
                {
                    AdditionalCharge = dictionary.GetDouble("AdditionCharge"),
                    Capacity = dictionary.GetDouble("Capacity"),
                    Id = dictionary.GetUInt64("TruckID"),
                    LoadNumber = dictionary.GetString("LoadNo"),
                    Number = dictionary.GetString("TruckNo"),
                    WheelCount = dictionary.GetUInt32("WheelsCount")
                };
            }
            return null;
        }

        public Truck GetById(ulong id)
        {
            if (id > 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "tbltrucks_getbyid"))
                {
                    query.AddParameter("@_TruckID", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Truck[] GetList()
        {
            List<Truck> trucks = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "tbltrucks_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    trucks = new List<Truck>();
                    foreach (var item in result) trucks.Add(ExtractFromDictionary(item));
                }
            }
            return trucks?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Truck[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(Truck data)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Truck data)
        {
            throw new NotImplementedException();
        }

        public void Update(Truck data)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Truck data)
        {
            throw new NotImplementedException();
        }
    }
}
