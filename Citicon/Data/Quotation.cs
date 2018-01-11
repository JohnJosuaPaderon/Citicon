using Citicon.Data.Converters;
using System;
using System.Text;

namespace Citicon.Data
{
    public class Quotation : EntityBase<ulong>
    {
        public Project Project { get; set; }
        public string QuotationNumber { get; set; }
        public DateTime QuotationDate { get; set; }
        public decimal Cost { get; set; }
        public string NoteDetails { get; set; }
        public QuotationStatus Status { get; set; }
        public ulong EngineerId { get; set; }
        public decimal EngineerAmount { get; set; }
        public uint RevisionNumber { get; set; }
        public Employee Agent { get; set; }
        public QuotationType Type { get; set; }
        public uint Number { get; set; }
        public bool InHouseAgent { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public decimal? VatExcluded { get; set; }
        
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}-{1}", QuotationTypeConverter.GetPrefix(Type), Number);

            if (RevisionNumber > 0)
            {
                stringBuilder.AppendFormat(" rev.{0}", RevisionNumber);
            }

            return stringBuilder.ToString();
        }
    }
}
