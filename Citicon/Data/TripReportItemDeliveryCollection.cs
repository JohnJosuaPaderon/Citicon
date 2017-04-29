using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Citicon.Data
{
    public class TripReportItemDeliveryCollection : ICollection<Delivery>
    {
        public TripReportItemDeliveryCollection(TripReportItem tripReportItem)
        {
            TripReportItem = tripReportItem ?? throw new ArgumentNullException(nameof(tripReportItem));
        }

        public TripReportItem TripReportItem { get; }

        private Dictionary<ulong, Delivery> Dictionary { get; } = new Dictionary<ulong, Delivery>();

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public DateTime MeanDeliveryDate
        {
            get
            {
                if (Dictionary.Any())
                {
                    return Dictionary.Values.ElementAt(0).DeliveryDate;
                }
                else
                {
                    return default(DateTime);
                }
            }
        }

        public void Add(Delivery item)
        {
            if (item != null && !Dictionary.ContainsKey(item.Id))
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
