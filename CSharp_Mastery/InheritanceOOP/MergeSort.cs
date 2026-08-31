using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class MergeSort : Sort
    {
        public MergeSort(int[] numbers) : base (numbers)
        {

        }
        public override void SortAscending()
        {
            Console.WriteLine("Sorting using MergeSort Algorithm!");
        }
    }
}
