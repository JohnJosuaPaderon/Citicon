using Citicon.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class Transaction : Sorschia.Data
    {
        private ulong id;
        private Item item;
        private uint laststockvalue;
        private uint removedstockvalue;
        private string purpose;
        private string requestedby;
        private Branch branch;
        private Company company;
        private DateTime transactiondate;
        private string releasedby;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Transaction.Id", value);
            }
        }
        public Item Item
        {
            get { return item; }
            set
            {
                item = value;
                OnPropertyChanged("Transaction.Item", value);
            }
        }
        public uint LastStockValue
        {
            get { return laststockvalue; }
            set
            {
                laststockvalue = value;
                OnPropertyChanged("Transaction.LastStockValue", value);
            }
        }
        public uint RemovedStockValue
        {
            get { return removedstockvalue; }
            set
            {
                removedstockvalue = value;
                OnPropertyChanged("Transaction.RemovedStockValue", value);
            }
        }
        public string Purpose
        {
            get { return purpose; }
            set
            {
                purpose = value;
                OnPropertyChanged("Transaction.Purpose", value);
            }
        }
        public string RequestedBy
        {
            get { return requestedby; }
            set
            {
                requestedby = value;
                OnPropertyChanged("Transaction.RequestedBy", value);
            }
        }
        public Branch Branch
        {
            get { return branch; }
            set
            {
                branch = value;
                OnPropertyChanged("Transaction.Branch", value);
            }
        }
        public Company Company
        {
            get { return company; }
            set
            {
                company = value;
                OnPropertyChanged("Transaction.Company", value);
            }
        }
        public DateTime TransactionDate
        {
            get { return transactiondate; }
            set
            {
                transactiondate = value;
                OnPropertyChanged("Transaction.TransactionDate", value);
            }
        }
        public string ReleasedBy
        {
            get { return releasedby; }
            set
            {
                releasedby = value;
                OnPropertyChanged("Transaction.ReleasedBy", value);
            }
        }
        public static bool operator ==(Transaction x, Transaction y)
        {
            return
                x?.item == y?.item &&
                x?.laststockvalue == y?.laststockvalue &&
                x?.removedstockvalue == y?.removedstockvalue &&
                x?.branch == y?.branch &&
                x?.company == y?.company;
        }
        public static bool operator !=(Transaction x, Transaction y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Transaction) ? (obj as Transaction).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return item.ToString();
        }
    }
}
