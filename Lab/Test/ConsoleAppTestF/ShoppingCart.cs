using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestF
{
    internal class ShoppingCart
    {
        private List<string> cart = new List<string>();

        public void AddItem(string itemName, int quantity)
        {
            cart.Add("Item:" + itemName + " , Quantity:" + quantity);
        }

        public void AddItem(string itemName, int quantity, double price)
        {
            cart.Add("Item:" + itemName + " , Quantity:" + quantity + " , Price:" + price);
        }

        public void AddItem(int itemCode, int quantity)
        {
            cart.Add("Item Code:" + itemCode + " , Quantity:" + quantity);
        }

        public void DisplayCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine(item);
            }
        }
    }
}
