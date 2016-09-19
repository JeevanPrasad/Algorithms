using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class CountingSort
    {
        //static int[] arr = new int[] { 0, 3, 2, 3, 3, 0, 5, 2, 3 }; //array that has to be sorted
        //static int[] arr = new int[] { 1, 3, 2, 3, 3, 6, 5, 2, 3 }; //with no zeroes
        static int[] arr = new int[] { 0, 3, -2, 3, 3, 0, 5, 2, 3 }; //has a negative number

        public static void Start()
        {
            //find highest number in arr.
            int n = arr[0];
            for (int i=0; i < arr.Length; i++)
            {
                if (arr[i] > n)
                {
                    n = arr[i];
                }
                
            }

            //create count array with n + 1.
            int[] count = new int[n + 1];

            //count number of occurence of each index
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }

            //modify count array so each index has the sum of prev index
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i-1] + count[i];
            }

            //create result array
            int[] resultArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                resultArr[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            //display result
            for (int i = 0; i < resultArr.Length; i++)
            {
                Console.Write(resultArr[i] + " ");
            }
            
        }
    }
}
