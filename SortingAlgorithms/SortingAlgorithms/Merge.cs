using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Merge
    {
        /// <summary>
        /// Merge sort an array, method is called recursively
        /// </summary>
        /// <param name="arr">Current array to be sorted</param>
        /// <returns>Sorted array</returns>
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }
                int[] right = new int[n-mid];
                for (int i = mid; i < n; i++)
                {
                    right[i-mid] = arr[i];
                }

                left = MergeSort(left);
                right = MergeSort(right);
                return MergeHelper(left, right, arr);
            }
            return arr;
        }

        /// <summary>
        /// Helper for MergeSort to handle the actual sorting of the subarrays
        /// </summary>
        /// <param name="left">Left sub-array</param>
        /// <param name="right">Right sub-array</param>
        /// <param name="arr">Current entire array</param>
        /// <returns>Sorted array</returns>
        private static int[] MergeHelper(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while(i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i ++;
                }
                else
                {
                    arr[k] = right[j];
                    j ++;
                }
                k ++;
            }
            while(i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while(j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
            return arr;
        }
    }
}
