using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExamples
{
    //public interface IProduct
    public interface IProduct<T>
    {
        string Name { get; }
        //int Price { get; }
        T Price { get; }
    }
}
