using Citicon.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class ModuleManager : DataManager<Module>, IDataManager<Module>
    {
        public void Add(Module data)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Module data)
        {
            throw new NotImplementedException();
        }

        public Module ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new Module
                {
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("ModuleId")
                };
            }
            return null;
        }

        public Module GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_module_getbyid"))
                {
                    query.AddParameter("@_ModuleId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Module[] GetList()
        {
            throw new NotImplementedException();
        }

        public Task<Module[]> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(Module data)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Module data)
        {
            throw new NotImplementedException();
        }

        public void Update(Module data)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Module data)
        {
            throw new NotImplementedException();
        }
    }
}
