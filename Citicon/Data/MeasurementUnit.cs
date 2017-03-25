using Citicon.Inventory.DataManager;
using System;
using System.Configuration;

namespace Citicon.Inventory.Data
{
    public sealed class MeasurementUnit
    {
        public static MeasurementUnit CubicMeter
        {
            get
            {
                ulong.TryParse(ConfigurationManager.AppSettings["MeasurementUnit.Id.CubicMeter"], out ulong id);
                var manager = new MeasurementUnitManager();
                manager.ExceptionCatched += (Exception ex) => { };
                return manager.GetById(id);
            }
        }

        public ulong Id { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }

        public static bool operator ==(MeasurementUnit left, MeasurementUnit right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(MeasurementUnit left, MeasurementUnit right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is MeasurementUnit)
            {
                return (MeasurementUnit)arg == this;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
