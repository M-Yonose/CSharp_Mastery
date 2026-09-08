using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClass
{
    public class Demo
    {
        private int _counter = 0;

        public void Increase()
        {
            _counter++;
        }

        public void Decrease()
        {
            _counter--;
        }

        public int GetCounter()
        {
            return _counter;
        }
    }
}
