using System;

namespace MaxSubArraySum
{
    public class FindMaxSubArray
    {
        public static void Main()
        {

        }

        /// <summary>
        /// Handles initially checking for edge cases then calling the recursive method to get the max sub array sum
        /// </summary>
        /// <param name="arr">Array to be searched</param>
        /// <returns>Highest sub-array sum within the given array</returns>
        public static int maxSequence(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int max = arr[0], temp = 0;

            foreach (var item in arr)
            {
                temp += item;
                if (max < temp) max = temp;
                if (temp < 0) temp = 0;
            }

            return max;
        }
    }
}
