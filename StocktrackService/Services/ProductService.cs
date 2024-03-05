using StocktrackService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace StocktrackService.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext db;

        ProductService()
        {
            db = new AppDbContext();
        }
        public Product AddProduct(Product product, int storeId)
        {
            product.Store = db.Stores.Find(storeId);
            Product p = db.Products.Add(product);
            db.SaveChanges();
            return p;
        }

        public void DeleteProduct(int id)
        {
            Product p = db.Products.Find(id);
            if (p != null)
            {
                db.Transactions.RemoveRange(db.Transactions.Where(x => x.Product.Id == id));
                db.Products.Remove(p);
                db.SaveChanges();
            }
        }

        public Product GetProductById(int productId)
        {
            return db.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts(int storeId)
        {
            IEnumerable<Product> products = db.Products.Where(p => p.Store.Id == storeId).Include("Store");
            return products;
        }

        public IEnumerable<Product> SearchProduct(string query, int storeId)
        {
            IEnumerable<Product> products = db.Products.Where(p=>p.Description.ToLower().Contains(query.ToLower()) || p.Name.ToLower().Contains(query.ToLower()));
            return products;
        }

        public Product UpdateProduct(Product product, int storeId)
        {
            var p = db.Products.Find(product.Id);
            if (p != null)
            {
                p.Price = product.Price;
                p.Description = product.Description;
                p.Name = product.Name;
                p.Qty = product.Qty;
                p.Category = product.Category;
                p.Brand = product.Brand;
            }
            db.SaveChanges();
            return p;
        }
    }
}
