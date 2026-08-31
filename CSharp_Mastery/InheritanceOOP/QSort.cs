using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class QSort : Sort
    {
        public QSort(int[] numbers) : base(numbers)
        {
        }
        public override void SortAscending()
        {
            Console.WriteLine("Sorting using QSort Algorithm!");
        }
    }
}
