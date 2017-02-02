namespace Citicon.Data
{
    public class SalesInvoice
    {
        public string Number { get; set; }
        public decimal TotalAmountDue { get; set; }

        public override bool Equals(object obj)
        {
            return (obj is SalesInvoice) ? ((SalesInvoice)obj).Number == Number : false;
        }
        public override int GetHashCode()
        {
            return Number?.GetHashCode() ?? 0;
        }
        public override string ToString()
        {
            return Number ?? string.Empty;
        }
    }
}
