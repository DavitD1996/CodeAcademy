using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework1.Shopping_System.PriceCalculator;

namespace Homework1.Shopping_System
{
    public class ShopingCart
    {
        private List<Product> products;
        public ShopingCart(List<Product> products) {
            this.products = products;
        }
        public Order Checkout(DiscountCalculator calculator)
        {
            int totalPrice=PriceCalculator.PriceForAllProducts(products);
            int discountedPrice = calculator.Invoke(totalPrice);
            return new Order.OrderBuilder().AddAllProducts(products).AddDiscountedPrice(discountedPrice).Build();
        }
    }
}
