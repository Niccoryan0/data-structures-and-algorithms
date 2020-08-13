using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Quick
    {
        /// <summary>
        /// Overall handler, calls the initial Sort with inital left and right values
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <returns>Sorted array</returns>
        public static int[] QuickSort(int[] arr)
        {
            return Sort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Handles the partitioning to find the pivot point and sorting based off the pivot
        /// </summary>
        /// <param name="arr">Array being sorted</param>
        /// <param name="left">Left point of sort</param>
        /// <param name="right">Right point of sort</param>
        /// <returns>Sorted array</returns>
        public static int[] Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);
                Sort(arr, left, position - 1);
                Sort(arr, position + 1, right);
            }
            return arr;
        }

        /// <summary>
        /// Handles the partitioning, calls Swap for the numbers if they are found to be unsorted and returns the current position in the sort
        /// </summary>
        /// <param name="arr">Array being sorted</param>
        /// <param name="left">Left point of sort</param>
        /// <param name="right">Right point of sort</param>
        /// <returns>Pivot position of array</returns>
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        /// <summary>
        /// Swap individuals numbers within the array
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="i">Right index to swap</param>
        /// <param name="low">Left index to swap</param>
        private static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
