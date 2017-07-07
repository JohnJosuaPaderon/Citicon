using Citicon.Data.Converters;
using System;
using System.Text;

namespace Citicon.Data
{
    public class Quotation
    {
        public ulong Id { get; set; }
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
        public PaymentTerm PaymentTerm { get; set; }

        public static bool operator ==(Quotation left, Quotation right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if ((object)left == null || (object)right == null)
                return false;

            return left.Id == right.Id;
        }

        public static bool operator !=(Quotation left, Quotation right)
        {
            return !(left == right);
        }

        public override bool Equals(object arg)
        {
            if (arg is Quotation)
            {
                return (Quotation)arg == this;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
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
