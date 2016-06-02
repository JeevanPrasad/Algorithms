using System;

namespace Algorithms
{
    /// <summary>
    /// Binary search (a.k.a half-interval search)
    ///==========================================
    ///     Given a sorted array, the binary search finds the index of a desired value by splitting the array into two halves and search repeatedly(either recursively(call itself over and over) or iteratively(loop))
    ///
    ///     Problem
    ///     -------
    ///         Given a sorted array arr[n] of n elements, find the index of given element x
    ///         
    ///     References (to cross verify after you are complete)
    ///     ---------------------------------------------------
    ///     http://www.tutorialspoint.com/data_structures_algorithms/binary_search_algorithm.htm
    ///     http://geeksquiz.com/binary-search/
    /// </summary>
    internal static class BinarySearch
    {
        #region recursivesearch
        internal static void Recursively(int[] arr, int x)
        {
            Console.WriteLine("Binary Search - Recursive");
            int startIdx = 0;
            int endIdx = arr.Length - 1;

            DoRecursiveSearch(arr, startIdx, endIdx, x);

        }
        internal static void DoRecursiveSearch(int[] arr, int startIdx, int endIdx, int x)
        {
            if (endIdx >= startIdx)
            {
                int middle = startIdx + ((endIdx - startIdx) / 2);
                if (arr[middle] == x)
                {
                    Console.WriteLine(x + " is found");
                    return;
                }
                else if (arr[middle] > x)  ///search the left side from the middle
                {
                    DoRecursiveSearch(arr, startIdx, middle - 1, x);
                }
                else  ///search the right side from the middle
                {
                    DoRecursiveSearch(arr, middle + 1, endIdx, x);
                }
            }
        }
        #endregion

        #region iterativesearch
        internal static void Iteratively(int[] arr, int x)
        {
            Console.WriteLine("Binary Search - Iterative");
            int startIdx = 0;
            int endIdx = arr.Length - 1;
            int middle = 0;

            while (startIdx <= endIdx)
            {
                middle = startIdx + ((endIdx - startIdx) / 2);

                if (arr[middle] == x)
                {
                    Console.WriteLine(x + " is found");
                    return;
                }
                else if (arr[middle] > x)  ///search the left side from the middle
                {
                    endIdx = middle - 1;
                }
                else  ///search the right side from the middle
                {
                    startIdx = middle + 1;
                }
            }
        }
        #endregion
    }
}
