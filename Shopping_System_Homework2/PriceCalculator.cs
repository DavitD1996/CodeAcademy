using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Shopping_System
{
    public class PriceCalculator
    {
        private static double commonDiscount = 0.2;
        private static double vipDiscount = 0.5;
        private static double saleDiscount = 0.6;
        public delegate int DiscountCalculator(int totalPrice);
        public static int PriceForAllProducts(List<Product> products)
        {
            int total = 0;
            foreach (Product product in products)
            {
                total += product.Price;
            }
            return total;
        }
        public static int RegularCustomerDiscount(int total)
        {
            return (int)(total-(total * commonDiscount));
         }
        public static int VIPCustomerDiscount(int total)
        {
            return (int)(total * vipDiscount);
        }
        public static int SaleDiscount(int total)
        {
            return (int)(total * saleDiscount);
        }
    }
}
