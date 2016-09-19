using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class InsertionSort
    {
        internal static void Start()
        {
            int[] arr = new int[] { 14, 33, 27, 10, 25, 19 }; //array that has to be sorted
            Sort(arr);
            DisplayResult(arr);
        }

        private static void Sort(int[] arr)
        {
            int tmp;
            int j;
            for (int i = 1; i < arr.Length; i++)
            {
                j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    tmp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = tmp;
                    j--;
                }
            }
        }
        
        private static void DisplayResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
