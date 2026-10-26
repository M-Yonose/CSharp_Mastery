﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionExample
{
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }
        double GetDiscountedPrice(double discountPercentage);
    }
}