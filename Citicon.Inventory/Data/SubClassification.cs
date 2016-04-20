using Citicon.Data;
using System;

namespace Citicon.Inventory.Data
{
    public sealed class SubClassification : Sorschia.Data
    {
        private ulong id;
        private string code;
        private Classification classification;
        private string description;
        private MeasurementUnit measurementunit;
        public ulong Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("SubClassification.Id", value);
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged("SubClassification.Code", value);
            }
        }
        public Classification Classification
        {
            get { return classification; }
            set
            {
                classification = value;
                OnPropertyChanged("SubClassification.Classification", classification);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged("SubClassification.Description", description);
            }
        }
        public MeasurementUnit MeasurementUnit
        {
            get { return measurementunit; }
            set
            {
                measurementunit = value;
                OnPropertyChanged("SubClassification.MeasurementUnit", value);
            }
        }
        public static bool operator ==(SubClassification x, SubClassification y)
        {
            return
                x?.code == y?.code &&
                x?.classification == y?.classification &&
                x?.description == y?.description;
        }
        public static bool operator !=(SubClassification x, SubClassification y)
        {
            return !(x == y);
        }
        public override bool Equals(object obj)
        {
            return (obj is SubClassification) ? (obj as SubClassification).id == id : false;
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
