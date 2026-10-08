using System;
using System.Collections.Generic;
using System.Text;

namespace ImportantInterfaces
{
    public class Product : ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }

        public object Clone()
        {
            return new Product
            {
                ID = this.ID,
                Name = this.Name,
                Price = this.Price,
                Description = this.Description,
                Weight = this.Weight,
                Color = this.Color,
                Size = this.Size,
                Type = this.Type
            };
        }
    }
}