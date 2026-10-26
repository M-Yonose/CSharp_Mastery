using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionExample
{
    public static class DataSender
    {
        public static IProduct SendData()
        {
            return new Product("Camera", 2000);
        }
    }
}
