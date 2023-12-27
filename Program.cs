using Homework1.BankAccount;
using Homework1.CalculationUtility;
using Homework1.Shopping_System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product.ProductBuilder().GivePrice(500).GiveName("Apple").Build();
            Product product2 = new Product.ProductBuilder().GivePrice(400).GiveName("pinApple").Build();
            products.Add(product1);
            products.Add(product2);
            ShopingCart cart = new ShopingCart(products);
            Order order = cart.Checkout(PriceCalculator.RegularCustomerDiscount);
            order.PrintAllProducts();
        }
    }
}
