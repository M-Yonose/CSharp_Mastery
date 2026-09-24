using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExamples
{
    public class Point<T, Q>
    {
        public T X { get; set; }
        public Q Y { get; set; }

        public Point(T x, Q y)
        {
            X = x;
            Y = y;
        }

        public void Add(Point<T, Q> other)
        {
            dynamic x1 = X;
            dynamic y1 = Y;
            dynamic x2 = other.X;
            dynamic y2 = other.Y;
            X = x1 + x2;
            Y = y1 + y2;
        }
    }
}
