using Citicon.Data;
using System;

namespace Citicon.DataProcess
{
    internal sealed class ValidateClient : IDisposable
    {
        public ValidateClient(Client client)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        private Client Client;

        public void Dispose()
        {
            Client = null;
        }

        public ValidationResult Execute()
        {
            if (string.IsNullOrWhiteSpace(Client.CompanyName))
            {
                return new ValidationResult(false, "Invalid company name.");
            }
            else if (string.IsNullOrWhiteSpace(Client.Position))
            {
                return new ValidationResult(false, "Invalid contact person's position.");
            }
            else if (string.IsNullOrWhiteSpace(Client.FirstName))
            {
                return new ValidationResult(false, "Invalid contact person's first name.");
            }
            else if (string.IsNullOrWhiteSpace(Client.LastName))
            {
                return new ValidationResult(false, "Invalid contact person's last name.");
            }
            else if (string.IsNullOrWhiteSpace(Client.ContactNumber))
            {
                return new ValidationResult(false, "Invalid contact person's contact no.");
            }
            else if (string.IsNullOrWhiteSpace(Client.Tin))
            {
                return new ValidationResult(false, "Invalid TIN.");
            }
            else
            {
                return new ValidationResult(true);
            }
        }
    }
}
