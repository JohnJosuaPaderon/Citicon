using Citicon.Data;
using Citicon.Payables.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class Stock : Sorschia.Data
    {
        private ulong id;
        private Item item;
        private Expense expense;
        private DateTime deliverydate;
        private uint sinumber;
        private uint drnumber;
        private string mrisnumber;
        private decimal laststockvalue;
        private decimal addedstockvalue;
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
        private string measurementdescription;
        private Client cementSuppliedClient;
        private bool includeWithHoldingTax;
        private decimal? withHoldingTax;
        private Project[] cementSuppliedProjects;
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
        public Expense Expense
        {
            get { return expense; }
            set
            {
                expense = value;
                OnPropertyChanged("Stock.Expense", value);
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
        public uint SiNumber
        {
            get { return sinumber; }
            set
            {
                sinumber = value;
                OnPropertyChanged("Stock.SiNumber", value);
            }
        }
        public uint DrNumber
        {
            get { return drnumber; }
            set
            {
                if (drnumber != value)
                {
                    drnumber = value;
                    OnPropertyChanged("Stock.DrNumber", value);
                }
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
        public decimal LastStockValue
        {
            get { return laststockvalue; }
            set
            {
                laststockvalue = value;
                OnPropertyChanged("Stock.LastStockValue", value);
            }
        }
        public decimal AddedStockValue
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
        public string MeasurementDescription
        {
            get { return measurementdescription; }
            set
            {
                if (measurementdescription != value)
                {
                    measurementdescription = value;
                    OnPropertyChanged("Stock.MeasurementDescription", value);
                }
            }
        }
        public bool IncludeWithHoldingTax
        {
            get { return includeWithHoldingTax; }
            set
            {
                if (includeWithHoldingTax != value)
                {
                    includeWithHoldingTax = value;
                    OnPropertyChanged(nameof(IncludeWithHoldingTax), value);
                }
            }
        }
        public decimal? WithHoldingTax
        {
            get { return withHoldingTax; }
            set
            {
                if (withHoldingTax != value)
                {
                    withHoldingTax = value;
                    OnPropertyChanged(nameof(WithHoldingTax), value);
                }
            }
        }
        public Client CementSuppliedClient
        {
            get { return cementSuppliedClient; }
            set
            {
                if (cementSuppliedClient != value)
                {
                    cementSuppliedClient = value;
                    OnPropertyChanged(nameof(CementSuppliedClient), value);
                }
            }
        }
        public Project[] CementSuppliedProjects
        {
            get { return cementSuppliedProjects; }
            set
            {
                if (cementSuppliedProjects != value)
                {
                    cementSuppliedProjects = value;
                    OnPropertyChanged(nameof(CementSuppliedClient), value);
                }
            }
        }
        public static bool operator ==(Stock x, Stock y)
        {
            return
                x?.item == y?.item &&
                x?.deliverydate == y?.deliverydate &&
                x?.sinumber == y?.sinumber &&
                x?.drnumber == y?.drnumber &&
                x?.mrisnumber == y?.mrisnumber &&
                x?.paymentterm == y?.paymentterm &&
                x?.addedstockvalue == y?.addedstockvalue &&
                x?.unitprice == y?.unitprice &&
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
            return expense != null ? expense.Description : item?.ToString() ?? string.Empty;
        }
    }
}
