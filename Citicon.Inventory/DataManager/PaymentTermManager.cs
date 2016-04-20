using Citicon.Data;
using Citicon.Inventory.Data;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.Inventory.DataManager
{
    public sealed class PaymentTermManager : DataManager<PaymentTerm>, IDataManager<PaymentTerm>
    {
        public void Add(PaymentTerm data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorypaymentterms_add"))
            {
                query.AddParameter("@_PaymentTermId");
                query.AddParameter("@_DayCount", data.DayCount);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_PaymentTermId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(PaymentTerm data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public PaymentTerm ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                return new PaymentTerm
                {
                    DayCount = dictionary.GetUInt32("DayCount"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("PaymentTermId")
                };
            }
            return null;
        }

        public PaymentTerm GetById(ulong id)
        {
            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorypaymentterms_getbyid"))
                {
                    query.AddParameter("@_PaymentTermId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Task<PaymentTerm> GetByIdAsync(ulong id)
        {
            return Task.Factory.StartNew(() => GetById(id));
        }

        public PaymentTerm[] GetList()
        {
            List<PaymentTerm> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorypaymentterms_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<PaymentTerm>();
                    foreach (var item in result)
                    {
                        paymentTerms.Add(ExtractFromDictionary(item));
                    }
                }
            }
            return paymentTerms?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<PaymentTerm[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public void Remove(PaymentTerm data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorypaymentterms_remove"))
            {
                query.AddParameter("@_PaymentTermId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(PaymentTerm data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(PaymentTerm data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventorypaymentterms_update"))
            {
                query.AddParameter("@_PaymentTermId", data.Id);
                query.AddParameter("@_DayCount", data.DayCount);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(PaymentTerm data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
