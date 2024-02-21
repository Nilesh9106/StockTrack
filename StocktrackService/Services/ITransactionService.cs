using StocktrackService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StocktrackService.Services
{
    [ServiceContract]
    public interface ITransactionService
    {
        [OperationContract]
        Transaction GetTransactionById(int transactionId);
        [OperationContract]
        IEnumerable<Transaction> GetTransactionsByStore(int storeId);
        [OperationContract]
        IEnumerable<Transaction> GetTransactionsByProduct(int productId);
        [OperationContract]
        Transaction AddTransaction(Transaction transaction,int storeId,int productId);
        [OperationContract]
        void DeleteTransaction(int id);

    }
}
