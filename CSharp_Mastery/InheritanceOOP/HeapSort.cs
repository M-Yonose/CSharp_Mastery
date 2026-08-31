using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class HeapSort : Sort
    {
        public HeapSort(int[] numbers) : base(numbers)
        {

        }
        public override void SortAscending()
        {
            Console.WriteLine("Sorting using HeapSort Algorithm!");
        }
    }
            
}
