using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Product
    {
        public double Price {  get; set; }

        public Product(string name)
        {
            Name = name;
        }

    }
}
