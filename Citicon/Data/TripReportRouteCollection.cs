using System;
using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class TripReportRouteCollection : ICollection<TripReportRoute>
    {
        public TripReportRouteCollection(TripReportClient tripClient)
        {
            TripClient = tripClient ?? throw new ArgumentNullException(nameof(tripClient));
            Dictionary = new Dictionary<DeliveryRoute, TripReportRoute>();
        }

        public TripReportClient TripClient { get; }
        public Dictionary<DeliveryRoute, TripReportRoute> Dictionary { get; }

        public TripReportRoute this[DeliveryRoute route]
        {
            get
            {
                if (route != null)
                {
                    if (!Dictionary.ContainsKey(route))
                    {
                        Dictionary.Add(route, new TripReportRoute(route));
                    }

                    return Dictionary[route];
                }
                else
                {
                    return null;
                }
            }
        }

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(TripReportRoute item)
        {
            if (item != null && !Dictionary.ContainsKey(item.Route))
            {
                Dictionary.Add(item.Route, item);
            }
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public bool Contains(TripReportRoute item)
        {
            if (item != null)
            {
                return Dictionary.ContainsKey(item.Route);
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(TripReportRoute[] array, int arrayIndex)
        {
            Dictionary.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TripReportRoute> GetEnumerator()
        {
            return Dictionary.Values.GetEnumerator();
        }

        public bool Remove(TripReportRoute item)
        {
            if (item != null && Dictionary.ContainsKey(item.Route))
            {
                return Dictionary.Remove(item.Route);
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
