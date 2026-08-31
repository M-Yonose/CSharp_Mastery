using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class BubbleSort : Sort
    {
        public BubbleSort(int[] numbers) : base (numbers)
        {

        }
        public override void SortAscending()
        {
            Console.WriteLine("Sorting using BubbleSort Algorithm!");
        }

    }
    
}
