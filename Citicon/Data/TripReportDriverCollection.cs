using System;
using System.Collections;
using System.Collections.Generic;

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

        public TripReportDriver this[Employee driver]
        {
            get
            {
                if (driver != null)
                {
                    if (!Dictionary.ContainsKey(driver))
                    {
                        Dictionary.Add(driver, new TripReportDriver(driver));
                    }

                    return Dictionary[driver];
                }
                else
                {
                    return null;
                }
            }
        }

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
            Dictionary.Clear();
        }

        public bool Contains(TripReportDriver item)
        {
            if (item != null)
            {
                return Dictionary.ContainsKey(item.Driver);
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(TripReportDriver[] array, int arrayIndex)
        {
            Dictionary.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TripReportDriver> GetEnumerator()
        {
            return Dictionary.Values.GetEnumerator();
        }

        public bool Remove(TripReportDriver item)
        {
            if (item != null && Dictionary.ContainsKey(item.Driver))
            {
                return Dictionary.Remove(item.Driver);
            }
            else
            {
                return false;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
