using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Quick
    {
        public static int[] Sort(int[] arr)
        {
            return Sort(arr, 0, arr.Length - 1);
        }

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

        private static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
