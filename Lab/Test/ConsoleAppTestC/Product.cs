using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestC
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        
        public Product(int productID, string productName, decimal price)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Price = price;
        }
        
        public void DisplayProductDetails()
        {
            Console.WriteLine("--Product Details--");
            Console.WriteLine("Product ID : " + ProductID);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price : " + Price);
        }
    }
}
