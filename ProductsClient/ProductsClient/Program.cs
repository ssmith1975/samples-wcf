using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ProductsClient.ProductsService;

namespace ProductsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a proxy object and connect to the service
            ProductsServiceClient proxy = new ProductsServiceClient("NetTcpBinding_IProductsService");

            // Test the operations in the service

            // Obtain a list of all products
            Console.WriteLine("Test 1: List all products");
            string[] productNumbers = proxy.ListProducts();


            foreach (string productNumber in productNumbers)
            {
                Console.WriteLine("Number: {0}", productNumber);
            }

            Console.WriteLine();

            // Display details of a product
            Console.WriteLine("Test 2: Display the details of a product");
            ProductData product = proxy.GetProduct("WB-H098");
            Console.WriteLine("Number: {0}", product.ProductNumber);
            Console.WriteLine("Name: {0}", product.Name);
            Console.WriteLine("Color: {0}", product.Color);
            Console.WriteLine("Price: {0}", product.ListPrice);
            Console.WriteLine();

            // Query the stock level of this product
            Console.WriteLine("Test 3: Display6 the stock level of a product");
            int numInStock = proxy.CurrentStockLevel("WB-H098");
            Console.WriteLine("Current stock level: {0}", numInStock);
            Console.WriteLine();

            // Modify the stock level of this product
            Console.WriteLine("Test 4: Modify the stock level of a product");

            if (proxy.ChangeStockLevel("WB-H098", 100, "N/A", 0))
            {
                numInStock = proxy.CurrentStockLevel("WB-H098");
                Console.WriteLine("Stock changed. Current stock level: {0}", numInStock);
            }
            else
            {
                Console.WriteLine("Stock level update failed");
            }
            Console.WriteLine();

            // Disconnect from the service
            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
