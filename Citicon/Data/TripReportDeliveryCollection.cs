using System;
using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class TripReportDeliveryCollection : ICollection<Delivery>
    {
        public TripReportDeliveryCollection(TripReportRoute tripRoute)
        {
            TripRoute = tripRoute ?? throw new ArgumentNullException(nameof(tripRoute));
            Dictionary = new Dictionary<ulong, Delivery>();
        }

        public TripReportRoute TripRoute { get; }
        private Dictionary<ulong, Delivery> Dictionary { get; }

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(Delivery item)
        {
            if (item != null && !Dictionary.ContainsKey(item.Id) && item.Route == TripRoute.Route)
            {
                Dictionary.Add(item.Id, item);
            }
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public bool Contains(Delivery item)
        {
            if (item != null)
            {
                return Dictionary.ContainsKey(item.Id);
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(Delivery[] array, int arrayIndex)
        {
            Dictionary.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Delivery> GetEnumerator()
        {
            return Dictionary.Values.GetEnumerator();
        }

        public bool Remove(Delivery item)
        {
            if (item != null && Dictionary.ContainsKey(item.Id))
            {
                return Dictionary.Remove(item.Id);
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
