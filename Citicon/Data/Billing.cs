using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class Billing
    {
        public ulong Id { get; set; }
        public string BillingNo { get; set; }
        public DateTime BillingDate { get; set; }
        public string SiNumber { get; set; }
        public decimal Volume { get; set; }
        public decimal AmountDue { get; set; }
        public decimal AmountPaid { get; set; }
        public BillingStructureType StructureType { get; set; }
        public Project Project { get; set; }
        public decimal SubTotal
        {
            get
            {
                return AmountDue - AmountPaid;
            }
        }
        public string PreparedBy { get; set; }
        public string CheckedBy { get; set; }
        public string CertifiedBy { get; set; }
        public string ReceivedBy { get; set; }
        public List<PumpcreteCharge> PumpcreteCharges { get; } = new List<PumpcreteCharge>();
        public List<ExcessPipeCharge> ExcessPipeCharges { get; } = new List<ExcessPipeCharge>();
        public List<OtherCharge> OtherCharges { get; } = new List<OtherCharge>();
        public List<Delivery> Deliveries { get; } = new List<Delivery>();

        public override bool Equals(object obj)
        {
            return (obj is Billing) ? ((Billing)obj).Id == Id : false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return BillingNo;
        }
        public decimal GetAmountDue()
        {
            decimal amountDue = 0;

            foreach (PumpcreteCharge pumpcreteCharge in PumpcreteCharges)
            {
                amountDue += pumpcreteCharge.TotalAmount;
            }

            foreach (ExcessPipeCharge excessPipeCharge in ExcessPipeCharges)
            {
                amountDue += excessPipeCharge.TotalAmount;
            }

            foreach (OtherCharge otherCharge in OtherCharges)
            {
                amountDue += otherCharge.TotalAmount;
            }

            foreach (Delivery delivery in Deliveries)
            {
                amountDue += (delivery.PricePerCubicMeter * delivery.CumulativeVolume);
            }

            return amountDue;
        }
    }
}
