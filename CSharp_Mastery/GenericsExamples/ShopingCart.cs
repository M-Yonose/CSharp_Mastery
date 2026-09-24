using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace GenericsExamples
{
    public class ShoppingCart<T>
    public class ShoppingCart<T, Q>
        where T : class, IProduct<Q>, new()
        where Q : struct, INumber<Q>
    {
        private T[] _items;
        private readonly T[] _items;

        public ShoppingCart(T[] items)
        {
            _items = items;
        }

        public int GetTotal()
        public Q GetTotal()
        {
            var total = 0;
            var total = default(Q);
            foreach (var item in _items)
            {

                total += item.Price;
            }
            return total;
        }