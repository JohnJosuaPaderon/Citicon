using Citicon.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class PaymentTerm : Sorschia.Data
    {
        private ulong id;
        private string description;
        private uint daycount;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("PaymentTerm.Id", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("PaymentTerm.Description", value);
            }
        }
        public uint DayCount
        {
            get { return daycount; }
            set
            {
                daycount = value;
                OnPropertyChanged("PaymentTerm.DayCount", value);
            }
        }
        public static bool operator ==(PaymentTerm x, PaymentTerm y)
        {
            return
                x?.description == y?.description &&
                x?.daycount == y?.daycount;
        }
        public static bool operator !=(PaymentTerm x, PaymentTerm y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is PaymentTerm) ? (obj as PaymentTerm).id == id : false;
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
