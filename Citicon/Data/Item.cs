namespace Citicon.Inventory.Data
{
    public sealed class Item : Sorschia.Data
    {
        private ulong id;
        private Classification classification;
        private MeasurementUnit measurementunit;
        private string code;
        private string description;
        private decimal stockvalue;
        private bool cementsupplied;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Item.Id", value);
            }
        }
        public Classification Classification
        {
            get { return classification; }
            set
            {
                classification = value;
                OnPropertyChanged("Item.Classification", value);
            }
        }
        public MeasurementUnit MeasurementUnit
        {
            get { return measurementunit; }
            set
            {
                measurementunit = value;
                OnPropertyChanged("Item.MeasurementUnit", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("Item.Code", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Item.Description", value);
            }
        }
        public decimal StockValue
        {
            get { return stockvalue; }
            set
            {
                stockvalue = value;
                OnPropertyChanged("Item.StockValue", value);
            }
        }
        public bool CementSupplied
        {
            get { return cementsupplied; }
            set
            {
                if (cementsupplied != value)
                {
                    cementsupplied = value;
                    OnPropertyChanged("CementSupplied", value);
                }
            }
        }
        public static bool operator ==(Item x, Item y)
        {
            return
                x?.classification == y?.classification &&
                x?.code == y?.code &&
                x?.description == y?.description;
        }
        public static bool operator !=(Item x, Item y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Item) ? (obj as Item).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return description;
        }
    }
}
