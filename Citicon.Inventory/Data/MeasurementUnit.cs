using Citicon.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class MeasurementUnit : Sorschia.Data
    {
        private ulong id;
        private string description;
        private string symbol;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("MeasurementUnit.Id", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("MeasurementUnit.Description", value);
            }
        }
        public string Symbol
        {
            get { return symbol; }
            set
            {
                symbol = value;
                OnPropertyChanged("MeasurementUnit.Symbol", value);
            }
        }
        public static bool operator ==(MeasurementUnit x, MeasurementUnit y)
        {
            return
                x?.description == y?.description &&
                x?.symbol == y?.symbol;
        }
        public static bool operator !=(MeasurementUnit x, MeasurementUnit y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is MeasurementUnit) ? (obj as MeasurementUnit).id == id : false;
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
