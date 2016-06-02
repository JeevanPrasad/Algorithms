using System;

namespace Algorithms
{
    /// <summary>
    /// Bubble Sort
    ///==============
    ///     Each pair of adjacent elements is compared and elements are swapped if they are not in order
    ///         
    ///     References (to cross verify after you are complete)
    ///     ---------------------------------------------------
    ///     http://www.tutorialspoint.com/data_structures_algorithms/bubble_sort_algorithm.htm
    ///     http://geeksquiz.com/bubble-sort/
    /// </summary>
    internal static class BubbleSort
    {
        internal static void Sort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else
                    {
                        j = 0; //get out of the loop
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
