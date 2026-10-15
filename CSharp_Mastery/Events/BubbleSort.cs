using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Events
{
    public class BubbleSort<T>
    {
        public event Action<T[]> OnSortComplete;
        public T[] Items { get; private set; }

        public BubbleSort(T[] arr)
        {
            Items = arr;
        }
        public void Sort(Func<T, T, bool> c)
        {
            T temp;
            bool swapped;
            for (int i = 0; i < Items.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < Items.Length - i - 1; j++)
                {
                    if (c(Items[j], Items[j + 1]))
                    {

                        temp = Items[j];
                        Items[j] = Items[j + 1];
                        Items[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }

            OnSortComplete.Invoke(Items);
        }
    }
}