using StocktrackService.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocktrackService.Services
{
    public class ProductService : IProductService
    {
        public Product AddProduct(Product product, int storeId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId, int storeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts(int storeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> SearchProduct(string query, int storeId)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product, int storeId)
        {
            throw new NotImplementedException();
        }
    }
}
