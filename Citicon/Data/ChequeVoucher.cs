using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class ChequeVoucher
    {
        public ChequeVoucher()
        {
            Remarks = new List<string>();
            Payables = new List<Payable>();
        }

        public DateTime? TransactionDate { get; private set; }
        public string ChequeVoucherNumber { get; private set; }
        public Supplier Payee { get; private set; }
        public decimal GrandTotal { get; private set; }
        public List<string> Remarks { get; }
        public List<Payable> Payables { get; }
        public string AccountsPayableType { get; set; }
        public bool VariableCost { get; set; }

        public void RefreshData()
        {
            foreach (var item in Payables)
            {
                var hasTransactionDate = TransactionDate != null;
                var hasChequeVoucherNumber = !string.IsNullOrWhiteSpace(ChequeVoucherNumber);
                var hasPayee = Payee != null;

                if (!hasTransactionDate)
                {
                    TransactionDate = item.TransactionDate;
                }

                if (!hasChequeVoucherNumber)
                {
                    ChequeVoucherNumber = item.ChequeVoucherNumber;
                }

                if (!hasPayee)
                {
                    Payee = item.Supplier;
                }

                GrandTotal += item.Value;
            }
        }
    }
}
