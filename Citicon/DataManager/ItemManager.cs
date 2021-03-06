﻿using Citicon.Data;
using Citicon.DataProcess;
using Sorschia;
using Sorschia.Extensions;
using Sorschia.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public sealed class ItemManager : DataManager<Item>, IDataManager<Item>
    {
        static ItemManager()
        {
            ItemDict = new Dictionary<ulong, Item>();
        }

        private static Dictionary<ulong, Item> ItemDict { get; }

        public event DataManagerEventHandler<Tuple<Stock, Transaction>> NewTrackRecordGenerated;

        public static Task<IEnumerable<Item>> SearchAsync(SearchItemCategory category, string searchKey)
        {
            using (var process = new SearchItem(category, searchKey))
            {
                return process.ExecuteAsync();
            }
        }

        public void Add(Item data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryitems_add"))
            {
                query.AddParameter("@_ItemId");
                query.AddParameter("@_ClassificationId", data.Classification?.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_StockValue", data.StockValue);
                query.AddParameter("@_MeasurementUnitId", data.MeasurementUnit?.Id);
                query.AddParameter("@_CreatedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_CementSupplied", data.CementSupplied);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1)
                {
                    data.Id = query.ParameterValues.GetUInt64("@_ItemId");
                    OnAdded(data);
                }
                else OnAddedUnsuccessful(data);
            }
        }

        public Task AddAsync(Item data)
        {
            return Task.Factory.StartNew(() => Add(data));
        }

        public Item ExtractFromDictionary(Dictionary<string, object> dictionary)
        {
            if (dictionary != null)
            {
                var item = new Item
                {
                    Classification = (new ClassificationManager()).GetById(dictionary.GetUInt64("ClassificationId")),
                    Code = dictionary.GetString("Code"),
                    Description = dictionary.GetString("Description"),
                    Id = dictionary.GetUInt64("ItemId"),
                    StockValue = dictionary.GetDecimal("StockValue"),
                    MeasurementUnit = (new MeasurementUnitManager()).GetById(dictionary.GetUInt64("MeasurementUnitId")),
                    CementSupplied = dictionary.GetBoolean("CementSupplied")
                };

                if (!ItemDict.ContainsKey(item.Id))
                {
                    ItemDict.Add(item.Id, item);
                }

                return item;
            }
            else
            {
                return null; 
            }
        }

        public List<Tuple<DateTime, decimal>> GetPriceHistory(Item item)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_InventoryItems_GetPriceHistory"))
            {
                query.AddParameter("@_ItemId", item.Id);
                List<Tuple<DateTime, decimal>> priceHistory = null;
                var result = query.GetResult();
                if (result != null)
                {
                    priceHistory = new List<Tuple<DateTime, decimal>>();
                    foreach (var x in result)
                    {
                        priceHistory.Add(new Tuple<DateTime, decimal>(x.GetDateTime("DeliveryDate"), x.GetDecimal("UnitPrice")));
                    }
                }
                return priceHistory;
            }
        }

        public string GenerateCode(Classification classification)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "SELECT _inventoryitems_generatecode(@_ClassificationId);", CommandType.Text))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.AddParameter("@_ClassificationId", classification?.Id);
                return query.GetValue().ToString();
            }
        }

        public Item GetById(ulong id)
        {
            if (ItemDict.ContainsKey(id))
            {
                return ItemDict[id];
            }

            if (id != 0)
            {
                using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryitems_getbyid"))
                {
                    query.AddParameter("@_ItemId", id);
                    query.ExceptionCatched += OnExceptionCatched;
                    return ExtractFromDictionary(query.GetRecord());
                }
            }
            return null;
        }

        public Item[] GetList()
        {
            List<Item> paymentTerms = null;
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryitems_getlist"))
            {
                query.ExceptionCatched += OnExceptionCatched;
                query.ActiveRecordChanged += Query_ActiveRecordChanged;
                var result = query.GetResult();
                if (result != null)
                {
                    paymentTerms = new List<Item>();

                    foreach (var item in result)
                    {
                        Parallel.Invoke(() => paymentTerms.Add(ExtractFromDictionary(item)));
                    }
                }
            }
            return paymentTerms?.ToArray();
        }

        private void Query_ActiveRecordChanged(Dictionary<string, object> e)
        {
            OnNewItemGenerated(ExtractFromDictionary(e));
        }

        public Task<Item[]> GetListAsync()
        {
            return Task.Factory.StartNew(GetList);
        }

        public Tuple<Stock, Transaction>[] GetTrackings(Item item)
        {
            List<Tuple<Stock, Transaction>> trackings = null;
            using (var trackingQuery = new MySqlQuery(Supports.ConnectionString, "_inventoryitems_tracking"))
            {
                trackingQuery.AddParameter("@_ItemId", item?.Id);
                trackingQuery.ExceptionCatched += OnExceptionCatched;
                trackingQuery.ActiveRecordChanged += TrackingQuery_ActiveRecordChanged;
                var result = trackingQuery.GetResult();
                if (result != null)
                {
                    trackings = new List<Tuple<Stock, Transaction>>();
                    foreach (var track in result)
                    {
                        if (track.GetUInt64("StockId") > 0)
                        {
                            trackings.Add(new Tuple<Stock, Transaction>(
                                (new StockManager()).ExtractFromDictionary(track),
                                null));
                        }
                        else if(track.GetUInt64("TransactionId") > 0)
                        {
                            trackings.Add(new Tuple<Stock, Transaction>(
                                null,
                                (new TransactionManager()).ExtractFromDictionary(track)));
                        }
                    }
                }
            }
            return trackings?.ToArray();
        }

        public Task<Tuple<Stock, Transaction>[]> GetTrackingsAsync(Item item)
        {
            return Task.Factory.StartNew(() => GetTrackings(item));
        }

        private void TrackingQuery_ActiveRecordChanged(Dictionary<string, object> e)
        {
            if (NewTrackRecordGenerated != null)
            {
                if (e.GetUInt64("StockId") > 0)
                {
                    NewTrackRecordGenerated(new Tuple<Stock, Transaction>(
                        (new StockManager()).ExtractFromDictionary(e),
                        null));
                }
                else if(e.GetUInt64("TransactionId") > 0)
                {
                    NewTrackRecordGenerated(new Tuple<Stock, Transaction>(
                        null,
                        (new TransactionManager()).ExtractFromDictionary(e)));
                }
            }
        }

        public void Remove(Item data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryitems_remove"))
            {
                query.AddParameter("@_ItemId", data.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.ExceptionCatched += OnExceptionCatched;
                query.Execute();
                if (query.AffectedRows == 1) OnRemoved(data);
                else OnRemovedUnsuccessful(data);
            }
        }

        public Task RemoveAsync(Item data)
        {
            return Task.Factory.StartNew(() => Remove(data));
        }

        public void Update(Item data)
        {
            using (var query = new MySqlQuery(Supports.ConnectionString, "_inventoryitems_update"))
            {
                query.AddParameter("@_ItemId", data.Id);
                query.AddParameter("@_ClassificationId", data.Classification?.Id);
                query.AddParameter("@_Code", data.Code);
                query.AddParameter("@_Description", data.Description);
                query.AddParameter("@_StockValue", data.StockValue);
                query.AddParameter("@_MeasurementUnitId", data.MeasurementUnit?.Id);
                query.AddParameter("@_ModifiedBy", User.CurrentUser?.DisplayName);
                query.AddParameter("@_CementSupplied", data.CementSupplied);
                query.Execute();
                if (query.AffectedRows == 1) OnUpdated(data);
                else OnUpdatedUnsuccessful(data);
            }
        }

        public Task UpdateAsync(Item data)
        {
            return Task.Factory.StartNew(() => Update(data));
        }
    }
}
