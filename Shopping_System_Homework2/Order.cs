using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Shopping_System
{
    public class Order
    {
        private Dictionary<int, Product> orderedProducts;
        private int discountedPrice;
        private Order() {
            orderedProducts = new Dictionary<int, Product>();
        }
        public void PrintAllProducts()
        {
            foreach (var product in orderedProducts)
            {
                Console.WriteLine(product.Key+" "+product.Value.Name);
            }
            Console.WriteLine($"the discounted total price is {discountedPrice}");
        }
        public class OrderBuilder
        {
            private Order order = new Order();
            public OrderBuilder AddCeratainProduct(Product product, int orderKey)
            {
                if (order.orderedProducts.ContainsKey(orderKey))
                {
                    Console.WriteLine("The key already exists and the product will be removed");
                    order.orderedProducts.Remove(orderKey);
                }
                else
                {
                    order.orderedProducts.Add(orderKey, product);
                }
                return this;
            }
            public OrderBuilder AddAllProducts(List<Product> products)
            {
                int orderKey = 1;
                foreach (Product product in products)
                {
                    order.orderedProducts[orderKey] = product;
                    orderKey++;
                }
                return this;
            }
            public OrderBuilder AddDiscountedPrice(int data)
            {
                order.discountedPrice= data;
                return this;
            }
            public Order Build()
            {
                return order;
            }
        }
    }
}
