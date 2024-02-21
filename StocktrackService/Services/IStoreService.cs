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
    public interface IStoreService
    {
        [OperationContract]
        Store GetStoreById(int id);
        [OperationContract]
        Store AddStore(Store store);
        [OperationContract]
        Store UpdateStore(Store store);
        [OperationContract]
        void DeleteStore(int id);
    }
}
