using Citicon.Data;
using Citicon.DataProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public class DepartmentManager
    {
        static DepartmentManager()
        {
            Storage = new Dictionary<long, Department>();
        }

        private static Dictionary<long, Department> Storage;

        public static Department GetById(long id)
        {
            if (Storage.ContainsKey(id))
            {
                return Storage[id];
            }
            else
            {
                using (var getById = new GetDepartmentById(id))
                {
                    var department = getById.Return();
                    if (department != null)
                    {
                        Storage.Add(id, department);
                    }
                    return department;
                }
            }
        }
    }
}
