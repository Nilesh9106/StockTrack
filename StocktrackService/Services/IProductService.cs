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
    public interface IProductService
    {
        [OperationContract]
        IEnumerable<Product> GetProducts(int storeId);
        [OperationContract]
        Product GetProductById(int productId,int storeId);
        [OperationContract]
        IEnumerable<Product> SearchProduct(string query, int storeId);
        [OperationContract]
        Product AddProduct(Product product, int storeId);
        [OperationContract]
        Product UpdateProduct(Product product, int storeId);
        [OperationContract]
        void DeleteProduct(int id);
    }
}
