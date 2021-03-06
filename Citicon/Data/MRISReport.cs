﻿using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class MRISReport
    {
        public MRISReport()
        {
            Stocks = new List<Stock>();
        }

        public List<Stock> Stocks { get; }
        public string Usage { get; set; }
        public string ReceivedStoredBy { get; set; }
        public string InspectedAcceptedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string MRISNumber { get; private set; }
        public Supplier Supplier { get; private set; }
        public DateTime? DeliveryDate { get; private set; }

        public void RefreshData()
        {
            foreach (var item in Stocks)
            {
                if (Supplier == null && DeliveryDate == null && MRISNumber == null)
                {
                    Supplier = item.Supplier;
                    DeliveryDate = item.DeliveryDate;
                    MRISNumber = item.MrisNumber;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
