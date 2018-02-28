using System;

namespace Citicon.Data
{
    public sealed class ClientAdvancePayment : EntityBase<ulong>
    {
        public ClientAdvancePayment(Client client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Client Client { get; }
        public DateTime TransactionDate { get; set; }
        public decimal AddedValue { get; set; }
    }
}
