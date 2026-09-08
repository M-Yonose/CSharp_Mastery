using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Product
    {
        public string Name { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
