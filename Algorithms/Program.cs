using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Binary Search
            //int[] arr = new int[] { 1, 4, 5, 7, 10, 12 }; //sorted array 
            //int x = 7; //number to find

            //BinarySearch.Recursively(arr, x); 
            //BinarySearch.Iteratively(arr, x); 
            #endregion

            #region Bubble Sort
            //int[] arr = new int[] { 7, 4, 3, 12, 10, 13 }; //array that has to be sorted
            //BubbleSort.Sort(arr);
            #endregion

            #region Insertion Sort
            int[] arr = new int[] { 14, 33, 27, 10, 25, 19 }; //array that has to be sorted
            int temp;
            for (int i=0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    for (int j=i+1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            #region Selection Sort
            #endregion

            Console.Read();
        }
    }
}
