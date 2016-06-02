using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Selection Sort
    ///==============
    ///     References (to cross verify after you are complete)
    ///     ---------------------------------------------------
    ///     http://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm
    ///     http://geeksquiz.com/selection-sort/
    /// </summary>
    internal static class SelectionSort
    {

        internal static void Sort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                  {
                     if (arr[j] < arr[i])
                      {
                         temp = arr[i];
                         arr[i] = arr[j];
                         arr[j] = temp;
                      }
                  }
            }
            DisplayResult(arr);
        }

        private static void DisplayResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
