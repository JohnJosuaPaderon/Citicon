using System;
using System.Collections;
using System.Collections.Generic;

namespace Citicon.Data
{
    public sealed class TripReportProjectCollection : ICollection<TripReportProject>
    {
        public TripReportProjectCollection(TripReportDate tripDate)
        {
            TripDate = tripDate ?? throw new ArgumentNullException(nameof(tripDate));
            Dictionary = new Dictionary<Project, TripReportProject>();
        }

        public TripReportDate TripDate { get; }
        private Dictionary<Project, TripReportProject> Dictionary { get; }

        public TripReportProject this[Project project]
        {
            get
            {
                if (project != null)
                {
                    if (!Dictionary.ContainsKey(project))
                    {
                        Dictionary.Add(project, new TripReportProject(project));
                    }

                    return Dictionary[project];
                }
                else
                {
                    return null;
                }
            }
        }

        public int Count => Dictionary.Count;

        public bool IsReadOnly => false;

        public void Add(TripReportProject item)
        {
            if (item != null && !Dictionary.ContainsKey(item.Project))
            {
                Dictionary.Add(item.Project, item);
            }
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public bool Contains(TripReportProject item)
        {
            if (item != null)
            {
                return Dictionary.ContainsKey(item.Project);
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(TripReportProject[] array, int arrayIndex)
        {
            Dictionary.Values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TripReportProject> GetEnumerator()
        {
            return Dictionary.Values.GetEnumerator();
        }

        public bool Remove(TripReportProject item)
        {
            if (item != null && Dictionary.ContainsKey(item.Project))
            {
                return Dictionary.Remove(item.Project);
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
