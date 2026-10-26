using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionExample
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product (string name, double price)
        {
            Name = name;    
            Price = price;
        }
        public double GetDiscountedPrice(double discountPercentage)
        {
            return Price - (Price * discountPercentage / 100);
        }
   
    

    }
}
