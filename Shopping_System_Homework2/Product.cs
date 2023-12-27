using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Shopping_System
{
    public class Product
    {
        private string name;
        private int price;
        private string description;

        private Product() {; }

        public string Name { get => name; set {; } }
        public int Price { get => price; set {; } }
        public string Description { get => description;set {; } }

        public class ProductBuilder
        {
            private Product product = new Product();
            public ProductBuilder GiveName(string name)
            {
                product.name = name;
                return this;
            }
            public ProductBuilder GiveDescription(string description)
            {
                product.description = description;
                return this;
            }
            public ProductBuilder GivePrice(int price)
            {
                product.price = price;
                return this;
            }
            public Product Build() { return product; } 
        }
            
    }
}
