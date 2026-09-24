using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GenericsExamples
{
    public class BubbleSort2
    {
        public static T[] Sort<T>(T[] arr) where T : INumber<T>
        {
            T temp;
            bool swapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }

            return arr;
        }
    }
}