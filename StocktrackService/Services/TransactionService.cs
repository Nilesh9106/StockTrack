using StocktrackService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StocktrackService.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly AppDbContext db;

        TransactionService()
        {
            db = new AppDbContext();
        }
        public Transaction AddTransaction(Transaction transaction, int storeId, int productId)
        {
            var p = db.Products.Find(productId);
            if (transaction.Type.ToLower().Equals("sell"))
            {
                p.Qty -= transaction.Qty;
            }
            else
            {
                p.Qty += transaction.Qty;
            }
            transaction.added= DateTime.Now;

            transaction.Product = p;
            transaction.Store = db.Stores.Find(storeId);
            transaction = db.Transactions.Add(transaction);
            db.SaveChanges();
            return transaction;
        }

        public void DeleteTransaction(int id)
        {
            var  transaction = db.Transactions.Where(t => t.Id == id).Include("Product").FirstOrDefault();
            if(transaction != null)
            {
                var p = db.Products.Find(transaction.Product.Id);
                if (transaction.Type =="sell")
                {
                    p.Qty += transaction.Qty;
                }
                else
                {
                    p.Qty -= transaction.Qty;
                }
                db.Transactions.Remove(transaction);
                db.SaveChanges();
            }
        }

        public Transaction GetTransactionById(int transactionId)
        {
            Transaction t = db.Transactions.Find(transactionId);
            return t;
        }

        public IEnumerable<Transaction> GetTransactionsByProduct(int productId)
        {
            return db.Transactions.Where(p => p.Product.Id == productId).Include("Product").ToList();
        }

        public IEnumerable<Transaction> GetTransactionsByStore(int storeId)
        {
            return db.Transactions.Where(p=>p.Store.Id == storeId).Include("Product").ToList();
        }
    }
}
