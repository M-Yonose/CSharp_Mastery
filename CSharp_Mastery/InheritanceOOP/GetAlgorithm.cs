using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class GetAlgorithm
    {
        public Sort GetSortingAlgorithm(string algorithmName, int[] numbers)
        {
            if (algorithmName == "heapsort")
                return new HeapSort(numbers);
            else if (algorithmName == "qsort")
                return new QSort(numbers);
            else if (algorithmName == "bubblesort")
                return new BubbleSort(numbers);
            else
                return new MergeSort(numbers);            
        }
    }
}
