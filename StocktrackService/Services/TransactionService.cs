using StocktrackService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktrackService.Services
{
    public class TransactionService : ITransactionService
    {
        public Transaction AddTransaction(Transaction transaction, int storeId, int productId)
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransactionById(int transactionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetTransactionsByProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetTransactionsByStore(int storeId)
        {
            throw new NotImplementedException();
        }
    }
}
