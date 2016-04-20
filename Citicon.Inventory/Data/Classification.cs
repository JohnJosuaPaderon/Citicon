using Citicon.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class Classification : Sorschia.Data
    {
        private ulong id;
        private string code;
        private string description;
        private MeasurementUnit measurementunit;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Classification.Id", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("Classification.Code", value);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("Classification.Description", value);
            }
        }
        public MeasurementUnit MeasurementUnit
        {
            get { return measurementunit; }
            set
            {
                measurementunit = value;
                OnPropertyChanged("Classification.MeasurementUnit", value);
            }
        }
        public static bool operator ==(Classification x, Classification y)
        {
            return
                x?.code == y?.code &&
                x?.description == y?.description &&
                x?.measurementunit == y?.measurementunit;
        }
        public static bool operator !=(Classification x, Classification y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is Classification) ? (obj as Classification).id == id : false;
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
