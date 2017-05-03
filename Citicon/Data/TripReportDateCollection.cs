using System;
using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class TripReportDateCollection : ICollection<TripReportDate>
    {
        public TripReportDateCollection(TripReportDriver tripDriver)
        {
            TripDriver = tripDriver ?? throw new ArgumentNullException(nameof(tripDriver));
            Dictionary = new Dictionary<DateTime, TripReportDate>();
        }

        public TripReportDriver TripDriver { get; }

        private Dictionary<DateTime, TripReportDate> Dictionary { get; }

        public TripReportDate this[DateTime deliveryDate]
        {
            get
            {
                deliveryDate = deliveryDate.Date;

                if (!Dictionary.ContainsKey(deliveryDate))
                {
                    Dictionary.Add(deliveryDate.Date, new TripReportDate(deliveryDate));
                }

                return Dictionary[deliveryDate];
            }
        }

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(TripReportDate item)
        {
            if (item != null && !Dictionary.ContainsKey(item.DeliveryDate.Date))
            {
                Dictionary.Add(item.DeliveryDate, item);
            }
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public bool Contains(TripReportDate item)
        {
            if (item != null)
            {
                return Dictionary.ContainsKey(item.DeliveryDate.Date);
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(TripReportDate[] array, int arrayIndex)
        {
            Dictionary.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TripReportDate> GetEnumerator()
        {
            return Dictionary.Values.GetEnumerator();
        }

        public bool Remove(TripReportDate item)
        {
            if (item != null && Dictionary.ContainsKey(item.DeliveryDate.Date))
            {
                return Dictionary.Remove(item.DeliveryDate.Date);
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
