using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citicon.Data
{
    public sealed class Truck : Sorschia.Data
    {
        private ulong id;
        private string number;
        private uint wheelcount;
        private double capacity;
        private string loadnumber;
        private double additionalcharge;
        public ulong Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("Truck.Id", value);
                }
            }
        }
        public string Number
        {
            get { return number; }
            set
            {
                if (number != value)
                {
                    number = value;
                    OnPropertyChanged("Truck.Number", value);
                }
            }
        }
        public uint WheelCount
        {
            get { return wheelcount; }
            set
            {
                if (wheelcount != value)
                {
                    wheelcount = value;
                    OnPropertyChanged("Truck.WheelCount", value);
                }
            }
        }
        public double Capacity
        {
            get { return capacity; }
            set
            {
                if (capacity != value)
                {
                    capacity = value;
                    OnPropertyChanged("Truck.Capacity", value);
                }
            }
        }
        public string LoadNumber
        {
            get { return loadnumber; }
            set
            {
                if (loadnumber != value)
                {
                    loadnumber = value;
                    OnPropertyChanged("Truck.LoadNumber", value);
                }
            }
        }
        public double AdditionalCharge
        {
            get { return additionalcharge; }
            set
            {
                additionalcharge = value;
                OnPropertyChanged("Truck.AdditionalCharge", value);
            }
        }
        public static bool operator ==(Truck x, Truck y)
        {
            return
                x?.number == y?.number &&
                x?.wheelcount == y?.wheelcount;
        }
        public static bool operator !=(Truck x, Truck y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Truck) ? (obj as Truck).id == id : false;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        public override string ToString()
        {
            return number;
        }
    }
}
