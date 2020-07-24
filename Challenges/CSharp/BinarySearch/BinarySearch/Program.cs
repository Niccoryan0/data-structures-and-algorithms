using System;

namespace BinarySearch
{
    public class Program
    {
        /// <summary>
        /// Calls the Binary Search method for examples
        /// </summary>
        static void Main()
        {
            BinarySearcher(new int[] { 4, 8, 15, 16, 23, 42 }, 15);
            BinarySearcher(new int[] { 11, 22, 33, 44, 55, 66, 77 }, 90);
        }

        /// <summary>
        /// Performs a binary search
        /// </summary>
        /// <param name="arr">Array to be searched</param>
        /// <param name="key">Key to search for</param>
        /// <returns>Index value for key if it's in the array, -1 if it isn't</returns>
        public static int BinarySearcher(int[] arr, int key)
        {
            int start = 0;
            int max = arr.Length - 1;
            while(start <= max)
            {
                int midpoint = (start + max) / 2;
                if (key == arr[midpoint])
                {
                    return midpoint;
                } else if (key < arr[midpoint])
                {
                    max = midpoint - 1;
                } else
                {
                    start = midpoint + 1;
                }
            }
            return -1;
        }
    }
}
