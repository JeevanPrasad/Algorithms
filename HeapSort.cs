using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class HeapSort
    {
        static int[] arr = new int[] { 14, 33, 27, 88, 10, 25, 19 }; //array that has to be sorted

        public static void Start()
        {
            Sort(arr, arr.Length);
            DisplayResult(arr);
        }

        private static void Sort(int[] arr, int length)
        {
            // Start from the last Parent and keep moving up. 
            // Last Parent = N/2 - 1. Do this for each parent
            var N = arr.Length;
            for (int i = (N/2)-1; i >=0; i--)
            {
                Heapify(i, arr.Length);
            }
            // Remove one element from top and move to end 
            // Re-heapify the smaller input set  
            for (int i = N - 1; i >= 0; i--)
            {
                swap(0, i);
                Heapify(0, i);
            }
        }

        private static void Heapify(int parent, int length)
        {
            //find left child and right child of parent
            var leftChild = parent * 2 + 1;
            var rightChild = parent * 2 + 2;

            //check if there really is a leftChild
            if (leftChild < length)
            {
                //check if leftChild is lesser than parent
                if (arr[leftChild] < arr[parent])
                {
                    //swap
                    swap(leftChild, parent);
                }
            }

            //check if there really is a rightChild
            if (rightChild < length)
            {
                //check if rightChild is lesser than parent
                if (arr[rightChild] < arr[parent])
                {
                    //swap
                    swap(rightChild, parent);
                }
            }

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
        }
    }
}
