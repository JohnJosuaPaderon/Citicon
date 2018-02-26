using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Citicon.Data
{
    public sealed class TripReportDeliveryCollection : ICollection<Delivery>
    {
        public TripReportDeliveryCollection(TripReportProject tripProject)
        {
            TripProject = tripProject ?? throw new ArgumentNullException(nameof(tripProject));
            Dictionary = new Dictionary<ulong, Delivery>();
        }

        public TripReportProject TripProject { get; }
        private Dictionary<ulong, Delivery> Dictionary { get; }

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(Delivery item)
        {
            if (item != null && !Dictionary.ContainsKey(item.Id))
            {
                Dictionary.Add(item.Id, item);
            }
        }

        public string DeliveryReceiptNumberAggregate
        {
            get
            {
                if (Dictionary.Any())
                {
                    var stringBuilder = new StringBuilder();
                    var array = Dictionary.Values.ToArray();

                    for (int i = 0; i < array.Length; i++)
                    {
                        stringBuilder.Append(array[i].DeliveryReceiptNumberDisplay);

                        if (i < array.Length - 1)
                        {
                            stringBuilder.Append(", ");
                        }
                    }

                    return stringBuilder.ToString();
                }
                else
                {
                    return null;
                }
            }
        }

        public TransitMixer TransitMixer
        {
            get
            {
                if (Dictionary.Any())
                {
                    return Dictionary.First().Value.TransitMixer;
                }
                else
                {
                    return null;
                }
            }
        }

        public decimal PricePerTrip
        {
            get
            {
                if (Dictionary.Any())
                {
                    return Dictionary.First().Value.Route.Rate;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int TripCount
        {
            get { return Dictionary.Count; }
        }

        public decimal TotalAmount
        {
            get
            {
                var result = 0M;

                foreach (var delivery in Dictionary.Values)
                {
                    result += delivery.Route.Rate;
                }

                return result;
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
