using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Products {

    [ServiceContract]
    public interface IProductsService {
        // Get the product number of every product
        [OperationContract]
        List<string> ListProducts();

        // Get the details of a single product
        [OperationContract]
        ProductData GetProduct(string productNumber);

        // Get the current stock level for a product
        [OperationContract]
        int CurrentStockLevel(string productNumber);

        // Change the stock level for a product
        [OperationContract]
        bool ChangeStockLevel(string productNumber, short newStockLevel, string shelf, int bin);
        
    }


    [DataContract]
    public class ProductData {
        [DataMember]
        public string Name;
        
        [DataMember]
        public string ProductNumber;

        [DataMember]
        public string Color;

        [DataMember]
        public decimal ListPrice;
    }
       
}
