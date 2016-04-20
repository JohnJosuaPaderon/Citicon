using Citicon.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class Stock : Sorschia.Data
    {
        private ulong id;
        private Item item;
        private DateTime deliverydate;
        private string sidrnumber;
        private string mrisnumber;
        private uint laststockvalue;
        private uint addedstockvalue;
        private decimal unitprice;
        private PaymentTerm paymentterm;
        private DateTime duedate;
        private Vehicle vehicle;
        private string acceptedby;
        private Branch branch;
        private Company company;
        private Supplier supplier;
        private bool paid;
        private string remarks;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Stock.Id", value);
            }
        }
        public Item Item
        {
            get { return item; }
            set
            {
                item = value;
                OnPropertyChanged("Stock.Item", value);
            }
        }
        public DateTime DeliveryDate
        {
            get { return deliverydate; }
            set
            {
                deliverydate = value;
                OnPropertyChanged("Stock.DeliveryDate", value);
            }
        }
        public string SidrNumber
        {
            get { return sidrnumber; }
            set
            {
                sidrnumber = value;
                OnPropertyChanged("Stock.SidrNumber", value);
            }
        }
        public string MrisNumber
        {
            get { return mrisnumber; }
            set
            {
                mrisnumber = value;
                OnPropertyChanged("Stock.MrisNumber", value);
            }
        }
        public uint LastStockValue
        {
            get { return laststockvalue; }
            set
            {
                laststockvalue = value;
                OnPropertyChanged("Stock.LastStockValue", value);
            }
        }
        public uint AddedStockValue
        {
            get { return addedstockvalue; }
            set
            {
                addedstockvalue = value;
                OnPropertyChanged("Stock.AddedStockValue", value);
            }
        }
        public decimal UnitPrice
        {
            get { return unitprice; }
            set
            {
                unitprice = value;
                OnPropertyChanged("Stock.UnitPrice", value);
            }
        }
        public PaymentTerm PaymentTerm
        {
            get { return paymentterm; }
            set
            {
                paymentterm = value;
                OnPropertyChanged("Stock.PaymentTerm", value);
            }
        }
        public DateTime DueDate
        {
            get { return duedate; }
            set
            {
                duedate = value;
                OnPropertyChanged("Stock.DueDate", value);
            }
        }
        public Vehicle Vehicle
        {
            get { return vehicle; }
            set
            {
                vehicle = value;
                OnPropertyChanged("Stock.Vehicle", value);
            }
        }
        public string AcceptedBy
        {
            get { return acceptedby; }
            set
            {
                acceptedby = value;
                OnPropertyChanged("Stock.AcceptedBy", value);
            }
        }
        public Branch Branch
        {
            get { return branch; }
            set
            {
                branch = value;
                OnPropertyChanged("Stock.Branch", value);
            }
        }
        public Company Company
        {
            get { return company; }
            set
            {
                company = value;
                OnPropertyChanged("Stock.Company", value);
            }
        }
        public Supplier Supplier
        {
            get { return supplier; }
            set
            {
                supplier = value;
                OnPropertyChanged("Stock.Supplier", value);
            }
        }
        public bool Paid
        {
            get { return paid; }
            set
            {
                paid = value;
                OnPropertyChanged("Stock.Paid", value);
            }
        }
        public string Remarks
        {
            get { return remarks; }
            set
            {
                if (remarks != value)
                {
                    remarks = value;
                    OnPropertyChanged("Stock.Remarks", value);
                }
            }
        }
        public static bool operator ==(Stock x, Stock y)
        {
            return
                x?.item == y?.item &&
                x?.deliverydate == y?.deliverydate &&
                x?.sidrnumber == y?.sidrnumber &&
                x?.mrisnumber == y?.mrisnumber &&
                x?.paymentterm == y?.paymentterm &&
                x?.supplier == y?.supplier;
        }
        public static bool operator !=(Stock x, Stock y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Stock) ? (obj as Stock).id == id : false;
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
