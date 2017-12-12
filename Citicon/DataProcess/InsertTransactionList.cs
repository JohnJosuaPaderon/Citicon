using Citicon.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Citicon.DataProcess
{
    internal sealed class InsertTransactionList : DataProcessBase
    {
        public InsertTransactionList(IEnumerable<Transaction> transactions)
        {
            _Transactions = transactions;
        }

        private readonly IEnumerable<Transaction> _Transactions;

        public async Task<IEnumerable<Transaction>> ExecuteAsync()
        {
            using (var connection = await Utility.EstablishConnectionAsync())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in _Transactions)
                        {
                            using (var process = new InsertTransaction(item))
                            {
                                await process.ExecuteAsync(connection, transaction);
                            }
                        }

                        transaction.Commit();
                        return _Transactions;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
