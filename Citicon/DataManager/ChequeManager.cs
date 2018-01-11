using Citicon.Data;
using Citicon.DataProcess;
using System.Threading.Tasks;

namespace Citicon.DataManager
{
    public static class ChequeManager
    {
        public static async Task<VoidCheque> CancelAsync(VoidCheque voidCheque)
        {
            if (voidCheque != null)
            {
                using (var process = new CancelCheque(voidCheque))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return null;
            }
        }

        public static async Task<bool> IsCancelledAsync(string chequeNumber, BankAccount bankAccount)
        {
            if (!string.IsNullOrWhiteSpace(chequeNumber) && bankAccount != null)
            {
                using (var process = new VoidChequeExists(chequeNumber, bankAccount))
                {
                    return await process.ExecuteAsync();
                }
            }
            else
            {
                return false;
            }
        }
    }
}
