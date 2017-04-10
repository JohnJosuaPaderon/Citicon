using Citicon.Data.Converters;
using System;
using System.Collections.Generic;

namespace Citicon.Data
{
    public class ChequeVoucher
    {
        public ChequeVoucher(bool variableCost, PayableType accountsPayableType)
        {
            MRISRemarks = new Dictionary<string, decimal>();
            Payables = new List<Payable>();
            VariableCost = variableCost;
            AccountsPayableType = accountsPayableType;
        }

        public DateTime? TransactionDate { get; private set; }
        public string ChequeVoucherNumber { get; private set; }
        public Supplier Payee { get; private set; }
        public decimal GrandTotal { get; private set; }
        public string ExpenseRemarks { get; private set; }
        public string VariableCostRemarks { get; private set; }
        public Dictionary<string, decimal> MRISRemarks { get; }
        public List<Payable> Payables { get; }
        public PayableType AccountsPayableType { get; }
        public bool VariableCost { get; }

        public void RefreshData()
        {
            Payable accountsPayable = null;
            Payable withHoldingTaxPayable = null;
            Payable cashInBankPayable = null;

            foreach (var payable in Payables)
            {
                var hasTransactionDate = TransactionDate != null;
                var hasChequeVoucherNumber = !string.IsNullOrWhiteSpace(ChequeVoucherNumber);
                var hasPayee = Payee != null;

                if (!hasTransactionDate)
                {
                    TransactionDate = payable.TransactionDate;
                }

                if (!hasChequeVoucherNumber)
                {
                    ChequeVoucherNumber = payable.ChequeVoucherNumber;
                }

                if (!hasPayee)
                {
                    Payee = payable.Supplier;
                }

                if (VariableCost)
                {
                    if (string.IsNullOrWhiteSpace(VariableCostRemarks))
                    {
                        VariableCostRemarks = payable.Remarks;
                    }

                    if (payable.Stock != null)
                    {
                        if (!MRISRemarks.ContainsKey(payable.Stock.MrisNumber))
                        {
                            MRISRemarks.Add(payable.Stock.MrisNumber, 0);
                        }

                        MRISRemarks[payable.Stock.MrisNumber] += payable.Value;
                    }

                    if (payable.Expense == Expense.WithHoldingTax)
                    {
                        withHoldingTaxPayable = payable;
                    }
                    else
                    {
                        GrandTotal += payable.Debit;
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(ExpenseRemarks))
                    {
                        ExpenseRemarks = payable.Remarks;
                    }

                    if (payable.Expense == Expense.CashInBank)
                    {
                        GrandTotal += payable.Value;
                    }
                }
            }

            if (VariableCost)
            {
                accountsPayable = new Payable()
                {
                    Description = string.Format("ACCOUNTS PAYABLE {0}", PayableTypeConverter.ToDisplay(AccountsPayableType)),
                    Debit = GrandTotal
                };

                cashInBankPayable = new Payable()
                {
                    Description = "* CASH IN BANK",
                    Credit = GrandTotal
                };

                Payables.Clear();
                Payables.Add(accountsPayable);

                if (withHoldingTaxPayable != null)
                {
                    Payables.Add(withHoldingTaxPayable);
                }

                if (cashInBankPayable != null)
                {
                    Payables.Add(cashInBankPayable);
                }
            }

            GrandTotal = Math.Abs(GrandTotal);
        }
    }
}
