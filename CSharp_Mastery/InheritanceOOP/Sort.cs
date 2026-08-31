using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class Sort
    {
        public int[] Numbers { get; protected set; }

        public Sort(int[] numbers)
        {
            Numbers = numbers;
        }
        public virtual void SortAscending()
        {
            
        }
    }
}
