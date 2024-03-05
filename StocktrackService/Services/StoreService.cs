using StocktrackService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktrackService.Services
{
    public class StoreService : IStoreService
    {
        private readonly AppDbContext db;

        StoreService()
        {
            db = new AppDbContext();
        }

        public Store AddStore(Store store)
        {
            Store s = db.Stores.Add(store);
            db.SaveChanges();
            return s;
        }

        public void DeleteStore(int id)
        {
            Store s = db.Stores.Find(id);
            if (s != null)
            {
                db.Products.RemoveRange(db.Products.Where(p => p.Store.Id == id));
                db.Transactions.RemoveRange(db.Transactions.Where(p => p.Store.Id  == id));
                db.Stores.Remove(s);
                db.SaveChanges();
            }
        }

        public Store GetStoreById(int id)
        {
            return db.Stores.Find(id);
        }
        public Store GetStoreByEmail(string email)
        {
            return db.Stores.Where(p=>p.Email == email).FirstOrDefault();
        }

        public List<Store> GetStores()
        {
            return db.Stores.ToList();
        }

        public Store UpdateStore(Store store)
        {
            var s = db.Stores.Find(store.Id);
            if (s != null)
            {
                s.Email = store.Email;
                s.Name = store.Name;
                s.Password = store.Password;
            }
            db.SaveChanges();

            return s;
        }

        public Response Verify(string email, string password)
        {
            Store s = db.Stores.Where(p=>p.Email == email).FirstOrDefault();
            if (s != null)
            {
                if(s.Password == password)
                {
                    return new Response { Code = 200, Message = "Login successfull" };
                }
                else
                {
                    return new Response { Code = 401, Message = "Wrong credential" };
                }
            }
            else
            {
                return new Response { Code = 404, Message = "Store not found" };
            }
        }
    }
}
