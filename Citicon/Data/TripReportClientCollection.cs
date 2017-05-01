using System;
using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class TripReportClientCollection : ICollection<TripReportClient>
    {
        public TripReportClientCollection(TripReportDate tripDate)
        {
            TripDate = tripDate ?? throw new ArgumentNullException(nameof(tripDate));
            Dictionary = new Dictionary<Client, TripReportClient>();
        }

        public TripReportDate TripDate { get; }
        private Dictionary<Client, TripReportClient> Dictionary { get; }

        public TripReportClient this[Client client]
        {
            get
            {
                if (client != null)
                {
                    if (!Dictionary.ContainsKey(client))
                    {
                        Dictionary.Add(client, new TripReportClient(client));
                    }

                    return Dictionary[client];
                }
                else
                {
                    return null;
                }
            }
        }

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(TripReportClient item)
        {
            if (item != null && !Dictionary.ContainsKey(item.Client))
            {
                Dictionary.Add(item.Client, item);
            }
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public bool Contains(TripReportClient item)
        {
            if (item != null)
            {
                return Dictionary.ContainsKey(item.Client);
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(TripReportClient[] array, int arrayIndex)
        {
            Dictionary.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TripReportClient> GetEnumerator()
        {
            return Dictionary.Values.GetEnumerator();
        }

        public bool Remove(TripReportClient item)
        {
            if (item != null && Dictionary.ContainsKey(item.Client))
            {
                return Dictionary.Remove(item.Client);
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
