using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public class TripReportDriverCollection : ICollection<TripReportDriver>
    {
        public TripReportDriverCollection(TripReport tripReport)
        {
            TripReport = tripReport ?? throw new ArgumentNullException(nameof(tripReport));
            Dictionary = new Dictionary<Employee, TripReportDriver>();
        }

        public TripReport TripReport { get; }
        private Dictionary<Employee, TripReportDriver> Dictionary { get; }

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(TripReportDriver item)
        {
            if (item != null && !Dictionary.ContainsKey(item.Driver))
            {
                Dictionary.Add(item.Driver, item);
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(TripReportDriver item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(TripReportDriver[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TripReportDriver> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(TripReportDriver item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
