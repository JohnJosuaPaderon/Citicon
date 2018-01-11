using Citicon.DataManager;
using System;
using System.Configuration;

namespace Citicon.Data
{
    public sealed class MeasurementUnit : EntityBase<ulong>
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
        
        public string Description { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
