using System;

namespace SortingAlgorithms
{
    public class Insertion
    {
        /// <summary>
        /// Sort an array via Insertion Sorting
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <returns>Sorted array</returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
