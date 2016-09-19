using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class QuickSort
    {
        static int[] arr = new int[] { 14, 33, 27, 10, 25, 19 }; //array that has to be sorted

        internal static void Start()
        {
            DisplayResult(arr);
            Sort(0, arr.Length - 1);
            DisplayResult(arr);
        }

        private static void Sort(int leftIdx, int rightIdx)
        {
            //base case
            if (leftIdx < rightIdx)
            { 
                //Step 1 − Make the right - most index value pivot
                int pivot = arr[rightIdx];
                //Step 2 − partition the array using pivot value
                int partitionIdx = Partition(leftIdx, rightIdx, pivot);
                //Step 3 − quicksort left partition recursively
                Sort(leftIdx, partitionIdx - 1);
                //Step 4 − quicksort right partition recursively
                Sort(partitionIdx + 1, rightIdx);
            }
        }

        private static int Partition(int leftIdx, int rightIdx, int pivot)
        {
            int pIndex = leftIdx;
            for (int i = leftIdx; i < rightIdx; i++)
            {
                if (arr[i] <= pivot)
                {
                    swap(i, pIndex);
                    pIndex++;
                }
            }
            swap(pIndex, rightIdx);
            return pIndex;
        }

        private static void swap(int i1, int i2)
        {
            int temp = arr[i2];
            arr[i2] = arr[i1];
            arr[i1] = temp;
        }

        private static void DisplayResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" ");
        }

    }
}
